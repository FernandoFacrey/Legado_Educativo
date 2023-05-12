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
            public static int CantiDeTestimonio { get; set; }
            public static int NumTestimonios { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    Global.Testimonios[0, 0] = "Legado Educativo UDEM es una muy buena opción de inversión a futuro, muy recomendable y segura.";
                    Global.Testimonios[0, 1] = "Familia Valdés Cliente Legado Educativo UDEM";

                    Global.Testimonios[1, 0] = "Recomiendo amplimente en contar con un Legado Educativo, pues es una excelente forma de invertir sabiamente tu dinero";
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
                    

                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void Btn_SiguienteTesti_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_AnteriorTesti_Click(object sender, EventArgs e)
        {

        }
    }
}