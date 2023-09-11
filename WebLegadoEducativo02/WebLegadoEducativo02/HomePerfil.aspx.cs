using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{

    public partial class HomePerfil : System.Web.UI.Page
    {
        public class VarGlobal
        {
            public static string guidClientePortencial = string.Empty;
            public static string NombreClientePotencial = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
                var dats = wsconscp.ConsClientePotencialcorStatus(Session["Usuario"].ToString(), "", "");
                VarGlobal.guidClientePortencial = dats[0].leadid;
                VarGlobal.NombreClientePotencial = dats[0].firstname +" "+  dats[0].middlename + " " + dats[0].udem_apellidopaterno + " " + dats[0].udem_apellidomaterno;
            }

            Pnl_OptSesion.Visible = false;
            Pnl_infoCuenta.Visible = false;
            Pnl_solicitudes.Visible = false;

            if (Session["Usuario"] != null)
            {
                Lbl_mensaje.Text = "Bienvenido " + VarGlobal.NombreClientePotencial;
            }
            else
            {
                Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
            }
        }

        protected void ImgBtn_MenuPerfil_Click(object sender, ImageClickEventArgs e)
        {
            Pnl_OptSesion.Visible = true;
        }
        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Logout();
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }
        public void Logout()
        {
            Session.Abandon();
        }

        protected void Btn_Perfil_Click(object sender, EventArgs e)
        {
            Habilita_Btns();
            Btn_Perfil.Enabled = false;
            Pnl_infoCuenta.Visible = true;
            Pnl_solicitudes.Visible = false;


            WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
            var dats = wsconscp.ConsClientePotencialcorStatus(Session["Usuario"].ToString(), "", "");
            txtB_nombre.Text = dats[0].firstname;
            txtB_SegunNombre.Text = dats[0].middlename;
            txtB_apePater.Text = dats[0].udem_apellidopaterno;
            txtB_apeMater.Text = dats[0].udem_apellidomaterno;
            txtB_fechaNac.Text = Convert.ToDateTime(dats[0].udem_fechadenacimiento).ToString("dd/MM/yyyy");
            txtB_correoElec.Text = dats[0].emailaddress1;
            txtB_TelefonoMovil.Text = dats[0].mobilephone;
            txtB_TelefonoParti.Text = dats[0].telephone2;
            if (dats[0].udem_contactoprincipal_diceserexalumno == "True")
            {
                txtB_exUdem.Text = "Si";
            }
            else
            {
                txtB_exUdem.Text = "No";
            }
        }

        protected void Btn_Solicitudes_Click(object sender, EventArgs e)
        {
            Habilita_Btns();
            Btn_Solicitudes.Enabled = false;
            Pnl_infoCuenta.Visible = false;
            Pnl_solicitudes.Visible = true;

        }

        protected void Habilita_Btns()
        {
            Btn_Perfil.Enabled = true;
            Btn_Solicitudes.Enabled = true;
            Btn_Certificados.Enabled = true;
            Btn_Compras.Enabled = true;
            Btn_Beneficiarios.Enabled = true;

        }

        protected void Btn_CrearSoliCompra_Click(object sender, EventArgs e)
        {
            CrmServiceClient service = null;
            service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            if (service != null)
            {
                if (service.IsReady)
                {

                    Entity lead = new Entity("lead");
                    Guid guidLead = new Guid(VarGlobal.guidClientePortencial);
                    ColumnSet attributes = new ColumnSet("statuscode");
                    lead = service.Retrieve(lead.LogicalName, guidLead, attributes);

                    foreach (var datos in lead.Attributes)
                    {
                        int optdatos = ((OptionSetValue)datos.Value).Value;
                        if (optdatos == 3)
                        {
                            Response.Redirect("~/WebSolicitudCompraLE.aspx");
                        }
                        else
                        {
                            WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial wscl = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
                            var dats = wscl.CalificaLead(VarGlobal.guidClientePortencial);
                            Response.Redirect("~/WebSolicitudCompraLE.aspx");
                        }
                    }
                }
            }
        }
    }
}