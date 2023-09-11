using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class WebLE02InicioCreaCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Pnl_RecuContra.Visible = false;
                Pnl_IngresaCorreo.Visible = true;
                Pnl_FormRecuContra.Visible = false;
                PnlCargando.Visible = false;
                Lbl_CorreoCorrecto.Visible = false;
            }
        }

        protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            WS_LE_ConsUsuext.WS_LE_ConsUsuext wscue = new WS_LE_ConsUsuext.WS_LE_ConsUsuext();
            var contrahash = wscue.ConUsuExt(txtB_IniciaCorreoElec.Text, "DIDE");
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
                    Response.Redirect("~/HomePerfil.aspx");
                }
                else
                {
                    Session["Id"] = 0;
                    lbl_VerificaCorreoContra.Visible = true;
                }
            }
            else
            {
                BtnIniciarSesion.Enabled = true;
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
            WS_LE_ConsUsuext.WS_LE_ConsUsuext wscue = new WS_LE_ConsUsuext.WS_LE_ConsUsuext();
            var contrahash = wscue.ConUsuExt(txtB_CorreoRecuContra.Text, "DIDE");

            if (contrahash[0].mensaje.Contains("200 Consulta Exitosa"))
            {
                Pnl_IngresaCorreo.Visible = false;
                Pnl_FormRecuContra.Visible = true;
                txtB_RecuCotraCorreoElec.Enabled = false;
                txtB_RecuCotraCorreoElec.Text = txtB_CorreoRecuContra.Text;
            }
            if (contrahash[0].mensaje.Contains("200 Sin Registros 0"))
            {
                Lbl_CorreoIncorrecto.Text = "Verifica tu correo";
                Lbl_CorreoIncorrecto.ForeColor = Color.Red;
            }
        }

        protected void Btn_EnviarRecuContra_Click(object sender, EventArgs e)
        {
            WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno wsinsue = new WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno();
            var dats = wsinsue.InsUsuarioExt("", txtB_RecuContraNContra.Text, txtB_RecuCotraCorreoElec.Text, "", "", "");

            Lbl_CorreoCorrecto.Visible = true;
            Lbl_CorreoCorrecto.Text = dats.Mensaje;
            if (dats.Mensaje.Contains("200") || dats.Mensaje.Contains("201"))
            {
                Lbl_CorreoCorrecto.ForeColor = Color.Green;
                Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
            }
        }

        protected void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }

        protected void BtnIniciarSesion_Click1(object sender, EventArgs e)
        {

        }
    }
}