using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class Contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = false;

            if (!IsPostBack)
            {
                Session.Abandon();
                System.Web.UI.HtmlControls.HtmlGenericControl divControl = Master.FindControl("dv_Btn_MenuContactanos") as System.Web.UI.HtmlControls.HtmlGenericControl;
                if (divControl != null)
                {
                    divControl.Attributes["class"] = "dv_btn_Menu_selected";
                }
                else
                {
                    divControl.Attributes["class"] = "dv_btn_Menu";
                }
            }
        }
        protected void Btn_AvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = false;
        }
        protected void Btn_LeerAvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = true;
        }

        protected void Btn_EnviarConocenos_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate("VG_Conocenos");
                if (Page.IsValid && ChBox_AvisoDePrivacidad.Checked.Equals(true))
                {

                    WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial wsInsCliPot = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();


                    string fechaNac = txtB_FechaNacConocenos.Text;

                    string fechaNacCompleta;
                    string[] splitFechaNac = fechaNac.Split('-');
                    fechaNacCompleta = splitFechaNac[2] + "/";
                    fechaNacCompleta += splitFechaNac[1] + "/";
                    fechaNacCompleta += splitFechaNac[0];

                    if (RBL_ContactExUdemConocenos.SelectedValue.Equals("True"))
                    {
                        var result = wsInsCliPot.InsClientPotencial("Compra - Legado Educativo", txtB_PrimNomConocenos.Text, txtB_SegunNomMasConocenos.Text, txtB_AperPaterConocenos.Text, txtB_AperMaterConocenos.Text, fechaNacCompleta, RBL_ContactExUdemConocenos.Text, "", "", "", "", "", "", "", txtB_CorreoElecConocenos.Text, "", "", "", "", "", "", "", "", "", "", "", "", TxtB_MatriculaContactanos.Text);
                        if (result.CodigoMs.Contains("correctamente"))
                        {
                            string mensaje = result.CodigoMs;
                            string url = "Contactanos.aspx";
                            string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
                        }
                    }
                    else
                    {
                        var result = wsInsCliPot.InsClientPotencial("Compra - Legado Educativo", txtB_PrimNomConocenos.Text, txtB_SegunNomMasConocenos.Text, txtB_AperPaterConocenos.Text, txtB_AperMaterConocenos.Text, fechaNacCompleta, RBL_ContactExUdemConocenos.Text, "", "", "", "", "", "", "", txtB_CorreoElecConocenos.Text, "", "", "", "", "", "", "", "", "", "", "", "", "");
                        if (result.CodigoMs.Contains("correctamente"))
                        {
                            string mensaje = result.CodigoMs;
                            string url = "Contactanos.aspx";
                            string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
                        }
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
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }
        }

        protected void RBL_ContactExUdemConocenos_TextChanged(object sender, EventArgs e)
        {
            if (RBL_ContactExUdemConocenos.SelectedValue.Equals("True"))
            {
                Pnl_MatriculaContactanos.Visible = true;
            }
            else
            {
                Pnl_MatriculaContactanos.Visible = false;
            }
        }
    }
}