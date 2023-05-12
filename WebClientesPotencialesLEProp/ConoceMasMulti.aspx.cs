using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class ConoceMasMulti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConoceMasMulti_Click(object sender, EventArgs e)
        {
            string script = "window.open('https://prepa.udem.edu.mx/es/bachillerato-multicultural', '_blank');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenNewTab", script, true);
            //Response.Redirect("https://prepa.udem.edu.mx/es/bachillerato-multicultural");
        }
    }
}