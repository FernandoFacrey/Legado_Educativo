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
            btn_IniciarLegado.Style["display"] = "block";
        }

        protected void Btn_BeneficiosHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Beneficios.aspx");
        }

        protected void Btn_QueEsLEHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueEs.aspx");
        }

        protected void Btn_IniciarLegado_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://eventosudemtst.udem.edu.mx/UDEMDESA/LegadoEducativo/WebLegadoEducativo02/WebLE02InicioCreaCuenta.aspx");
        }
    }
}
