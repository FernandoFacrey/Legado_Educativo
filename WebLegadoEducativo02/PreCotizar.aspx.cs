using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class PreCotizar : System.Web.UI.Page
    {
        public class Global
        {
            public static bool avisoPrivacidad { get; set; }
        }
        WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead wscfl = new WS_LE_ConsFuenteLead.WS_LE_ConsFuenteLead();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            try
            {
                if (!IsPostBack)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl divControl = Master.FindControl("dv_Btn_MenuCotizar") as System.Web.UI.HtmlControls.HtmlGenericControl;
                    if (divControl != null)
                    {
                        divControl.Attributes["class"] = "dv_btn_Menu_selected";
                    }
                    else
                    {
                        divControl.Attributes["class"] = "dv_btn_Menu";
                    }

                    pnl_AvisoPrivacidad.Visible = false;
                    PnlMasInfo.Visible = false;
                    Pnl_Correo.Visible = true;
                    Lbl_Nivel.Text = "Bachillerato";
                }
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Response.Redirect("~/UnexpectedError.aspx");
            }
        }

        protected void Btn_Bachillerato_Click(object sender, EventArgs e)
        {
            Lbl_Nivel.Text = "Bachillerato";
            PnlMasInfo.Visible = true;
        }

        protected void Btn_Profesional_Click(object sender, EventArgs e)
        {
            Lbl_Nivel.Text = "Profesional";
            PnlMasInfo.Visible = true;
        }

        protected void Btn_Posgrado_Click(object sender, EventArgs e)
        {
            Lbl_Nivel.Text = "Posgrado";
            PnlMasInfo.Visible = true;
        }

        protected void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Validate("VG01");
                if (Page.IsValid && ChBox_AvisoDePrivacidad.Checked.Equals(true))
                {
                    WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
                    var dats = wsconscp.ConsClientePotencialcor(txtB_CorreoMasInfo.Text, "");
                    if (dats[0].mensaje.Contains("Sin Registros"))
                    {
                        WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
                        var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_PrimNomMasInfo.Text, txtB_SegunNomMasInfo.Text, txtB_AperPaterMasInfo.Text, txtB_AperMaterMasInfo.Text, "", "", "", "", "", "", "", "", "", txtB_CorreoMasInfo.Text, "", "", "", "Otro", "", "", "Landing", "", "", "", "", "", "", "Legado Educativo");
                        if (result.Mensaje.Contains("Correctamente"))
                        {
                            BtnEnviarCorreo.Enabled = false;
                            Pnl_Correo.Visible = false;
                            RedireccionaCotizador();
                        }
                    }
                    else
                    {
                        CrmServiceClient service = null;
                        service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                        if (service != null)
                        {
                            if (service.IsReady)
                            {
                                Entity lead = new Entity("lead");
                                Guid guidLead = new Guid(dats[0].leadid);
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
                                    BtnEnviarCorreo.Enabled = false;
                                    Pnl_Correo.Visible = false;
                                    RedireccionaCotizador();
                                }
                                else
                                {
                                    WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
                                    var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_PrimNomMasInfo.Text, txtB_SegunNomMasInfo.Text, txtB_AperPaterMasInfo.Text, txtB_AperMaterMasInfo.Text, "", "", "", "", "", "", "", "", "", txtB_CorreoMasInfo.Text, "", "", "", "Otro", "", "", "Landing", "", "", "", "", "", "", "Legado Educativo");
                                    BtnEnviarCorreo.Enabled = false;
                                    Pnl_Correo.Visible = false;
                                    RedireccionaCotizador();
                                }
                            }
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


        protected void RedireccionaCotizador()
        {
            if (Lbl_Nivel.Text == "Bachillerato")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura", false);
            }
            else if (Lbl_Nivel.Text == "Profesional")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura", false);
            }
            else if (Lbl_Nivel.Text == "Posgrado")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura", false);
            }
        }

        //protected void BtnEnviarForm_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        BtnEnviarForm.Enabled = false;
        //        WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
        //        if (txtB_NombrePila.Text != null && txtB_ApePater.Text != null)
        //        {
        //            var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, "", RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, "", "", txtB_CorreoElec.Text, "", "", "", "", "", "", "", "", "", "", "", "");
        //            if (Lbl_Nivel.Text == "Bachillerato")
        //            {
        //                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
        //            }
        //            else if (Lbl_Nivel.Text == "Profesional")
        //            {
        //                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
        //            }
        //            else if (Lbl_Nivel.Text == "Posgrado")
        //            {
        //                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Session["Exception"] = ex.Message.ToString();
        //        Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
        //    }
        //}

        protected void Btn_close_PreCotizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PreCotizar.aspx");
        }

        protected void Btn_LeerAvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = true;
        }

        protected void Btn_AvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = false;
        }

        protected void RBL_ContactExUdem_TextChanged(object sender, EventArgs e)
        {
            if (RBL_ContactExUdem.SelectedValue.Equals("True"))
            {
                td_Matricula_MasInfo.Visible = true;
            }
            else
            {
                td_Matricula_MasInfo.Visible = false;
            }
        }
    }
}