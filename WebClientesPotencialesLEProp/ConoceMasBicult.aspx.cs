using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class ConoceMasBicult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ConoceMasBachiBicult_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://prepa.udem.edu.mx/es/bachillerato-bicultural");
        }
    }
}