using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class VisionUDEM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_VisionUDEM_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.udem.edu.mx/es/conoce/vision-udem");
        }
    }
}