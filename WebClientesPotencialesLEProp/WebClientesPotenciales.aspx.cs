using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class WebClientesPotenciales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /*if (!IsPostBack)
               {
                   Pnl_ImgBach.Visible = false;
                   Pnl_ImgProf.Visible = false;
                   Pnl_ImgPos.Visible = false;
                   Pnl_masInfo.Visible = false;
                   PnlBachillerato.Visible = false;
                   PnlProfesional.Visible = false;
                   PnlPosgrado.Visible = false;
                   Lbl_Nivel.Text = "";
                   clearForm();
               }
           }
           protected void BtnEnviar_Click(object sender, EventArgs e)
           {
               WSInsertaClientePotencial.WSInsertaClientePotencial btnws = new WSInsertaClientePotencial.WSInsertaClientePotencial();
               if (txtB_NombrePila.Text != null && txtB_ApePater.Text != null)
               {
                   BtnEnviar.Enabled = false;
                   var result = btnws.InsClientPotencial("", txtB_NombrePila.Text, txtB_SeguNom.Text, txtB_ApePater.Text, txtB_ApeMater.Text,"", RBL_ContactExa.SelectedItem.Text, "", txtB_TelMovil.Text, "", "", txtB_CorreoElec.Text, "", "", "", "", "", "", "", "", "", "", "", "");
                   Response.Redirect("~/WebClientesPotenciales.aspx");
               }
           }
           protected void clearForm()
           {
               txtB_NombrePila.Text = string.Empty;
               txtB_SeguNom.Text = string.Empty;
               txtB_ApePater.Text = string.Empty;
               txtB_ApeMater.Text = string.Empty;
               txtB_TelMovil.Text = string.Empty;
               txtB_CorreoElec.Text = string.Empty;
           }
           protected void BtnCotizador_Click(object sender, EventArgs e)
           {
               if(Lbl_Nivel.Text == "Bachillerato")
               {
                   Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-preparatoria");
               }
               else if (Lbl_Nivel.Text == "Profesional")
               {
                   Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-profesional");
               }
               else if (Lbl_Nivel.Text == "Posgrado")
               {
                   Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-posgrado");
               }
           }
           protected void Bnt_Home_Click(object sender, EventArgs e)
           {
               Response.Redirect("~/WebClientesPotenciales.aspx");
           }
           protected void Bnt_MasInfo_Click(object sender, EventArgs e)
           {
               Pnl_Que_es_LE.Visible = false;
           }
           protected void Btn_CreateAcc_Click(object sender, EventArgs e)
           {
               Response.Redirect("https://solicitudadmisionudem.udem.edu.mx/SAL/Sesion/Inicio");
           }
           protected void BtnMasInfo_Click(object sender, EventArgs e)
           {
               Pnl_masInfo.Visible = true;
               Pnl_Que_es_LE.Visible = false;
           }
           protected void Btn_Bachillerato_Click(object sender, EventArgs e)
           {
               Pnl_ImgBach.Visible = true;
               Pnl_ImgProf.Visible = false;
               Pnl_ImgPos.Visible = false;
               Lbl_Nivel.Text = "Bachillerato";
               PnlBachillerato.Visible = true;
               PnlProfesional.Visible = false;
               PnlPosgrado.Visible = false;
           }
           protected void Btn_Profesional_Click(object sender, EventArgs e)
           {
               Pnl_ImgBach.Visible = false;
               Pnl_ImgProf.Visible = true;
               Pnl_ImgPos.Visible = false;
               Lbl_Nivel.Text = "Profesional";
               PnlBachillerato.Visible = false;
               PnlProfesional.Visible = true;
               PnlPosgrado.Visible = false;
           }
           protected void Btn_Posgrado_Click(object sender, EventArgs e)
           {
               Pnl_ImgBach.Visible = false;
               Pnl_ImgProf.Visible = false;
               Pnl_ImgPos.Visible = true;
               Lbl_Nivel.Text = "Posgrado";
               PnlBachillerato.Visible = false;
               PnlProfesional.Visible = false;
               PnlPosgrado.Visible = true;
           }*/
        }
    }
}
