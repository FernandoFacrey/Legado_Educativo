using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Pnl_Header.Visible = false;
            }
        }

        protected void Btn_MenuConoce_Click(object sender, EventArgs e)
        {
            cambioClaseBtnsMenu();
            dv_Btn_MenuConoce.Attributes["class"] = "dv_btn_Menu_selected";
            dv_Container_Certificados.Visible = false;
            dv_Container_Conoce.Visible = true;
            Pnl_Header.Visible = true;
        }

        protected void Btn_MenuCertificados_Click(object sender, EventArgs e)
        {
            cambioClaseBtnsMenu();
            dv_Btn_MenuCertificados.Attributes["class"] = "dv_btn_Menu_selected";
            dv_Container_Certificados.Visible = true;
            dv_Container_Conoce.Visible = false;
            Pnl_Header.Visible = true;
        }

        protected void Btn_MenuCotizar_Click(object sender, EventArgs e)
        {
            cambioClaseBtnsMenu();
            dv_Btn_MenuCotizar.Attributes["class"] = "dv_btn_Menu_selected";
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo02/PreCotizar.aspx");

        }

        protected void Btn_MenuIniciarLE_Click(object sender, EventArgs e)
        {
            cambioClaseBtnsMenu();
            dv_Btn_MenuIniciarLE.Attributes["class"] = "dv_btn_Menu_selected";
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo02/WebLE02InicioCreaCuenta.aspx");

        }

        protected void cambioClaseBtnsMenu()
        {
            dv_Btn_MenuConoce.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuCertificados.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuCotizar.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuIniciarLE.Attributes["class"] = "dv_btn_Menu";

        }

        protected void Btn_QueEs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QueEs.aspx");
        }

        protected void Btn_Beneficios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Beneficios.aspx");
        }

        protected void Btn_Testimonios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Testimonios.aspx");
        }

        protected void Btn_VisionUDEM_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VisionUDEM.aspx");
        }

        protected void Btn_Bicultural_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasBicult.aspx");
        }

        protected void Btn_Internacional_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasInter.aspx");
        }

        protected void Btn_Multicultural_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMulti.aspx");
        }

        protected void Btn_CarrerasProf_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasCarreras.aspx");
        }

        protected void Btn_Medicina_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMedi.aspx");
        }

        protected void Btn_ArteyDiseño_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasArtDis.aspx");
        }

        protected void Btn_AquiHabi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasArquiHabi.aspx");
        }

        protected void Btn_MDO_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MasInfoMDO.aspx");
        }

        protected void Btn_MDOC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMDOC.aspx");
        }

        protected void Btn_MBA_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMBA.aspx");
        }

        protected void Btn_OtrosPosg_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasOtrosPos.aspx");
        }
    }
}