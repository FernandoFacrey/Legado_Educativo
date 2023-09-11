using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace WebLegadoEducativo02
{
    public partial class WebLE02InicioCreaCuenta : System.Web.UI.Page
    {
        public class Globlal
        {
            public static string ArrCodigo { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Session.Abandon();
                    Pnl_RecuContra.Visible = false;
                    Pnl_IngresaCorreo.Visible = true;
                    Pnl_FormRecuContra.Visible = false;
                    Pnl_CambioContra.Visible = false;
                    Pnl_CodigoRecuContra.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }

            System.Web.UI.HtmlControls.HtmlGenericControl divControl = Master.FindControl("dv_Btn_MenuIniciarLE") as System.Web.UI.HtmlControls.HtmlGenericControl;
            if (divControl != null)
            {
                divControl.Attributes["class"] = "dv_btn_Menu_selected";
            }
            else
            {
                divControl.Attributes["class"] = "dv_btn_Menu";
            }
        }

        protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Page.Validate("VG02");
            if (Page.IsValid)
            {
                try
                {
                    WS_LE_ConsUsuext.WS_LE_ConsUsuext wscue = new WS_LE_ConsUsuext.WS_LE_ConsUsuext();
                    var contrahash = wscue.ConUsuExt(txtB_IniciaCorreoElec.Text, "DIDE");

                    if (contrahash[0].mensaje.Contains("Sin Registros 0"))
                    {
                        Session.Abandon();
                        lbl_VerificaCorreoContra.Visible = true;
                        lbl_VerificaCorreoContra.Text = "El correo no se encuentra registrado";
                    }
                    else
                    {
                        if (txtB_IniciaCorreoElec.Text != "" && txtB_Contraseña.Text != "")
                        {
                            if (contrahash[0].recr_contraseniahash == GetSHA256(txtB_Contraseña.Text.Trim()))
                            {
                                string CodigoAdmon = txtB_IniciaCorreoElec.Text;
                                string Password = txtB_Contraseña.Text;

                                Session["Usuario"] = txtB_IniciaCorreoElec.Text;
                                Session["Id"] = 1;

                                Session["Autenticacion"] = true;
                                Session["Nombre"] = contrahash[0].recr_name;
                                Response.Redirect("~/HomePerfil.aspx", false);
                            }
                            else
                            {
                                Session.Abandon();
                                lbl_VerificaCorreoContra.Visible = true;
                                lbl_VerificaCorreoContra.Text = "La contraseña es incorrecta";
                            }
                        }
                        else
                        {
                            BtnIniciarSesion.Enabled = true;
                            lbl_VerificaCorreoContra.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Session["Exception"] = ex.Message.ToString();
                    Response.Redirect("~/UnexpectedError.aspx");
                }

            }
            else
            {
                Session.Abandon();
                lbl_VerificaCorreoContra.Visible = false;
            }
        }

        public static string GetSHA256(string cadena)
        {
            SHA256 sha256 = SHA256Managed.Create();
            UTF8Encoding objUtf8 = new UTF8Encoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(objUtf8.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:X2}", stream[i]);
            return sb.ToString();
        }

        protected void Btn_RecuContra_Click(object sender, EventArgs e)
        {
            Pnl_RecuContra.Visible = true;
        }

        protected void Btn_ConfirmaCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                WS_LE_ConsUsuext.WS_LE_ConsUsuext wscue = new WS_LE_ConsUsuext.WS_LE_ConsUsuext();
                var contrahash = wscue.ConUsuExt(txtB_CorreoRecuContra.Text, "DIDE");

                if (contrahash[0].mensaje.Contains("200 Consulta Exitosa"))
                {
                    int[] CodigoCorreo = new int[6];
                    CodigoCorreo = generaCodigoCorreo();
                    string strgCodigoCorreo = "";

                    for (int i = 0; i < 6; i++)
                    {
                        strgCodigoCorreo += CodigoCorreo[i];
                    }
                    Globlal.ArrCodigo = strgCodigoCorreo;

                    mandaCorreo(txtB_CorreoRecuContra.Text, "Cambio de contraseña", strgCodigoCorreo);

                    Llb_txtRecuContra.Text = "Ingresa tu código";
                    Lbl_MensajeCodiCorr.Text = "Se envió un correo electrónico a " + txtB_CorreoRecuContra.Text + " con un código de verificación.";
                    Pnl_IngresaCorreo.Visible = false;
                    Pnl_CodigoRecuContra.Visible = true;
                }
                if (contrahash[0].mensaje.Contains("200 Sin Registros 0"))
                {
                    Lbl_CorreoIncorrecto.Text = "El correo electrónico no se encuentra registrado";
                    Lbl_CorreoIncorrecto.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }
        }

        protected void Btn_ConfirmCodiCorr_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtB_CodigoRecuContra.Text != Globlal.ArrCodigo)
                {
                    Lbl_CodigoRecuContra.Text = "El código que ingresaste es incorrecto, intentalo nuevamente";
                    Lbl_CodigoRecuContra.ForeColor = Color.Red;
                    TxtB_CodigoRecuContra.BorderColor = Color.Red;
                }
                else
                {
                    Llb_txtRecuContra.Text = "Ingresa tu nueva contraseña";
                    txtB_RecuCotraCorreoElec.Text = txtB_CorreoRecuContra.Text;
                    txtB_RecuCotraCorreoElec.Enabled = false;
                    Pnl_CodigoRecuContra.Visible = false;
                    Pnl_FormRecuContra.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }
        }

        protected void Btn_EnviarRecuContra_Click(object sender, EventArgs e)
        {
            try
            {
                WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno wsinsue = new WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno();
                var dats = wsinsue.InsUsuarioExt("", txtB_RecuContraNContra.Text, txtB_RecuCotraCorreoElec.Text, "", "", "", "");
                if (dats.Mensaje.Contains("correctamente"))
                {

                    Llb_txtRecuContra.Text = "";
                    lbl_CambioContra.ForeColor = Color.Green;
                    lbl_CambioContra.Text = "Tu contraseña se actualizo correctamente";
                    Pnl_FormRecuContra.Visible = false;
                    Pnl_CambioContra.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }
        }

        protected static int[] generaCodigoCorreo()
        {
            Random rnd = new Random();
            int[] codigo = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int num = rnd.Next(1, 10);
                while (Array.IndexOf(codigo, num) != -1)
                {
                    num = rnd.Next(1, 10);
                }
                codigo[i] = num;
            }

            return codigo;
        }

        protected string mandaCorreo(string to, string asunto, string codigoCorreo)
        {
            string msge = "Error al mandar este correo, verifique sus datos.",
                from = "ffaciorey@gmail.com",
                   displayName = "Legado Educativo",
                   body = $@"
                            <style>
                                body{{
                                    margin: 0%;
                                    padding: 0%;
                                }}
                            </style>
                            <table style='border-spacing: 0; width: 100%; font-family: Arial, Helvetica, sans-serif;'>
                                <tr>
                                    <td style='background-color: #333333; text-align: end; line-height: 0;'>
                                        <img src='https://www.udem.edu.mx/sites/default/files/udem-logotipo-principal.png' style='width: calc(100% / 6);' />
                                    </td>
                                </tr>
                                <tr>
                                    <td style='font-size: 2.25vw; background-color: #5c5953; color: white;padding: 2%; display: flex;justify-content: center;'>
                                        Solicitaste el cambio de tu contraseña
                                    </td>
                                </tr>
                                <tr>
                                    <td style='padding: 2% 10% 2% 10%;font-size: 1.25vw;'>
                                        <p style='font-weight: 600;'>Hola.</p><br>
                                  <p>
                                    Utiliza el siguiente código para restablecer la contraseña de tu
                                    cuenta de Legado Educativo: <a style='font-weight: 600;font-style: italic;color: dodgerblue;'>{to}</a>
                                  </p><br>
                                  <p>Tu código: <a style='font-weight: 600;'>{codigoCorreo}</a></p><br><br>
                                  <p>Atentamente, <br>
                                    Equipo de Soporte <br>            
                                    Universidad de Monterrey</p>
                                    </td>
                                </tr>
                            </table>";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(new MailAddress(to));

                mail.Subject = asunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = body;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;

                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(from, "dtlqzqcztbmihmae");

                client.EnableSsl = true;
                client.Send(mail);

                msge = "Correo enviado correctamente.";
            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Error al mandar este correo, verifique sus datos.";
            }

            return msge;
        }
        protected void Btn_RedireIniciaSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }

        protected void Btn_CloseRecuContra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }
    }
}