using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class ConoceMasArquiHabi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConoceMasArquiHabi_Click(object sender, EventArgs e)
        {
            string script = "window.open('https://crgs.udem.edu.mx/arte-arquitectura-y-diseno', '_blank');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenNewTab", script, true);
            //Response.Redirect("https://crgs.udem.edu.mx/arte-arquitectura-y-diseno");
        }
    }
}