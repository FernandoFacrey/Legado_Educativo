using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Pnl_MenuConoce.Visible = false;
                Pnl_MenuTipoCerti.Visible = false;
                Pnl_OptPrepa.Visible = false;
                Pnl_OptPrepBicult.Visible = false;
                Pnl_OptPrepInter.Visible = false;
                Pnl_OptPrepMulti.Visible = false;
                Pnl_OptProfesional.Visible = false;
                Pnl_OptProfCarreras.Visible = false;
                Pnl_OptProfMedi.Visible = false;
                Pnl_OptProfArtDis.Visible = false;
                Pnl_OptProfArquiHabi.Visible = false;
                Pnl_OptPosgrado.Visible = false;
                Pnl_OptPosMDO.Visible = false;
                Pnl_OptPosMDOC.Visible = false;
                Pnl_OptPosMBA.Visible = false;
                Pnl_OptPosOtrosPos.Visible = false;
            }
        }

        protected void Btn_Conoce_Click(object sender, EventArgs e)
        {
            Pnl_MenuConoce.Visible = true;
            Pnl_MenuTipoCerti.Visible = false;
        }

        protected void Btn_TiposCert_Click(object sender, EventArgs e)
        {
            Pnl_MenuConoce.Visible = false;
            Pnl_MenuTipoCerti.Visible = true;
        }

        protected void btn_QueEs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QueEs.aspx");
        }

        protected void btn_Beneficios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Beneficios.aspx");
        }

        protected void btn_Testimonios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Testimonios.aspx");
        }

        protected void btn_VisionUDEM_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VisionUDEM.aspx");
        }

        protected void Btn_Cotizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PreCotizar.aspx");
        }

        protected void btnMenuPrepa_Click(object sender, EventArgs e)
        {
            Pnl_OptPrepa.Visible = true;
            Pnl_OptProfesional.Visible = false;
            Pnl_OptPosgrado.Visible = false;
            Pnl_OptPrepBicult.Visible = false;
            Pnl_OptPrepInter.Visible = false;
            Pnl_OptPrepMulti.Visible = false;
        }

        protected void btn_Bicultu_Click(object sender, EventArgs e)
        {
            Pnl_OptPrepBicult.Visible = true;
            Pnl_OptPrepInter.Visible = false;
            Pnl_OptPrepMulti.Visible = false;

        }

        protected void btn_infoBicult_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasBicult.aspx");
        }

        protected void Btn_CotiPrepaBicult_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-preparatoria");
        }

        protected void btn_Inter_Click(object sender, EventArgs e)
        {
            Pnl_OptPrepBicult.Visible = false;
            Pnl_OptPrepInter.Visible = true;
            Pnl_OptPrepMulti.Visible = false;
        }

        protected void btn_InfoInter_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasInter.aspx");
        }

        protected void btn_CotiInter_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-preparatoria");
        }

        protected void btn_Multicult_Click(object sender, EventArgs e)
        {

            Pnl_OptPrepBicult.Visible = false;
            Pnl_OptPrepInter.Visible = false;
            Pnl_OptPrepMulti.Visible = true;
        }


        protected void btn_InfoMulti_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/ConoceMasMulti.aspx");
        }

        protected void btn_CotiMulti_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-preparatoria");
        }

        protected void btnProfesional_Click(object sender, EventArgs e)
        {
            Pnl_OptPrepa.Visible = false;
            Pnl_OptProfesional.Visible = true;
            Pnl_OptPosgrado.Visible = false;
            Pnl_OptPrepBicult.Visible = false;
            Pnl_OptPrepInter.Visible = false;
            Pnl_OptPrepMulti.Visible = false;
        }
        protected void btn_CotiProf_Click(object sender, EventArgs e)
        {

            Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-profesional");
        }
        protected void btn_CotiPos_Click(object sender, EventArgs e)
        {

            Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/simulador-colegiatura-posgrado");
        }

        protected void btn_Carreras_Click(object sender, EventArgs e)
        {
            Pnl_OptProfCarreras.Visible = true;
            Pnl_OptProfMedi.Visible = false;
            Pnl_OptProfArtDis.Visible = false;
            Pnl_OptProfArquiHabi.Visible = false;
        }

        protected void btn_MasInfoCarreras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasCarreras.aspx");
        }

        protected void btn_Medicina_Click(object sender, EventArgs e)
        {
            Pnl_OptProfCarreras.Visible = false;
            Pnl_OptProfMedi.Visible = true;
            Pnl_OptProfArtDis.Visible = false;
            Pnl_OptProfArquiHabi.Visible = false;
        }

        protected void btn_MasInfoMedi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMedi.aspx");
        }

        protected void btn_MasInfoArtDis_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasArtDis.aspx");
        }

        protected void btn_ArteDiseño_Click(object sender, EventArgs e)
        {
            Pnl_OptProfCarreras.Visible = false;
            Pnl_OptProfMedi.Visible = false;
            Pnl_OptProfArtDis.Visible = true;
            Pnl_OptProfArquiHabi.Visible = false;
        }

        protected void btn_MasInfoArquiHabi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasArquiHabi.aspx");
        }

        protected void btn_ArquiHabi_Click(object sender, EventArgs e)
        {
            Pnl_OptProfCarreras.Visible = false;
            Pnl_OptProfMedi.Visible = false;
            Pnl_OptProfArtDis.Visible = false;
            Pnl_OptProfArquiHabi.Visible = true;
        }

        protected void btn_MasInfoMDO_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MasInfoMDO.aspx");
        }

        protected void btnPosgrado_Click(object sender, EventArgs e)
        {
            Pnl_OptPrepa.Visible = false;
            Pnl_OptProfesional.Visible = false;
            Pnl_OptPosgrado.Visible = true;
        }

        protected void btn_MDO_Click(object sender, EventArgs e)
        {
            Pnl_OptPosMDO.Visible = true;
            Pnl_OptPosMDOC.Visible = false;
        }

        protected void btn_MasInfoMDOC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMDOC.aspx");
        }

        protected void btn_MDOC_Click(object sender, EventArgs e)
        {
            Pnl_OptPosMDO.Visible = false;
            Pnl_OptPosMDOC.Visible = true;
            Pnl_OptPosMBA.Visible = false;
            Pnl_OptPosOtrosPos.Visible = false;
        }

        protected void btn_MBA_Click(object sender, EventArgs e)
        {
            Pnl_OptPosMDO.Visible = false;
            Pnl_OptPosMDOC.Visible = false;
            Pnl_OptPosMBA.Visible = true;
            Pnl_OptPosOtrosPos.Visible = false;
        }

        protected void btn_MasInfoMBA_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasMBA.aspx");
        }

        protected void btn_OtrosPosgrados_Click(object sender, EventArgs e)
        {
            Pnl_OptPosMDO.Visible = false;
            Pnl_OptPosMDOC.Visible = false;
            Pnl_OptPosMBA.Visible = false;
            Pnl_OptPosOtrosPos.Visible = true;
        }

        protected void btn_MasInfoOtrosPos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ConoceMasOtrosPos.aspx");
        }

        protected void Btn_IniciaLE_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }
    }
}