using System;
using System.Web.UI;
using WebLegadoEducativo02.Clases;

namespace WebLegadoEducativo02
{
    public partial class Page : System.Web.UI.MasterPage
    {
        public class Global
        {
            public static bool MuestroOptsPerfil = false;
        }

        protected System.Web.UI.HtmlControls.HtmlGenericControl gbl_dv_Btn_MenuCotizar;
        protected System.Web.UI.HtmlControls.HtmlGenericControl gbl_dv_Btn_MenuIniciarLE;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Global.MuestroOptsPerfil = false;
                Pnl_Header.Visible = false;
                InteraccionMenu.SeccionConoce = false;
                InteraccionMenu.SeccionCertificados = false;
            }

            if (Session["id"] != null)
            {
                Pnl_Menu_Options.Visible = false;
                Btn_SolicitaInformacion.Visible = false;
                Pnl_Carrito.Visible = true;
                Pnl_Btn_Perfil.Visible = true;
                if (InteraccionMenu.cantidadDeCotizaciones > 0)
                {
                    Lbl_Carrito.Text = InteraccionMenu.cantidadDeCotizaciones.ToString();
                }
                else if (InteraccionMenu.cantidadDeCotizaciones.Equals(0))
                {
                    Lbl_Carrito.Text = InteraccionMenu.cantidadDeCotizaciones.ToString();
                }
            }
            else
            {
                Pnl_Menu_Options.Visible = true;
                Pnl_Carrito.Visible = false;
                Pnl_Btn_Perfil.Visible = false;
            }
        }
        public void Logout()
        {
            string mensaje = "Se ha cerrado sesion";
            string url = "WebLE02InicioCreaCuenta.aspx";
            Session.Abandon();
            string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
            ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
        }

        protected void Btn_MenuConoce_Click(object sender, EventArgs e)
        {
            if (Pnl_Header.Style.Equals("display: block;") && InteraccionMenu.SeccionConoce.Equals(true))
            {
                CambioClaseBtnsMenu();
                Pnl_Header.Visible = false;
                InteraccionMenu.SeccionConoce = false;
                InteraccionMenu.SeccionCertificados = false;
            }
            else
            {
                InteraccionMenu.SeccionConoce = true;
                InteraccionMenu.SeccionCertificados = false;
                CambioClaseBtnsMenu();
                dv_Btn_MenuConoce.Attributes["class"] = "dv_btn_Menu_selected";
                dv_Container_Certificados.Visible = false;
                dv_Container_Conoce.Visible = true;
                Pnl_Header.Visible = true;
            }
        }

        protected void Btn_MenuCertificados_Click(object sender, EventArgs e)
        {
            if (Pnl_Header.Style.Equals("display: block;") && InteraccionMenu.SeccionCertificados.Equals(true))
            {
                CambioClaseBtnsMenu();
                Pnl_Header.Visible = false;
                InteraccionMenu.SeccionConoce = false;
                InteraccionMenu.SeccionCertificados = false;
            }
            else
            {
                InteraccionMenu.SeccionConoce = false;
                InteraccionMenu.SeccionCertificados = true;

                CambioClaseBtnsMenu();
                dv_Btn_MenuCertificados.Attributes["class"] = "dv_btn_Menu_selected";
                dv_Container_Certificados.Visible = true;
                dv_Container_Conoce.Visible = false;
                Pnl_Header.Visible = true;
            }
        }

        protected void Btn_MenuCotizar_Click(object sender, EventArgs e)
        {
            CambioClaseBtnsMenu();
            dv_Btn_MenuCotizar.Attributes["class"] = "dv_btn_Menu_selected";
            Response.Redirect("~/PreCotizar.aspx");

        }

        protected void Btn_MenuIniciarLE_Click(object sender, EventArgs e)
        {
            CambioClaseBtnsMenu();
            dv_Btn_MenuIniciarLE.Attributes["class"] = "dv_btn_Menu_selected";
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");

        }
        protected void Btn_MenuContactanos_Click(object sender, EventArgs e)
        {
            CambioClaseBtnsMenu();
            dv_Btn_MenuContactanos.Attributes["class"] = "dv_btn_Menu_selected";
            Response.Redirect("~/Contactanos.aspx");
        }

        protected void CambioClaseBtnsMenu()
        {
            dv_Btn_MenuConoce.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuCertificados.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuCotizar.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuIniciarLE.Attributes["class"] = "dv_btn_Menu";
            dv_Btn_MenuContactanos.Attributes["class"] = "dv_btn_Menu";
        }

        protected void Btn_QueEs_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/QueEs.aspx");
        }

        protected void Btn_Beneficios_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/Beneficios.aspx");
        }

        protected void Btn_Testimonios_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/Testimonios.aspx");
        }

        protected void Btn_VisionUDEM_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/VisionUDEM.aspx");
        }

        protected void Btn_Bicultural_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasBicult.aspx");
        }

        protected void Btn_Internacional_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasInter.aspx");
        }

        protected void Btn_Multicultural_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasMulti.aspx");
        }

        protected void Btn_CarrerasProf_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasCarreras.aspx");
        }

        protected void Btn_Medicina_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasMedi.aspx");
        }

        protected void Btn_ArteyDiseño_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasArtDis.aspx");
        }

        protected void Btn_AquiHabi_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasArquiHabi.aspx");
        }

        protected void Btn_MDO_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/MasInfoMDO.aspx");
        }

        protected void Btn_MDOC_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasMDOC.aspx");
        }

        protected void Btn_MBA_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasMBA.aspx");
        }

        protected void Btn_OtrosPosg_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo01/ConoceMasOtrosPos.aspx");
        }

        protected void Btn_SolicitaInformacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contactanos.aspx");
        }

        protected void Btn_Perfil_Click(object sender, EventArgs e)
        {
            string funcion = "MuestraMenu";
            string script = "<script type='text/javascript'>" + funcion + "();</script>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), funcion, script);
        }

        protected void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "Se ha cerrado sesion";
            string url = "WebLE02InicioCreaCuenta.aspx";
            Session.Abandon();
            string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
            ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
        }

        protected void Btn_CerrarSolicitud_Click(object sender, EventArgs e)
        {
            string mensaje = "Solicitud cerrada";
            string url = "HomePerfil.aspx";
            string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
            ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
        }
    }
}