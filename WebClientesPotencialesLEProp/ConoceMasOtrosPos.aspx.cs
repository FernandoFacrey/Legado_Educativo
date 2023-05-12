using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class ConoceMasOtrosPos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConoceMasPosgrado_Click(object sender, EventArgs e)
        {
            string script = "window.open('https://www.udem.edu.mx/es/admisiones-y-becas/posgrados', '_blank');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenNewTab", script, true);
            //Response.Redirect("https://www.udem.edu.mx/es/admisiones-y-becas/posgrados");
        }
    }
}