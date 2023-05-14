using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientesPotencialesLEProp
{
    public partial class Testimonios : System.Web.UI.Page
    {
        public class Global
        {
            public static string[,] Testimonios { get; set; }
            public static int CantiDeTestimonios { get; set; }
            public static int NumTestimonio { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Global.NumTestimonio = 0;
                    Global.CantiDeTestimonios = 8;

                    Global.Testimonios = new string[Global.CantiDeTestimonios, 2];

                    Global.Testimonios[0, 0] = "Legado Educativo UDEM es una muy buena opción de inversión a futuro, muy recomendable y segura.";
                    Global.Testimonios[0, 1] = "Familia Valdés Cliente Legado Educativo UDEM";

                    Global.Testimonios[1, 0] = "Recomiendo ampliamente en contar con un Legado Educativo, pues es una excelente forma de invertir sabiamente tu dinero";
                    Global.Testimonios[1, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[2, 0] = "Definitivamente la mejor decisión que pudimos tomar como familia fue la adquisición del Legado Educativo. La educacion y tener asegurada su formación es una gran tranquilidad";
                    Global.Testimonios[2, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[3, 0] = "Sin ninguna duda hoy a 5 años de adquirir Legado Educativo UDEM, puedo confirmar que ha cumplido enteramente con nuestro objetivo familiar";
                    Global.Testimonios[3, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[4, 0] = "Reconozco la gran labor y trato profesional, personalizado, y estar siempre pendiente de maximizar los beneficios de mi Legado Educativo UDEM. Se ha vuelto una grata experiencia";
                    Global.Testimonios[4, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[5, 0] = "Recomiendo ampliamente Legado Educativo UDEM, ya que no solo es una gran inversión para la educación de nuestros hijos, sino una alternativa de ahorro";
                    Global.Testimonios[5, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[6, 0] = "Desde un inicio he recibido un trato excelente y una información muy completa acerca de Legado Educativo UDEM, y esto me ha inspirado confianza en adquirirlo, pues me da la seguridad en la continuidad de los estudios de mi hijo";
                    Global.Testimonios[6, 1] = "Cliente Legado Educativo UDEM";

                    Global.Testimonios[7, 0] = "Estamos muy contentos con todo el seguimiento que hace la UDEM para simplificar los procesos";
                    Global.Testimonios[7, 1] = "Sr. Federico Cliente Legado Educativo UDEM";


                    Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio, 0];
                    Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio, 1];

                    if (Global.NumTestimonio.Equals(0))
                    {
                        Btn_AnteriorTesti.Enabled = false;
                        Btn_AnteriorTesti.CssClass = "Btn_Testimonios_Disable";
                    }
                    else if (Global.NumTestimonio > 0)
                    {
                        Btn_AnteriorTesti.Enabled = true;
                        Btn_AnteriorTesti.CssClass = "Btn_Testimonios";
                    }
                }

            }
            catch (Exception ex)
            {
                Lbl_Testimonio.Text = Global.Testimonios[0, 0];
                Lbl_Cliente.Text = Global.Testimonios[0, 1];
                Btn_AnteriorTesti.Enabled = false;
                Btn_AnteriorTesti.CssClass = "Btn_Testimonios_Disable";
                Response.Redirect("/Testimonios.aspx");
            }
        }

        protected void Btn_SiguienteTesti_Click(object sender, EventArgs e)

        {
            try
            {
                if (Global.NumTestimonio >= 0 && Global.NumTestimonio <= Global.CantiDeTestimonios-1)
                {
                    Global.NumTestimonio++;
                }

                if (Global.NumTestimonio.Equals(Global.CantiDeTestimonios))
                {
                    Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio-1, 0];
                    Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio-1, 1];
                    Btn_AnteriorTesti.Enabled = true;
                    Btn_AnteriorTesti.CssClass = "Btn_Testimonios";
                    Btn_SiguienteTesti.Enabled = false;
                    Btn_SiguienteTesti.CssClass = "Btn_Testimonios_Disable";
                }
                else if (Global.NumTestimonio < Global.CantiDeTestimonios)
                {
                    if ((Global.NumTestimonio).Equals(1))
                    {
                        Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio, 0];
                        Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio, 1];
                    }
                    else
                    {
                        if(Lbl_Testimonio.Text.Equals(Global.Testimonios[Global.NumTestimonio - 1, 0]))
                        {
                            Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio, 0];
                            Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio, 1];
                        }
                        else
                        {
                            Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio - 1, 0];
                            Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio - 1, 1];
                        }
                    }
                    Btn_AnteriorTesti.Enabled = true;
                    Btn_AnteriorTesti.CssClass = "Btn_Testimonios";
                    Btn_SiguienteTesti.Enabled = true;
                    Btn_SiguienteTesti.CssClass = "Btn_Testimonios";
                }
            }
            catch (Exception ex)
            {
                Lbl_Testimonio.Text = Global.Testimonios[0, 0];
                Lbl_Cliente.Text = Global.Testimonios[0, 1];
                Btn_AnteriorTesti.Enabled = false;
                Btn_AnteriorTesti.CssClass = "Btn_Testimonios_Disable";
                Response.Redirect("/Testimonios.aspx");
            }

        }

        protected void Btn_AnteriorTesti_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.NumTestimonio > 0 && Global.NumTestimonio <= Global.CantiDeTestimonios)
                {
                    Global.NumTestimonio--;
                }

                if ((Global.NumTestimonio-1).Equals(0) || Global.NumTestimonio <= 0)
                {
                    if ((Global.NumTestimonio - 1).Equals(0))
                    {
                        Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio-1, 0];
                        Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio-1, 1];
                    }
                    else
                    {
                        Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio, 0];
                        Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio, 1];
                    }
                    Btn_SiguienteTesti.Enabled = true;
                    Btn_SiguienteTesti.CssClass = "Btn_Testimonios";
                    Btn_AnteriorTesti.Enabled = false;
                    Btn_AnteriorTesti.CssClass = "Btn_Testimonios_Disable";
                }
                else if (Global.NumTestimonio > 0)
                {
                    Lbl_Testimonio.Text = Global.Testimonios[Global.NumTestimonio-1, 0];
                    Lbl_Cliente.Text = Global.Testimonios[Global.NumTestimonio-1, 1];
                    Btn_SiguienteTesti.Enabled = true;
                    Btn_SiguienteTesti.CssClass = "Btn_Testimonios";
                    Btn_AnteriorTesti.Enabled = true;
                    Btn_AnteriorTesti.CssClass = "Btn_Testimonios";
                }
            }
            catch (Exception)
            {
                Lbl_Testimonio.Text = Global.Testimonios[0, 0];
                Lbl_Cliente.Text = Global.Testimonios[0, 1];
                Btn_AnteriorTesti.Enabled = false;
                Btn_AnteriorTesti.CssClass = "Btn_Testimonios_Disable";
                Response.Redirect("/Testimonios.aspx");
            }

        }
    }
}