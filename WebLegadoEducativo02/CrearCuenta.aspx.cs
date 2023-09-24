using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Web;

namespace WebLegadoEducativo02
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        public class Global
        {
            public static string GuidLead { get; set; }
            public static bool AvisoDePrivacidad { get; set; }
            public static string[,] ArrfueLead { get; set; }
            public static string[,] ArrfueLeadSub { get; set; }

        }
        WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead wscfl = new WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead();
        WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial WsInsCliPo = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
        WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno WsInsUsExt = new WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //Deshabilita la opcion de regresar y adelantar la pagina
                Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
                Response.Cache.SetAllowResponseInBrowserHistory(false);
                Response.Cache.SetNoStore();

                //Agrega animaciones al titulo de los campos "nivel de procedencia" 
                Ddl_fuenteLeadOri.Attributes.Add("onchange", "showLoadingFuenteLead()");


                if (!IsPostBack)
                {
                    //var captcha = grecaptcha.getResponse();

                    pnl_AvisoPrivacidad.Visible = false;
                    Page.MaintainScrollPositionOnPostBack = true;
                    CargaFuenteLead();
                    txtB_fuenteLeadOtro.Visible = false;
                    pnl_CorreoCrearCuenta.Visible = true;
                    Clearform();
                    Btn_RedireIniciaSesion.Visible = false;
                    lbl_CuentaExistente.Visible = false;
                    pnl_CreacionCuenta.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Session.Abandon();
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx", true);
            }
        }
        public class ReCaptchaResponse
        {
            public bool Success { get; set; }
            public List<string> ErrorCodes { get; set; }
        }
        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = ConfigurationManager.AppSettings["SecretKey"];
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JObject jResponse = JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("success");
                    result = (isSuccess) ? true : false;
                }
            }
            return result;
        }

        protected void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate("VG01");

                if (Page.IsValid && ChBox_AvisoDePrivacidad.Checked.Equals(true))
                {
                    if (IsReCaptchValid())
                    {
                        string script = "CaptchaValida();";
                        ClientScript.RegisterStartupScript(this.GetType(), "CaptchaGood", script, true);

                        string txtNomCompleto;
                        if (txtB_SeguNom.Text != "")
                        {
                            txtNomCompleto = txtB_NombrePila.Text + " " + txtB_SeguNom.Text + " " + txtB_ApePater.Text + " " + txtB_ApeMater.Text;
                        }
                        else
                        {
                            txtNomCompleto = txtB_NombrePila.Text + " " + txtB_ApePater.Text + " " + txtB_ApeMater.Text;
                        }


                        string fechaCrea = txtB_FechaNac.Text;

                        string _result, fechaCreaCompleta;
                        string[] splitFechaCrea = fechaCrea.Split('-');
                        fechaCreaCompleta = splitFechaCrea[2] + "/";
                        fechaCreaCompleta += splitFechaCrea[1] + "/";
                        fechaCreaCompleta += splitFechaCrea[0];



                        if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Otro"))
                        {
                            var result = WsInsCliPo.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, fechaCreaCompleta, RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, txtB_TelParti.Text, "", txtB_CorreoElec.Text, "", "", "", Ddl_fuenteLeadOri.SelectedItem.Text, "", "", txtB_fuenteLeadOtro.Text, "", "", "", "", "", "", "Legado Educativo");
                            _result = result.CodigoMs.ToString();

                            Global.GuidLead = result.Guid;
                        }
                        if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Empresa") || Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Colegio"))
                        {
                            var result = WsInsCliPo.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, fechaCreaCompleta, RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, txtB_TelParti.Text, "", txtB_CorreoElec.Text, "", "", "", Ddl_fuenteLeadOri.SelectedItem.Text, Ddl_fuenteLeadSubcat.SelectedItem.Text, "No se encuentra en la lista", txtB_fuenteLeadOtro.Text, "", "", "", "", "", "", "Legado Educativo");
                            _result = result.CodigoMs.ToString();
                            Global.GuidLead = result.Guid;
                        }
                        else
                        {
                            var result = WsInsCliPo.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, fechaCreaCompleta, RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, txtB_TelParti.Text, "", txtB_CorreoElec.Text, "", "", "", Ddl_fuenteLeadOri.SelectedItem.Text, Ddl_fuenteLeadSubcat.SelectedItem.Text, "", txtB_fuenteLeadOtro.Text, "", "", "", "", "", "", "Legado Educativo");
                            _result = result.CodigoMs.ToString();
                            Global.GuidLead = result.Guid;
                        }
                        BtnCrearCuenta.Enabled = false;
                        string[] splitGuidLead = Global.GuidLead.Split(' ', '|');

                        if (_result.Contains("correctamente"))
                        {
                            CrmServiceClient service = null;
                            service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                            if (service != null)
                            {
                                if (service.IsReady)
                                {

                                    Entity lead = new Entity("lead");
                                    Guid guidLead = new Guid(splitGuidLead[0]);
                                    ColumnSet attributes = new ColumnSet("statuscode");
                                    lead = service.Retrieve(lead.LogicalName, guidLead, attributes);


                                    int statusLead = 0;
                                    foreach (var datos in lead.Attributes)
                                    {
                                        if (datos.Key.Contains("statuscode"))
                                        {
                                            int optdatos = ((OptionSetValue)datos.Value).Value;
                                            statusLead = optdatos;
                                        }
                                    }

                                    if (statusLead == 3)
                                    {
                                        var usuarioExt = WsInsUsExt.InsUsuarioExt("", Global.GuidLead, txtB_Contraseña.Text, txtB_CorreoElec.Text, txtNomCompleto, "", "DIDE");

                                        if (usuarioExt.Mensaje.Contains("correctamente"))
                                        {
                                            Session.Abandon();
                                            pnl_CreacionCuenta.Visible = true;
                                            lbl_CreacioCuenta.Text = "¡Tu cuenta se creo correctamente! ✔";
                                            lbl_CreacioCuenta.ForeColor = Color.Green;
                                        }
                                        else
                                        {
                                            Session.Abandon();
                                            pnl_CreacionCuenta.Visible = true;
                                            lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Usuario Externo). ❌";
                                            lbl_CreacioCuenta.ForeColor = Color.Red;
                                            Btn_RedireIniciaSesion2.Text = "Inicio";
                                        }
                                    }
                                    else
                                    {
                                        var dats = WsInsCliPo.CalificaLead(splitGuidLead[0].ToString());

                                        {
                                            if (dats.CodigoMs.Contains("correctamente"))
                                            {
                                                var usuarioExt = WsInsUsExt.InsUsuarioExt(dats.Guid, "", txtB_Contraseña.Text, txtB_CorreoElec.Text, txtNomCompleto, "", "DIDE");

                                                if (usuarioExt.Mensaje.Contains("correctamente"))
                                                {
                                                    Session.Abandon();
                                                    pnl_CreacionCuenta.Visible = true;
                                                    lbl_CreacioCuenta.Text = "¡Tu cuenta se creo correctamente! ✔";
                                                    lbl_CreacioCuenta.ForeColor = Color.Green;
                                                }
                                                else
                                                {
                                                    Session.Abandon();
                                                    pnl_CreacionCuenta.Visible = true;
                                                    lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Usuario Externo). ❌";
                                                    lbl_CreacioCuenta.ForeColor = Color.Red;
                                                    Btn_RedireIniciaSesion2.Text = "Inicio";
                                                }
                                            }
                                            else
                                            {
                                                Session.Abandon();
                                                pnl_CreacionCuenta.Visible = true;
                                                lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Califica Lead). ❌";
                                                lbl_CreacioCuenta.ForeColor = Color.Red;
                                                Btn_RedireIniciaSesion2.Text = "Inicio";
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    Session.Abandon();
                                    pnl_CreacionCuenta.Visible = true;
                                    lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Service Ready). ❌";
                                    lbl_CreacioCuenta.ForeColor = Color.Red;
                                    Btn_RedireIniciaSesion2.Text = "Inicio";
                                }
                            }
                            else
                            {
                                Session.Abandon();
                                pnl_CreacionCuenta.Visible = true;
                                lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Service). ❌";
                                lbl_CreacioCuenta.ForeColor = Color.Red;
                                Btn_RedireIniciaSesion2.Text = "Inicio";
                            }
                        }
                        else
                        {
                            Session.Abandon();
                            pnl_CreacionCuenta.Visible = true;
                            lbl_CreacioCuenta.Text = "Hubo un error al crear tu cuenta, presiona el siguiente boton y repite el proceso (Lead). ❌ ";
                            lbl_CreacioCuenta.ForeColor = Color.Red;
                            Btn_RedireIniciaSesion2.Text = "Inicio";
                        }

                    }
                    else
                    {
                        string script = "CaptchaInvalida();";
                        ClientScript.RegisterStartupScript(this.GetType(), "CaptchaBad", script, true);
                    }
                }
                else
                {
                    if (ChBox_AvisoDePrivacidad.Checked.Equals(true))
                    {
                        Lbl_AvisoDePrivacidad.Text = string.Empty;
                    }
                    else
                    {
                        Lbl_AvisoDePrivacidad.Text = "Es necesario aceptar el aviso de privacidad para continuar";
                    }
                }


            }
            catch (Exception ex)
            {
                Session.Abandon();
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx", true);
            }

        }
        protected void Clearform()
        {
            txtB_NombrePila.Text = "";
            txtB_SeguNom.Text = "";
            txtB_ApePater.Text = "";
            txtB_ApeMater.Text = "";
            txtB_TelMovil.Text = "";
            txtB_CorreoElec.Text = "";
        }

        protected void Btn_ConfirmaCorreoCreaCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate("VG02");
                if (Page.IsValid)
                {
                    WS_LE_ConsUsuext.WS_LE_ConsUsuext wscusext = new WS_LE_ConsUsuext.WS_LE_ConsUsuext();
                    var usuarioExterno = wscusext.ConUsuExt(txtB_ConfirmaCorreoElecCrea.Text, "DIDE");
                    if (usuarioExterno[0].mensaje.Contains("Sin Registros"))
                    {
                        WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
                        var dats = wsconscp.ConsClientePotencialcor(txtB_ConfirmaCorreoElecCrea.Text, "");

                        txtB_NombrePila.Text = dats[0].firstname;
                        txtB_SeguNom.Text = dats[0].middlename;
                        txtB_ApePater.Text = dats[0].udem_apellidopaterno;
                        txtB_ApeMater.Text = dats[0].udem_apellidomaterno;
                        txtB_TelMovil.Text = dats[0].mobilephone;
                        txtB_CorreoElec.Text = txtB_ConfirmaCorreoElecCrea.Text;
                        txtB_CorreoElec.Enabled = false;
                        RBL_ContactExUdem.SelectedValue = dats[0].udem_contactoprincipal_diceserexalumno;

                        pnl_CorreoCrearCuenta.Visible = false;
                    }
                    else
                    {
                        txtB_ConfirmaCorreoElecCrea.Enabled = false;
                        lbl_CuentaExistente.Visible = true;
                        Btn_RedireIniciaSesion.Visible = true;
                        Btn_ConfirmaCorreoCreaCuenta.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Abandon();
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx", true);
            }
        }

        protected void CargaFuenteLead()
        {
            Ddl_fuenteLeadOri.Items.Clear();
            var fueLead = wscfl.ConFuenteLead("");
            int ind = 0;
            ListItem i;
            Global.ArrfueLead = new string[fueLead.Count(), 3];
            Ddl_fuenteLeadOri.Items.Insert(0, new ListItem("---Seleccione una opcion---", "0"));

            foreach (var dato in fueLead)
            {
                if (dato.udem_tipo != null)
                {
                    if (dato.udem_tipo.Contains("Categoría"))
                    {
                        i = new ListItem(dato.udem_name, ind + 1.ToString());
                        Ddl_fuenteLeadOri.Items.Add(i);
                        Global.ArrfueLead[ind, 0] = dato.udem_name;
                        Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                        Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                        ind = ind + 1;
                    }
                }
            }
        }
        protected void Ddl_fuenteLeadOri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ddl_fuenteLeadSubcat.Items.Clear();
            var fueLeadSub = wscfl.ConFuenteLead("");
            int ind = 0;
            ListItem i;
            Global.ArrfueLeadSub = new string[fueLeadSub.Count(), 3];
            Ddl_fuenteLeadSubcat.Items.Insert(0, new ListItem("---Seleccione una opcion---", "0"));

            foreach (var dato in fueLeadSub)
            {
                if (dato.udem_tipo.Contains("Subcategoría"))
                {
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Colegio"))
                    {
                        if (dato.udem_categoria.Contains("Colegio"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("DREXA"))
                    {
                        if (dato.udem_categoria.Contains("DREXA"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Empresa"))
                    {
                        if (dato.udem_categoria.Contains("Empresa"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Proceso de Admisión"))
                    {
                        if (dato.udem_categoria.Contains("Proceso de Admisión"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Recomendación"))
                    {
                        if (dato.udem_categoria.Contains("Recomendación"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Visita al Campus UDEM"))
                    {
                        if (dato.udem_categoria.Contains("Visita al Campus UDEM"))
                        {
                            Ddl_fuenteLeadSubcat.Visible = true;
                            txtB_fuenteLeadOtro.Visible = false;
                            i = new ListItem(dato.udem_name, ind + 1.ToString());
                            Ddl_fuenteLeadSubcat.Items.Add(i);
                            Global.ArrfueLead[ind, 0] = dato.udem_name;
                            Global.ArrfueLead[ind, 1] = dato.udem_tipo;
                            Global.ArrfueLead[ind, 2] = dato.udem_categoria;
                            ind = ind + 1;
                        }
                    }
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Otro"))
                    {
                        Ddl_fuenteLeadSubcat.Visible = false;
                        txtB_fuenteLeadOtro.Visible = true;
                    }
                }
            }
        }
        protected void Btn_RedireIniciaSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }

        protected void Btn_LeerAvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = true;
        }

        protected void Btn_AvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = false;
        }

        protected void RBL_ContactExUdem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RBL_ContactExUdem.SelectedItem.Text.Equals("Sí"))
            {
                Pnl_Matricula.Visible = true;
            }
            else
            {
                Pnl_Matricula.Visible = false;
            }
        }
    }
}