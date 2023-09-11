using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl_AvisoPrivacidad.Visible = false;
                PnlMasInfo.Visible = false;
                Pnl_Correo.Visible = true;
                Pnl_InfoExta.Visible = false;
                Pnl_FormInfoExtra.Visible = false;
                Pnl_NivelInteres.Visible = true;
                Pnl_ImgBach.Visible = true;
                Pnl_ImgProf.Visible = false;
                Pnl_ImgPos.Visible = false;
                BtnCotizador.Visible = true;
                Lbl_Nivel.Text = "Bachillerato";
            }
        }

        protected void BtnCotizador_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = true;
            PnlMasInfo.Visible = true;
        }
        protected void Btn_Bachillerato_Click(object sender, EventArgs e)
        {
            Pnl_ImgBach.Visible = true;
            Pnl_ImgProf.Visible = false;
            Pnl_ImgPos.Visible = false;
            Lbl_Nivel.Text = "Bachillerato";
        }

        protected void Btn_Profesional_Click(object sender, EventArgs e)
        {
            Pnl_ImgBach.Visible = false;
            Pnl_ImgProf.Visible = true;
            Pnl_ImgPos.Visible = false;
            Lbl_Nivel.Text = "Profesional";
        }

        protected void Btn_Posgrado_Click(object sender, EventArgs e)
        {
            Pnl_ImgBach.Visible = false;
            Pnl_ImgProf.Visible = false;
            Pnl_ImgPos.Visible = true;
            Lbl_Nivel.Text = "Posgrado";
        }


        protected void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (txtB_CorreoMasInfo.Text != "")
            {
                WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
                var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_PrimNomMasInfo.Text, txtB_SegunNomMasInfo.Text, txtB_AperPaterMasInfo.Text, txtB_AperMaterMasInfo.Text, "", "", "", "", "", "", "", "", "", txtB_CorreoMasInfo.Text, "", "", "", "Otro", "", "", "Landing", "", "", "", "", "");
                BtnEnviarCorreo.Enabled = false;
                Pnl_Correo.Visible = false;
                Pnl_InfoExta.Visible = true;
            }

        }
        protected void Btn_InfoExtraSI_Click(object sender, EventArgs e)
        {
            Pnl_InfoExta.Visible = false;
            Pnl_FormInfoExtra.Visible = true;

            WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
            var dats = wsconscp.ConsClientePotencialcorStatus(txtB_CorreoMasInfo.Text, "", "");
            if (dats[0].mensaje.Contains("Sin Registros"))
            {
                txtB_NombrePila.Text = txtB_PrimNomMasInfo.Text;
                txtB_SeguNom.Text = txtB_SegunNomMasInfo.Text;
                txtB_ApePater.Text = txtB_AperPaterMasInfo.Text;
                txtB_ApeMater.Text = txtB_AperMaterMasInfo.Text;
                txtB_CorreoElec.Text = txtB_CorreoMasInfo.Text;
            }
            else
            {
                txtB_NombrePila.Text = dats[0].firstname;
                txtB_SeguNom.Text = dats[0].middlename;
                txtB_ApePater.Text = dats[0].udem_apellidopaterno;
                txtB_ApeMater.Text = dats[0].udem_apellidomaterno;
                txtB_TelMovil.Text = dats[0].mobilephone;
                txtB_CorreoElec.Text = dats[0].emailaddress1;
                RBL_ContactExUdem.SelectedValue = dats[0].udem_contactoprincipal_diceserexalumno;
            }
            txtB_CorreoElec.Enabled = false;
        }

        protected void Btn_InfoExtraNO_Click(object sender, EventArgs e)
        {
            Pnl_InfoExta.Visible = false;
            if (Lbl_Nivel.Text == "Bachillerato")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
            }
            else if (Lbl_Nivel.Text == "Profesional")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
            }
            else if (Lbl_Nivel.Text == "Posgrado")
            {
                Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
            }
        }

        protected void BtnEnviarForm_Click(object sender, EventArgs e)
        {
            BtnEnviarForm.Enabled = false;
            WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial btnws = new WS_LE_InsertaClientePotencial.WS_LE_InsertaClientePotencial();
            if (txtB_NombrePila.Text != null && txtB_ApePater.Text != null)
            {
                var result = btnws.InsClientPotencial("Compra - Legado Educativo", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text, "", RBL_ContactExUdem.SelectedItem.Text, "", "", "", "", txtB_TelMovil.Text, "", "", txtB_CorreoElec.Text, "", "", "", "", "", "", "", "", "", "", "", "");
                if (Lbl_Nivel.Text == "Bachillerato")
                {
                    Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
                }
                else if (Lbl_Nivel.Text == "Profesional")
                {
                    Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
                }
                else if (Lbl_Nivel.Text == "Posgrado")
                {
                    Response.Redirect("https://udemdev.prod.acquia-sites.com/es/admisiones-y-becas/simulador-colegiatura");
                }
            }
        }


        protected void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PreCotizar.aspx");
        }


        protected void RBtn_AceptaAvisoPrivacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_AceptaAvisoPrivacidad.Checked == true)
            {
                Global.avisoPrivacidad = true;
            }
        }

        protected void Btn_ContiAvisoPriva_Click(object sender, EventArgs e)
        {
            if (Global.avisoPrivacidad == false)
            {
                lbl_AceptaAvisoPrivacidad.Text = "Es necesario aceptar el aviso de privacidad para continuar";
            }
            else
            {
                pnl_AvisoPrivacidad.Visible = false;
            }
        }
    }
}