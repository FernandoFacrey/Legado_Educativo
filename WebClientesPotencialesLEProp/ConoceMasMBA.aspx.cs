using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class ConoceMasMBA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConoceMasMBA_Click(object sender, EventArgs e)
        {

            string script = "window.open('https://www.udem.edu.mx/es/negocios/programas/maestria-en-administracion', '_blank');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenNewTab", script, true);
            //Response.Redirect("https://www.udem.edu.mx/es/negocios/programas/maestria-en-administracion");
        }
    }
}