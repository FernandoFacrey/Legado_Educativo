using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLegadoEducativo02
{
    public partial class UnexpectedError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Exception"] != null)
                {
                    Lbl_Exception.Text = Session["Exception"].ToString();
                }
                else
                {
                    Session["Exception"] = "Excepción no registrada";
                }
            }
            catch(Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
            }
        }

        protected void Btn_RedireccionaHome_Click(object sender, EventArgs e)
        {
            Session["Exception"] = string.Empty;
            Response.Redirect("~/WebLE02InicioCreaCuenta.aspx");
        }
    }
}