using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        public class Global
        {
            public static bool AvisoPrivacidad { get; set; }
            public static string[,] ArrfueLead { get; set; }
            public static string[,] ArrfueLeadSub { get; set; } 

        }
        WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead wscfl = new WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtB_fuenteLeadOtro.Visible = false;
                pnl_CorreoCrearCuenta.Visible = true;
                Clearform();
                Btn_RedireIniciaSesion.Visible = false;
                lbl_CuentaExistente.Visible = false;
            }
        }
        protected void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
            WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno insUE = new WS_LE_InsUsuarioExterno.WS_LE_InsUsuarioExterno();
           
            string txtNomCompleto;
            if (txtB_SeguNom.Text != "")
            {
                txtNomCompleto = txtB_NombrePila.Text + " " + txtB_SeguNom.Text + " " + txtB_ApePater.Text + " " + txtB_ApeMater.Text;
            }
            else
            {
                txtNomCompleto = txtB_NombrePila.Text + " " + txtB_ApePater.Text + " " + txtB_ApeMater.Text;
            }

            if (txtB_NombrePila.Text != null && txtB_ApePater.Text != null)
            {
                var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, txtB_FechaNac.Text, RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, txtB_TelParti.Text, "", txtB_CorreoElec.Text, "", "", "", Ddl_fuenteLeadOri.SelectedItem.Text, Ddl_fuenteLeadSubcat.SelectedItem.Text, "", txtB_fuenteLeadOtro.Text, "", "", "", "","");

                BtnCrearCuenta.Enabled = false;

                if (result.CodigoMs.Contains("correctamente"))
                {
                    var usuarioExt = insUE.InsUsuarioExt("", txtB_Contraseña.Text, txtB_CorreoElec.Text, txtNomCompleto, "", "DIDE");
                    Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
                }
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
                txtB_CorreoElec.Text = dats[0].emailaddress1;
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

        protected void RBtn_AceptaAvisoPrivacidad_CheckedChanged(object sender, EventArgs e)
        {
            if(RBtn_AceptaAvisoPrivacidad.Checked == true)
            {
                Global.AvisoPrivacidad = true;
            }
        }

        protected void Btn_ContiAvisoPriva_Click(object sender, EventArgs e)
        {
            if (Global.AvisoPrivacidad == false)
            {
                lbl_AceptaAvisoPrivacidad.Text = "Es necesario aceptar el aviso de privacidad para continuar";
            }
            else
            {
                pnl_AvisoPrivacidad.Visible = false;
            }
        }

        protected void TxtB_CorreoElec_TextChanged(object sender, EventArgs e)
        {
            Ddl_fuenteLeadOri.Items.Clear();
            var fueLead = wscfl.ConFuenteLead("");
            int ind = 0;
            ListItem i;
            Global.ArrfueLead = new string[fueLead.Count(), 3];
            Ddl_fuenteLeadOri.Items.Insert(0, new ListItem("---Seleccione una opcion---", "0"));

            foreach (var dato in fueLead)
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
                if(dato.udem_tipo.Contains("Subcategoría"))
                {
                    if (Ddl_fuenteLeadOri.SelectedItem.Text.Contains("Colegio"))
                    {
                        if (dato.udem_categoria.Contains("Colegio"))
                        {
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
    }
}