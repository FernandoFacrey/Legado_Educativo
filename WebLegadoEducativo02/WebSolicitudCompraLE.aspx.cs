using Microsoft.Xrm.Tooling.Connector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLegadoEducativo02.Clases;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace WebLegadoEducativo02
{
    public partial class WebSolicitudCompraLE : System.Web.UI.Page
    {
        public class Person
        {
            public string id { get; set; }
            public string ridm { get; set; }
            public string email { get; set; }
            public string status { get; set; }
            public string termOut { get; set; }
        }
        public class PosibleDuplicado
        {
            public static bool Actualiza { get; set; }
            public static bool Duplicado { get; set; }
            public static bool CorreoIgual { get; set; }
            public static bool PorPorcentaje { get; set; }
            public static int Coincidencia { get; set; }
        }

        public class ActualizaCotizacion
        {
            public static bool Actualiza { get; set; }
            public static int Index { get; set; }
        }

        public class Global
        {
            public static string Matricula { get; set; }

            public static string[] ArchivoFichaDePago { get; set; }
            public static HashSet<string> DivisionProfesional { get; set; }

            public static Dictionary<string, bool> FasesSolicitud { get; set; }

            public static List<Dictionary<string, object>> List_UnidadesBach { get; set; }
            public static Dictionary<string, object> UnidadBach { get; set; }

            public static List<Dictionary<string, object>> List_ListaDePrecios { get; set; }
            public static Dictionary<string, object> ListaDePrecios { get; set; }

            public static List<Dictionary<string, object>> List_Productos { get; set; }
            public static Dictionary<string, object> Producto { get; set; }

            public static List<Dictionary<string, object>> List_ProgramasBach { get; set; }
            public static List<Dictionary<string, object>> List_ProgramasProf { get; set; }
            public static List<Dictionary<string, object>> List_ProgramasPosg { get; set; }
            public static Dictionary<string, object> Programa { get; set; }

            //Global Titular
            public static Dictionary<string, object> Titular { get; set; }

            //Global Titular
            public static Dictionary<string, object> DatosFiscales { get; set; }

            //Global Titular designado
            public static Dictionary<string, string> Titular_Designado { get; set; }

            //Global cotizacion
            public static Dictionary<string, object> Cotizacion { get; set; }
            public static List<Dictionary<string, object>> List_Cotizaciones { get; set; }
            public static int NumCotizaciones { get; set; }

            public static Dictionary<string, List<string>> Escuelas { get; set; }

            //Global beneficiario
            public static Dictionary<string, string> Beneficiario { get; set; }
            public static List<Dictionary<string, string>> List_Beneficiarios { get; set; }
            public static int NumBeneficiarios { get; set; }
            public static string[,] Arrcp { get; set; }
            public static string[,] Arresccue { get; set; }
            public static bool BoolDatosFiscales { get; set; }
            public static string GuidOportunidad { get; set; }
            public static string GuidDatosFiscales { get; set; }
            public static string GuidSolicitud { get; set; }
        }
        const string guid_ListaPrecio_LE = "577A2185-552A-EE11-BDF4-000D3A343FEF";

        WS_LE_Beneficiarios.WS_LE_Beneficiarios wsInsBenefi = new WS_LE_Beneficiarios.WS_LE_Beneficiarios();
        WS_LE_ConsBeneficiario.WS_LE_ConsBeneficiario wsConsBenefi = new WS_LE_ConsBeneficiario.WS_LE_ConsBeneficiario();
        WS_LE_ConsCP.WS_LE_ConsCP cp = new WS_LE_ConsCP.WS_LE_ConsCP();
        WS_LE_ConsDatosFiscales.WS_LE_ConsDatosFiscales wsConsDatfisc = new WS_LE_ConsDatosFiscales.WS_LE_ConsDatosFiscales();
        WS_LE_ConsEscuelaCuenta.WS_LE_ConsEscuelaCuenta wsConsEscCue = new WS_LE_ConsEscuelaCuenta.WS_LE_ConsEscuelaCuenta();
        WS_LE_ConsFamiliaContacto.WS_LE_ConsFamiliaContacto wsConsFamCon = new WS_LE_ConsFamiliaContacto.WS_LE_ConsFamiliaContacto();
        WS_LE_ConsProducto.WS_LE_ConsProducto wsConsProduct = new WS_LE_ConsProducto.WS_LE_ConsProducto();
        WS_LE_ConsultaContac.WS_LE_ConsultaContac wsConsContact = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
        WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom wsInsSolCom = new WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom();
        WS_LE_ListaDePrecios.WS_LE_ListaDePrecios wsConsListPrecio = new WS_LE_ListaDePrecios.WS_LE_ListaDePrecios();
        WS_LE_ProgramaAcademico.WS_LE_ProgramaAcademico wsConsProgAca = new WS_LE_ProgramaAcademico.WS_LE_ProgramaAcademico();
        WS_LE_Cotizaciones.WS_LE_Cotizaciones wsInsCoti = new WS_LE_Cotizaciones.WS_LE_Cotizaciones();
        WS_LE_ConsUnidadUDEM.WS_LE_ConsUnidadUDEM wsConsUniUDEM = new WS_LE_ConsUnidadUDEM.WS_LE_ConsUnidadUDEM();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Deshabilita la opcion de regresar y adelantar la pagina
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();

            //Agrega animaciones al titulo de los campos "nivel de procedencia" 
            //ddl_NivelProcede.Attributes.Add("onchange", "showLoadingInstitucionProdecedencia()");
            //ddl_NombreInstiProce.Attributes.Add("onchange", "showLoadingInstitucionProdecedencia()");
            //ddl_EstadoInstiProce.Attributes.Add("onchange", "showLoadingInstitucionProdecedencia()");

            if (!IsPostBack)
            {
                try
                {
                    if (Session["Id"] != null)
                    {
                        if (Session["Id"].Equals(1))
                        {
                            Global.List_Cotizaciones = new List<Dictionary<string, object>>();

                            RegisterAsyncTask(new PageAsyncTask(AsyncCargaProdProgListUni));
                            //CargaProdProgList();
                            RegisterAsyncTask(new PageAsyncTask(Obtener_Escuelas));
                            //Obtener_Escuelas();


                            Init_Dict_Titular();
                            Init_Dict_DatosFiscales();
                            Init_Dict_TitularDesignado();
                            Init_Dict_Beneficiario();
                            if (SolicitudesCs.CurrentSolicitud != null)
                            {
                                if (SolicitudesCs.CurrentSolicitud["fases_solicitud"] is Dictionary<string, object> currSolicitud)
                                {
                                    var convertedDict = currSolicitud.ToDictionary(
                                        kvp => kvp.Key,         // La clave se mantiene como string
                                        kvp => (bool)kvp.Value  // Se convierte el valor a bool
                                    );

                                    Global.FasesSolicitud = convertedDict;
                                }

                                if (SolicitudesCs.CurrentSolicitud["estatus"].Equals("En captura") || SolicitudesCs.CurrentSolicitud["estatus"].Equals("Completada"))
                                {
                                    if (SolicitudesCs.CurrentSolicitud["titular"] is Dictionary<string, object> titular)
                                    {
                                        string guidtitu = (string)titular["guidTitular"];
                                        var resultTitu = wsConsContact.ConsultaContactGuid(guidtitu);
                                        Init_Dict_Titular();
                                        List<string> nivelEgreso = new List<string>();
                                        if (resultTitu.Length > 0)
                                        {
                                            Fill_Titular(resultTitu[0].contactid, resultTitu[0].firstname, resultTitu[0].middlename, resultTitu[0].new_apellidopaterno, resultTitu[0].new_apellidomaterno, resultTitu[0].new_fechacompletanacimiento, resultTitu[0].mobilephone, resultTitu[0].telephone2, resultTitu[0].emailaddress1,
                                                resultTitu[0].new_exalumno, "", nivelEgreso, resultTitu[0].address1_line1, resultTitu[0].address1_line2, resultTitu[0].recr_codigopostal, resultTitu[0].new_estadodecontacto, resultTitu[0].address1_line3, resultTitu[0].new_municipiodecontacto, resultTitu[0].new_paisdecontacto);
                                        }
                                        Fill_Form_Titular();
                                    }
                                    if (SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"].Equals("True"))
                                    {
                                        if (SolicitudesCs.CurrentSolicitud["datosFiscales"] is Dictionary<string, object> DatosFisc)
                                        {
                                            string guidDatosFisc = (string)DatosFisc["guidDatosFiscales"];
                                            var resultDatFisc = wsConsDatfisc.ConsDatosFiscalesGuid(guidDatosFisc);
                                            Init_Dict_DatosFiscales();
                                            if (resultDatFisc.Length > 0)
                                            {
                                                Fill_DatosFiscales(resultDatFisc[0].new_datosfiscalesdecontactoid, resultDatFisc[0].new_name, resultDatFisc[0].new_razonsocial, resultDatFisc[0].new_rfc, resultDatFisc[0].new_direccionfiscalcalleynumero,
                                                    resultDatFisc[0].new_recr_codigopostal, resultDatFisc[0].new_direccionfiscalestado, resultDatFisc[0].new_direccionfiscalcolonia, resultDatFisc[0].new_direccionfiscalmunicipio, resultDatFisc[0].new_direccionfiscalpais);
                                            }
                                            Fill_Form_DatosFiscales();
                                        }
                                    }
                                    if (SolicitudesCs.CurrentSolicitud["titularDesignado"] is Dictionary<string, object> titularDesi)
                                    {
                                        if (titularDesi.Count > 0)
                                        {
                                            string guidtituDesi = (string)titularDesi["guidTitularDesignado"];
                                            var resultTituDesi = wsConsContact.ConsultaContactGuid(guidtituDesi);
                                            Init_Dict_TitularDesignado();

                                            var parent = wsConsFamCon.ConsFamParent((string)Global.Titular["guid_titular"], guidtituDesi);
                                            string parentesco = string.Empty;
                                            if (parent.Length > 0)
                                            {
                                                parentesco = parent[0].new_parentesco;
                                            }

                                            string fecha = resultTituDesi[0].new_fechacompletanacimiento;
                                            DateTime.TryParseExact(fecha, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaDateTime);
                                            string fechaFormateada = fechaDateTime.ToString("dd/MM/yyyy");

                                            if (resultTituDesi.Length > 0)
                                            {
                                                Fill_TitularDesignado(resultTituDesi[0].contactid, resultTituDesi[0].firstname, resultTituDesi[0].middlename, resultTituDesi[0].new_apellidopaterno, resultTituDesi[0].new_apellidomaterno,
                                                    fechaFormateada, resultTituDesi[0].mobilephone, resultTituDesi[0].telephone2, resultTituDesi[0].emailaddress1, parentesco);
                                            }

                                            Fill_Form_TitularDesignado();
                                        }
                                    }
                                    if (SolicitudesCs.CurrentSolicitud["beneficiarios"] is List<Dictionary<string, object>> beneficiarios)
                                    {
                                        if (beneficiarios.Count > 0)
                                        {
                                            Global.List_Beneficiarios = new List<Dictionary<string, string>>();
                                            Global.NumBeneficiarios = beneficiarios.Count;

                                            foreach (var item in beneficiarios)
                                            {
                                                int indice = beneficiarios.IndexOf(item);

                                                string guidBeneficiario = (string)item["guidBeneficiario"];
                                                string guidSolicitud = (string)SolicitudesCs.CurrentSolicitud["GuidSolicitud"];

                                                var resultBeneficiario = wsConsContact.ConsultaContactGuid(guidBeneficiario);
                                                Init_Dict_Beneficiario();

                                                var parent = wsConsFamCon.ConsFamParent((string)Global.Titular["guid_titular"], guidBeneficiario);
                                                string parentesco = string.Empty;

                                                var benefi = wsConsBenefi.ConBeneficiarioGuid(guidSolicitud, guidBeneficiario);

                                                if (parent.Length > 0 && resultBeneficiario.Length > 0 && benefi.Length > 0)
                                                {
                                                    parentesco = parent[0].new_parentesco;

                                                    Fill_Beneficiario((indice + 1).ToString(), guidBeneficiario, resultBeneficiario[0].firstname, resultBeneficiario[0].middlename, resultBeneficiario[0].new_apellidopaterno, resultBeneficiario[0].new_apellidomaterno,
                                                        resultBeneficiario[0].new_fechacompletanacimiento, resultBeneficiario[0].mobilephone, parentesco, resultBeneficiario[0].emailaddress1, "", benefi[0].udem_niveldeestudio_Name,
                                                        benefi[0].udem_escueladeprocedencia_Name, benefi[0].udem_carreranoudem, benefi[0].udem_grado, benefi[0].udem_debeca);
                                                }
                                                Global.List_Beneficiarios.Add(Global.Beneficiario);
                                            }
                                        }
                                        else
                                        {
                                            Global.List_Beneficiarios = new List<Dictionary<string, string>>();
                                            Global.NumBeneficiarios = beneficiarios.Count;
                                        }

                                    }
                                    if (SolicitudesCs.CurrentSolicitud["cotizaciones"] is List<Dictionary<string, object>> cotizaciones)
                                    {
                                        if (cotizaciones.Count > 0)
                                        {
                                            Global.List_Cotizaciones = new List<Dictionary<string, object>>();

                                            foreach (var item in cotizaciones)
                                            {
                                                int indice = cotizaciones.IndexOf(item);

                                                string guidOferta = (string)item["guidOferta"];
                                                string guidProducto = (string)item["guidProducto"];
                                                string guidPrograma = (string)item["guidprograma_academico"];
                                                string nivel = "";
                                                Guid _guidProducto = new Guid(guidProducto);

                                                var programa = wsConsProgAca.ConsProgramaAcademicoGuid("true", guidPrograma);

                                                if (programa[0].mensaje != "Sin Registros")
                                                {
                                                    switch (programa[0].new_nivelacademico_name)
                                                    {
                                                        case "Bachillerato":
                                                            Fill_Cotizacion("", guidProducto, programa[0].new_nivelacademico_name, "", programa[0].new_nivelacademico_name, (string)item["cuanto_QuiereCotizar"], (string)item["importe"], "", "");
                                                            break;

                                                        case "Profesional":
                                                            Fill_Cotizacion("", guidProducto, programa[0].new_nivelacademico_name, "", "", (string)item["cantidad_creditos_periodos"], (string)item["importe"], programa[0].new_division_name, (string)item["programa_academico"]);
                                                            break;

                                                        case "Posgrado":
                                                            Fill_Cotizacion("", guidProducto, programa[0].new_nivelacademico_name, "", "", (string)item["cantidad_creditos_periodos"], (string)item["importe"], programa[0].new_division_name, (string)item["programa_academico"]);
                                                            break;
                                                    }
                                                }
                                                Global.List_Cotizaciones.Add(Global.Cotizacion);
                                            }
                                        }

                                    }

                                    if (SolicitudesCs.CurrentSolicitud["GuidOportunidad"] is object GuidOportunidad)
                                    {
                                        Global.GuidOportunidad = (string)GuidOportunidad;
                                    }
                                    if (SolicitudesCs.CurrentSolicitud["GuidSolicitud"] is object GuidSolicitud)
                                    {
                                        Global.GuidSolicitud = (string)GuidSolicitud;
                                    }
                                }

                            }
                            lbl_NombreTitular_UsoDeDatos.Text = Global.Titular["primer_nombre"] + " " + Global.Titular["segundo_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];
                            ActualizaCotizacion.Actualiza = false;

                            Global.NumCotizaciones = 0;
                            Global.BoolDatosFiscales = false;

                            pnl_Titular.Visible = true;

                            FillStatusSolicitud();
                            MuestraFase_Btns("titular");
                        }
                        else
                        {
                            Logout("Se ha cerrado la sesion", "WebLE02InicioCreaCuenta.aspx");
                        }
                    }
                    else
                    {
                        Logout("Se ha cerrado la sesion", "WebLE02InicioCreaCuenta.aspx");
                    }
                }
                catch (Exception ex)
                {
                    Logout("Se ha cerrado la sesion por un error => " + ex.Message, "WebLE02InicioCreaCuenta.aspx");
                }
            }
        }

        #region Metodos Sincronos
        protected void CargaProdProgList()
        {
            Stopwatch crono = new Stopwatch();
            crono.Start();

            Obtener_Producto();
            Obtener_Programas();
            Obtener_ListasDePrecios();

            crono.Stop();
        }
        protected void Obtener_Producto()
        {
            Global.List_Productos = new List<Dictionary<string, object>>();
            var producto = wsConsProduct.ConsProducto("Legado Educativo");
            foreach (var registro in producto)
            {
                Init_Dict_Producto();

                Global.Producto["productid"] = registro.productid;
                Global.Producto["name"] = registro.name;
                Global.Producto["productnumber"] = registro.productnumber;
                Global.Producto["validfromdate"] = registro.validfromdate;
                Global.Producto["validtodate"] = registro.validtodate;
                Global.Producto["description"] = registro.description;
                Global.Producto["defaultuomscheduleid"] = registro.defaultuomscheduleid;
                Global.Producto["defaultuomschedule_name"] = registro.defaultuomschedule_name;
                Global.Producto["defaultuomid"] = registro.defaultuomid;
                Global.Producto["defaultuom_name"] = registro.defaultuom_name;
                Global.Producto["pricelevelid"] = registro.pricelevelid;
                Global.Producto["pricelevel_name"] = registro.pricelevel_name;
                Global.Producto["quantitydecimal"] = registro.quantitydecimal;

                Global.List_Productos.Add(Global.Programa);
            }
        }
        protected void Obtener_Programas()
        {
            HashSet<string> nivel = new HashSet<string>();

            Global.List_ProgramasBach = new List<Dictionary<string, object>>();
            Global.List_ProgramasProf = new List<Dictionary<string, object>>();
            Global.List_ProgramasPosg = new List<Dictionary<string, object>>();

            var programa = wsConsProgAca.ConsProgramaAcademico("true");

            foreach (var registro in programa)
            {
                Init_Dict_Programa();

                Global.Programa["new_programaacademicoid"] = registro.new_programaacademicoid;
                Global.Programa["new_programa"] = registro.new_programa;
                Global.Programa["new_siglas"] = registro.new_siglas;
                Global.Programa["new_nivelacademico_id"] = registro.new_nivelacademico_id;
                Global.Programa["new_nivelacademico_name"] = registro.new_nivelacademico_name;
                Global.Programa["new_division_id"] = registro.new_division_id;
                Global.Programa["new_division_name"] = registro.new_division_name;
                Global.Programa["recr_campusid"] = registro.recr_campusid;
                Global.Programa["recr_campus_name"] = registro.recr_campus_name;
                Global.Programa["udem_disponiblele"] = registro.udem_disponiblele;
                Global.Programa["udem_creditosporprograma"] = registro.udem_creditosporprograma;
                Global.Programa["udem_semestresporprograma"] = registro.udem_semestresporprograma;
                Global.Programa["udem_tipodeperiodo"] = registro.udem_tipodeperiodo;
                Global.Programa["udem_productorelacionado_id"] = registro.udem_productorelacionado_id;
                Global.Programa["udem_productorelacionado_name"] = registro.udem_productorelacionado_name;

                nivel.Add(registro.new_nivelacademico_name);

                switch (Global.Programa["new_nivelacademico_name"])
                {
                    case "Bachillerato":
                        Global.List_ProgramasBach.Add(Global.Programa);
                        break;

                    case "Profesional":
                        Global.List_ProgramasProf.Add(Global.Programa);
                        break;

                    case "Posgrado":
                        Global.List_ProgramasPosg.Add(Global.Programa);
                        break;
                }
            }



            string[] _Nivel = new string[3];
            foreach (var item in nivel)
            {
                if (item != null)
                {
                    switch (item)
                    {
                        case "Bachillerato":
                            _Nivel[0] = item;
                            break;
                        case "Profesional":
                            _Nivel[1] = item;
                            break;
                        case "Posgrado":
                            _Nivel[2] = item;
                            break;
                    }
                }
            }
            Ddl_NivelAplicarLE.Items.Add(new ListItem("-----Seleccionar nivel-----", "0"));
            foreach (var item in _Nivel)
            {
                if (item != null)
                {
                    Ddl_NivelAplicarLE.Items.Add(new ListItem(item.ToString()));
                }
            }
        }
        protected void Obtener_ListasDePrecios()
        {
            Global.List_ListaDePrecios = new List<Dictionary<string, object>>();

            var listaPrecios = wsConsListPrecio.ConsListaPrecios(guid_ListaPrecio_LE);

            foreach (var registro in listaPrecios)
            {
                Init_Dict_ListaDePrecios();

                Global.ListaDePrecios["productpricelevelid"] = registro.productpricelevelid;
                Global.ListaDePrecios["pricelevelid"] = registro.pricelevelid;
                Global.ListaDePrecios["pricelevel_name"] = registro.pricelevel_name;
                Global.ListaDePrecios["productid"] = registro.productid;
                Global.ListaDePrecios["product_name"] = registro.product_name;
                Global.ListaDePrecios["uomid"] = registro.uomid;
                Global.ListaDePrecios["uom_name"] = registro.uom_name;
                Global.ListaDePrecios["transactioncurrencyid"] = registro.transactioncurrencyid;
                Global.ListaDePrecios["transactioncurrency_name"] = registro.transactioncurrency_name;
                Global.ListaDePrecios["quantitysellingcode"] = registro.quantitysellingcode;
                Global.ListaDePrecios["pricingmethodcode"] = registro.pricingmethodcode;
                Global.ListaDePrecios["amount"] = registro.amount;
                Global.ListaDePrecios["percentage"] = registro.percentage;
                Global.ListaDePrecios["roundingpolicycode"] = registro.roundingpolicycode;
                Global.ListaDePrecios["roundingoptioncode"] = registro.roundingoptioncode;
                Global.ListaDePrecios["roundingoptionamount"] = registro.roundingoptionamount;

                Global.List_ListaDePrecios.Add(Global.ListaDePrecios);
            }
        }
        #endregion

        #region Metodos Asincronos
        async Task AsyncCargaProdProgListUni()
        {
            await Task.WhenAll(AsyncObtener_Producto(), AsyncObtener_Programas(), AsyncObtener_ListasDePrecios(), AsyncObtener_UnidadesBach());
        }
        async protected Task AsyncObtener_Producto()
        {
            Global.List_Productos = new List<Dictionary<string, object>>();
            var producto = await Task.Run(() => wsConsProduct.ConsProducto("Legado Educativo"));
            foreach (var registro in producto)
            {
                Init_Dict_Producto();

                Global.Producto["productid"] = registro.productid;
                Global.Producto["name"] = registro.name;
                Global.Producto["productnumber"] = registro.productnumber;
                Global.Producto["validfromdate"] = registro.validfromdate;
                Global.Producto["validtodate"] = registro.validtodate;
                Global.Producto["description"] = registro.description;
                Global.Producto["defaultuomscheduleid"] = registro.defaultuomscheduleid;
                Global.Producto["defaultuomschedule_name"] = registro.defaultuomschedule_name;
                Global.Producto["defaultuomid"] = registro.defaultuomid;
                Global.Producto["defaultuom_name"] = registro.defaultuom_name;
                Global.Producto["pricelevelid"] = registro.pricelevelid;
                Global.Producto["pricelevel_name"] = registro.pricelevel_name;
                Global.Producto["quantitydecimal"] = registro.quantitydecimal;

                Global.List_Productos.Add(Global.Programa);
            }
        }
        async protected Task AsyncObtener_Programas()
        {
            HashSet<string> nivel = new HashSet<string>();

            Global.List_ProgramasBach = new List<Dictionary<string, object>>();
            Global.List_ProgramasProf = new List<Dictionary<string, object>>();
            Global.List_ProgramasPosg = new List<Dictionary<string, object>>();

            var programa = await Task.Run(() => wsConsProgAca.ConsProgramaAcademico("true"));

            foreach (var registro in programa)
            {
                Init_Dict_Programa();

                Global.Programa["new_programaacademicoid"] = registro.new_programaacademicoid;
                Global.Programa["new_programa"] = registro.new_programa;
                Global.Programa["new_siglas"] = registro.new_siglas;
                Global.Programa["new_nivelacademico_id"] = registro.new_nivelacademico_id;
                Global.Programa["new_nivelacademico_name"] = registro.new_nivelacademico_name;
                Global.Programa["new_division_id"] = registro.new_division_id;
                Global.Programa["new_division_name"] = registro.new_division_name;
                Global.Programa["recr_campusid"] = registro.recr_campusid;
                Global.Programa["recr_campus_name"] = registro.recr_campus_name;
                Global.Programa["udem_disponiblele"] = registro.udem_disponiblele;
                Global.Programa["udem_creditosporprograma"] = registro.udem_creditosporprograma;
                Global.Programa["udem_semestresporprograma"] = registro.udem_semestresporprograma;
                Global.Programa["udem_tipodeperiodo"] = registro.udem_tipodeperiodo;
                Global.Programa["udem_productorelacionado_id"] = registro.udem_productorelacionado_id;
                Global.Programa["udem_productorelacionado_name"] = registro.udem_productorelacionado_name;

                nivel.Add(registro.new_nivelacademico_name);

                switch (Global.Programa["new_nivelacademico_name"])
                {
                    case "Bachillerato":
                        Global.List_ProgramasBach.Add(Global.Programa);
                        break;

                    case "Profesional":
                        Global.List_ProgramasProf.Add(Global.Programa);
                        break;

                    case "Posgrado":
                        Global.List_ProgramasPosg.Add(Global.Programa);
                        break;
                }
            }
            string[] _Nivel = new string[3];
            foreach (var item in nivel)
            {
                if (item != null)
                {
                    switch (item)
                    {
                        case "Bachillerato":
                            _Nivel[0] = item;
                            break;
                        case "Profesional":
                            _Nivel[1] = item;
                            break;
                        case "Posgrado":
                            _Nivel[2] = item;
                            break;
                    }
                }
            }
            Ddl_NivelAplicarLE.Items.Add(new ListItem("-----Seleccionar nivel-----", "0"));
            foreach (var item in _Nivel)
            {
                if (item != null)
                {
                    Ddl_NivelAplicarLE.Items.Add(new ListItem(item.ToString()));
                }
            }
        }
        async protected Task AsyncObtener_ListasDePrecios()
        {
            Global.List_ListaDePrecios = new List<Dictionary<string, object>>();

            var listaPrecios = await Task.Run(() => wsConsListPrecio.ConsListaPrecios(guid_ListaPrecio_LE));

            foreach (var registro in listaPrecios)
            {
                Init_Dict_ListaDePrecios();

                Global.ListaDePrecios["productpricelevelid"] = registro.productpricelevelid;
                Global.ListaDePrecios["pricelevelid"] = registro.pricelevelid;
                Global.ListaDePrecios["pricelevel_name"] = registro.pricelevel_name;
                Global.ListaDePrecios["productid"] = registro.productid;
                Global.ListaDePrecios["product_name"] = registro.product_name;
                Global.ListaDePrecios["uomid"] = registro.uomid;
                Global.ListaDePrecios["uom_name"] = registro.uom_name;
                Global.ListaDePrecios["transactioncurrencyid"] = registro.transactioncurrencyid;
                Global.ListaDePrecios["transactioncurrency_name"] = registro.transactioncurrency_name;
                Global.ListaDePrecios["quantitysellingcode"] = registro.quantitysellingcode;
                Global.ListaDePrecios["pricingmethodcode"] = registro.pricingmethodcode;
                Global.ListaDePrecios["amount"] = registro.amount;
                Global.ListaDePrecios["percentage"] = registro.percentage;
                Global.ListaDePrecios["roundingpolicycode"] = registro.roundingpolicycode;
                Global.ListaDePrecios["roundingoptioncode"] = registro.roundingoptioncode;
                Global.ListaDePrecios["roundingoptionamount"] = registro.roundingoptionamount;

                Global.List_ListaDePrecios.Add(Global.ListaDePrecios);
            }
        }
        async protected Task AsyncObtener_UnidadesBach()
        {
            Global.List_UnidadesBach = new List<Dictionary<string, object>>();

            var unidades = await Task.Run(() => wsConsUniUDEM.ConsUnidadUDEM(""));

            foreach (var registro in unidades)
            {
                Init_Dict_Unidad();

                Global.UnidadBach["new_unidadudemid"] = registro.new_unidadudemid;
                Global.UnidadBach["new_siglas"] = registro.new_siglas;
                Global.UnidadBach["new_name"] = registro.new_name;
                Global.UnidadBach["recr_displayorder"] = registro.recr_displayorder;
                Global.UnidadBach["produrecr_nivelacademicoct_name"] = registro.recr_nivelacademico;

                Global.List_UnidadesBach.Add(Global.UnidadBach);
            }
        }
        #endregion

        #region Init Diccionarios
        protected void Init_Dict_Unidad()
        {
            Global.UnidadBach = new Dictionary<string, object>()
            {
                {"new_unidadudemid", string.Empty},
                {"new_siglas", string.Empty},
                {"new_name", string.Empty},
                {"recr_displayorder", string.Empty},
                {"recr_nivelacademico", string.Empty},
            };
        }
        protected void Init_Dict_Producto()
        {
            Global.Producto = new Dictionary<string, object>()
            {
                {"productid", string.Empty},
                {"name", string.Empty},
                {"productnumber", string.Empty},
                {"validfromdate", string.Empty},
                {"validtodate", string.Empty},
                {"description", string.Empty},
                {"defaultuomscheduleid", string.Empty},
                {"defaultuomschedule_name", string.Empty},
                {"defaultuomid", string.Empty},
                {"defaultuom_name", string.Empty},
                {"pricelevelid", string.Empty},
                {"pricelevel_name", string.Empty},
                {"quantitydecimal", string.Empty},
            };
        }
        protected void Init_Dict_Programa()
        {
            Global.Programa = new Dictionary<string, object>()
            {
                {"new_programaacademicoid", string.Empty},
                {"new_programa", string.Empty},
                {"new_siglas", string.Empty},
                {"new_nivelacademico_id", string.Empty},
                {"new_nivelacademico_name", string.Empty},
                {"new_division_id", string.Empty},
                {"new_division_name", string.Empty},
                {"recr_campusid", string.Empty},
                {"recr_campus_name", string.Empty},
                {"udem_disponiblele", string.Empty},
                {"udem_creditosporprograma", string.Empty},
                {"udem_semestresporprograma", string.Empty},
                {"udem_tipodeperiodo", string.Empty},
                {"udem_productorelacionado_id", string.Empty},
                {"udem_productorelacionado_name", string.Empty},
            };
        }
        protected void Init_Dict_ListaDePrecios()
        {
            Global.ListaDePrecios = new Dictionary<string, object>()
            {
                {"productpricelevelid", string.Empty},
                {"pricelevelid", string.Empty},
                {"pricelevel_name", string.Empty},
                {"productid", string.Empty},
                {"product_name", string.Empty},
                {"uomid", string.Empty},
                {"uom_name", string.Empty},
                {"transactioncurrencyid", string.Empty},
                {"transactioncurrency_name", string.Empty},
                {"quantitysellingcode", string.Empty},
                {"pricingmethodcode", string.Empty},
                {"amount", string.Empty},
                {"percentage", string.Empty},
                {"roundingpolicycode", string.Empty},
                {"roundingoptioncode", string.Empty},
                {"roundingoptionamount", string.Empty},
            };
        }
        private void Init_Dict_Titular()
        {
            Global.Titular = new Dictionary<string, object>
            {
                { "guid_titular", string.Empty},
                { "primer_nombre", string.Empty},
                { "segundo_nombre", string.Empty},
                { "apellido_paterno", string.Empty},
                { "apellido_materno", string.Empty},
                { "fecha_nacimiento", string.Empty},
                { "celular", string.Empty},
                { "telefono_casa", string.Empty},
                { "correo_electronico", string.Empty},
                { "titular_exaUDEM", string.Empty},
                { "matricula", string.Empty},
                { "nivel_exaUDEM", new List<string>()},
                { "calle", string.Empty},
                { "numero", string.Empty},
                { "codigo_postal", string.Empty},
                { "estado", string.Empty},
                { "colonia", string.Empty},
                { "municipio", string.Empty},
                { "pais", string.Empty},
            };
        }
        private void Init_Dict_DatosFiscales()
        {
            Global.DatosFiscales = new Dictionary<string, object>
            {
                { "guid_DatosFiscales", string.Empty},
                { "nombre", string.Empty},
                { "razon_social", string.Empty},
                { "rfc", string.Empty},
                { "calle_numero", string.Empty},
                { "codigo_postal", string.Empty},
                { "estado", string.Empty},
                { "colonia", string.Empty},
                { "municipio", string.Empty},
                { "pais", string.Empty},
            };
        }
        private void Init_Dict_TitularDesignado()
        {
            Global.Titular_Designado = new Dictionary<string, string>
            {
                { "guid_titular_designado", string.Empty},
                { "primer_nombre", string.Empty},
                { "segundo_nombre", string.Empty},
                { "apellido_paterno", string.Empty},
                { "apellido_materno", string.Empty},
                { "fecha_nacimiento", string.Empty},
                { "celular", string.Empty},
                { "telefono_casa", string.Empty},
                { "correo_electronico", string.Empty},
                { "parentesco", string.Empty},
            };
        }
        private void Init_Dict_Cotizacion(string nivel)
        {
            switch (nivel)
            {
                case "Bachillerato":
                    Global.Cotizacion = new Dictionary<string, object>
                    {
                        { "numero_cotizacion", string.Empty},
                        { "guid_cotizacion", string.Empty},
                        { "nivel", string.Empty},
                        { "unidad", string.Empty},
                        { "tipo_bachillerato", string.Empty},
                        { "creditos ", string.Empty},
                        { "monto", string.Empty},
                    };
                    break;

                case "Profesional":
                    Global.Cotizacion = new Dictionary<string, object>
                    {
                        { "numero_cotizacion", string.Empty},
                        { "guid_cotizacion", string.Empty},
                        { "nivel", string.Empty},
                        { "division", string.Empty},
                        { "programa", string.Empty},
                        { "creditos", string.Empty},
                        { "monto", string.Empty},
                    };
                    break;

                case "Posgrado":
                    Global.Cotizacion = new Dictionary<string, object>
                    {
                        { "numero_cotizacion", string.Empty},
                        { "guid_cotizacion", string.Empty},
                        { "nivel", string.Empty},
                        { "programa", string.Empty},
                        { "creditos", string.Empty},
                        { "monto", string.Empty},
                    };
                    break;
            }

        }
        private void Init_Dict_Beneficiario()
        {
            Global.Beneficiario = new Dictionary<string, string>
            {
                { "numero_beneficiario", string.Empty},
                { "guid_beneficiario", string.Empty},
                { "primer_nombre", string.Empty},
                { "segundo_nombre", string.Empty},
                { "apellido_paterno", string.Empty},
                { "apellido_materno", string.Empty},
                { "fecha_nacimiento", string.Empty},
                { "celular", string.Empty},
                { "correo_electronico", string.Empty},
                { "parentesco", string.Empty},
                { "beca", string.Empty},
                { "nivel_estudio", string.Empty},
                { "escuela_procedencia", string.Empty},
                { "carrera_NoUDEM", string.Empty},
                { "grado_beca", string.Empty},
                { "porcentaje_beca", string.Empty},
            };
        }
        protected void Init_FasesSolicitud()
        {
            Global.FasesSolicitud = new Dictionary<string, bool>
            {
                { "titular", false },
                { "datosfiscales", false },
                { "titular_designado", false },
                { "cotizacion", false },
                { "beneficiario", false },
                { "confirmacion", false },
            };
        }
        #endregion

        #region Titular
        protected void Fill_Titular(string guid_titular, string primer_nombre, string segundo_nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, string celular, string telefono_casa, string correo_electronico, string titular_exaUDEM, string matricula,
                                    List<string> nivel_exaUDEM, string calle, string numero, string codigo_postal, string estado, string colonia, string municipio, string pais)
        {
            for (int i = 0; i < Global.Titular.Count; i++)
            {
                var item = Global.Titular.ElementAt(i);

                switch (item.Key)
                {
                    case "guid_titular":
                        Global.Titular[item.Key] = guid_titular;
                        break;

                    case "primer_nombre":
                        Global.Titular[item.Key] = primer_nombre;
                        break;

                    case "segundo_nombre":
                        Global.Titular[item.Key] = segundo_nombre;
                        break;

                    case "apellido_paterno":
                        Global.Titular[item.Key] = apellido_paterno;
                        break;

                    case "apellido_materno":
                        Global.Titular[item.Key] = apellido_materno;
                        break;

                    case "fecha_nacimiento":
                        Global.Titular[item.Key] = fecha_nacimiento;

                        break;

                    case "celular":
                        Global.Titular[item.Key] = celular;
                        break;

                    case "telefono_casa":
                        Global.Titular[item.Key] = telefono_casa;
                        break;

                    case "correo_electronico":
                        Global.Titular[item.Key] = correo_electronico;
                        break;

                    case "titular_exaUDEM":
                        Global.Titular[item.Key] = titular_exaUDEM;
                        break;

                    case "matricula":
                        Global.Titular[item.Key] = matricula;
                        break;

                    case "nivel_exaUDEM":
                        Global.Titular[item.Key] = nivel_exaUDEM;
                        break;

                    case "calle":
                        Global.Titular[item.Key] = calle;
                        break;

                    case "numero":
                        Global.Titular[item.Key] = numero;
                        break;

                    case "codigo_postal":
                        Global.Titular[item.Key] = codigo_postal;
                        break;

                    case "estado":
                        Global.Titular[item.Key] = estado;
                        break;

                    case "colonia":
                        Global.Titular[item.Key] = colonia;
                        break;

                    case "municipio":
                        Global.Titular[item.Key] = municipio;
                        break;

                    case "pais":
                        Global.Titular[item.Key] = pais;
                        break;
                }
            }
        }
        protected void Fill_Form_Titular()
        {
            if (Global.Titular != null)
            {
                foreach (var item in Global.Titular)
                {
                    switch (item.Key)
                    {
                        case "primer_nombre":
                            txtB_NombrePilaTitular.Text = (string)item.Value;
                            break;

                        case "segundo_nombre":
                            txtB_SeguNomTitular.Text = (string)item.Value;
                            break;

                        case "apellido_paterno":
                            txtB_ApePaterTitular.Text = (string)item.Value;
                            break;

                        case "apellido_materno":
                            txtB_ApeMaterTitular.Text = (string)item.Value;
                            break;

                        case "fecha_nacimiento":
                            DateTime fecha = DateTime.ParseExact((string)item.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            string fechaTxtB = fecha.ToString("yyyy-MM-dd");
                            txtB_FechaNacTitular.Text = fechaTxtB;
                            break;

                        case "celular":
                            txtB_movilTitular.Text = (string)item.Value;
                            break;

                        case "telefono_casa":
                            txtB_TelCasaTitular.Text = (string)item.Value;
                            break;

                        case "correo_electronico":
                            txtB_CorreoElecTitular.Enabled = false;
                            txtB_CorreoElecTitular.Text = (string)item.Value;
                            break;

                        case "titular_exaUDEM":
                            RadioBL_TitularExaudem.SelectedValue = (string)item.Value;
                            break;

                        case "calle":
                            txtB_Calle.Text = (string)item.Value;
                            break;

                        case "numero":
                            txtB_Numero.Text = (string)item.Value;
                            break;

                        case "codigo_postal":
                            txtB_CodigoPostal.Text = (string)item.Value;
                            try
                            {
                                int chknumber = Convert.ToInt32(txtB_CodigoPostal.Text);
                                ddl_colonia.Items.Clear();
                                txtB_Estado.Text = "";
                                Carga_CP();
                            }
                            catch (Exception)
                            {
                                txtB_CodigoPostal.Text = "";
                                txtB_CodigoPostal.Focus();
                            }
                            break;

                        case "colonia":
                            ListItem itemSeleccionado = ddl_colonia.Items.FindByText((string)item.Value);
                            if (itemSeleccionado != null)
                            {
                                itemSeleccionado.Selected = true;
                            }
                            break;
                    }
                }
            }
        }
        protected void Btn_EnviarTitularPrevi_Click(object sender, EventArgs e)
        {
            Page.Validate("VGTitular");
            if (Page.IsValid)
            {
                Btn_EnviarTitular.Enabled = false;
                Btn_EnviarTitular.Visible = false;
                Pnl_BoolVerificaTitular.Visible = true;
                RellenaFormTitular();
            }
        }
        protected void Btn_EnviarTitular_Click(object sender, EventArgs e)
        {
            WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
            DateTime splitfechaNacTitu1 = DateTime.Parse(txtB_FechaNacTitular.Text);
            string fechaNacTitu = splitfechaNacTitu1.ToString("dd/MM/yyyy");
            var result = wsic.InsContact(TxtB_Matricula_Titular.Text, txtB_NombrePilaTitular.Text, txtB_SeguNomTitular.Text, txtB_ApePaterTitular.Text, txtB_ApeMaterTitular.Text, "", fechaNacTitu, txtB_movilTitular.Text, txtB_TelCasaTitular.Text, "", txtB_CorreoElecTitular.Text, txtB_Calle.Text, txtB_Numero.Text, txtB_CodigoPostal.Text, ddl_colonia.SelectedItem.Text, txtB_Estado.Text, txtB_Municipio.Text, txtB_Pais.Text, "", "Sí", "Sí", "No", "No", "", "");

            string[] subSTitular = result.Guid.Split('|', ' ');
            Pnl_BoolVerificaTitular.Visible = false;

            var resultSol = wsInsSolCom.UpdtSolicitudCompra("", Global.GuidSolicitud, Global.GuidOportunidad, subSTitular[0], "", "", "", "", "", "", "", "", "", "", "");

            if (result.CodigoMs.Contains("correctamente") && resultSol.Mensaje.Contains("correctamente"))
            {
                List<string> nivelEgresoTitu = new List<string>();
                Fill_Titular(subSTitular[0], txtB_NombrePilaTitular.Text, txtB_SeguNomTitular.Text, txtB_ApePaterTitular.Text, txtB_ApeMaterTitular.Text, fechaNacTitu, txtB_movilTitular.Text, txtB_TelCasaTitular.Text, txtB_CorreoElecTitular.Text, RadioBL_TitularExaudem.Text, TxtB_Matricula_Titular.Text, nivelEgresoTitu, txtB_Calle.Text, txtB_Numero.Text, txtB_CodigoPostal.Text, txtB_Estado.Text, ddl_colonia.SelectedItem.Text, txtB_Municipio.Text, txtB_Pais.Text);
                Global.FasesSolicitud["titular"] = true;

                Lbl_AlertaPersonalizada.Text = result.CodigoMs + "<br />" + resultSol.Mensaje;
                string script = "<script type='text/javascript'>showAlert();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                ReiniciaFase_Btns();
                Btn_CheckTitu.CssClass = "check";
                Btn_CheckTitu.Enabled = true;
                pnl_Titular.Enabled = false;

                Pnl_ReciboFiscal.Visible = true;
                if (Global.BoolDatosFiscales.Equals(false))
                {
                    pnl_BoolReciboFiscal.Visible = true;
                }
                MuestraFase_Btns("datos_fiscales");

            }
            else
            {
                Lbl_AlertaPersonalizada.Text = result.CodigoMs;

                string script = "<script type='text/javascript'>showErrorAlert();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showErrorAlert", script);

                dv_phase_1Titu.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Titu.Attributes["class"] = "dv_phase_2_Warning";
            }
        }
        protected void Btn_BoolfalseVerificaTitular_Click(object sender, EventArgs e)
        {
            LimpiaFormTitular();
            Pnl_BoolVerificaTitular.Visible = false;
            pnl_Titular.Visible = true;
            Btn_EnviarTitular.Visible = true;
            Btn_EnviarTitular.Enabled = true;
        }
        protected void Btn_EditarTitular_Click(object sender, EventArgs e)
        {
            DesactivarSoloBotonesCheck();
            pnl_Titular.Enabled = true;
            Btn_EnviarTitular.Enabled = true;
            Btn_EnviarTitular.Visible = true;
            dv_Btn_EnviarTitular.Visible = true;
            Btn_EditarTitular.Enabled = false;
            dv_Btn_EditarTitular.Visible = false;
        }
        protected void LimpiaFormTitular()
        {
            txtB_PrimNomVerificaTitular.Text = string.Empty;
            txtB_SegunNomVerificaTitular.Text = string.Empty;
            txtB_AperPaterVerificaTitular.Text = string.Empty;
            txtB_AperMaterVerificaTitular.Text = string.Empty;
            txtB_FechaNacVerificaTitular.Text = string.Empty;
            txtB_MovilVerificaTitular.Text = string.Empty;
            txtB_TelCasaVerificaTitular.Text = string.Empty;
            txtB_CorreoElecVerificaTitular.Text = string.Empty;
            txtB_CalleVerificaTitular.Text = string.Empty;
            txtB_NumeroVerificaTitular.Text = string.Empty;
            txtB_CodigoPostalVerificaTitular.Text = string.Empty;
            txtB_EstadoVerificaTitular.Text = string.Empty;
            ddl_coloniaVerificaTitular.ClearSelection();
            ddl_coloniaVerificaTitular.Items.Clear();
            txtB_MunicipioVerificaTitular.Text = string.Empty;
            txtB_PaisVerificaTitular.Text = string.Empty;
        }
        protected void RellenaFormTitular()
        {
            txtB_PrimNomVerificaTitular.Text = txtB_NombrePilaTitular.Text;
            txtB_SegunNomVerificaTitular.Text = txtB_SeguNomTitular.Text;
            txtB_AperPaterVerificaTitular.Text = txtB_ApePaterTitular.Text;
            txtB_AperMaterVerificaTitular.Text = txtB_ApeMaterTitular.Text;
            string[] strsplitfechanac = txtB_FechaNacTitular.Text.Split('-');
            string splitfechanac = strsplitfechanac[2] + "/" + strsplitfechanac[1] + "/" + strsplitfechanac[0];
            txtB_FechaNacVerificaTitular.Text = splitfechanac;
            txtB_MovilVerificaTitular.Text = txtB_movilTitular.Text;
            txtB_TelCasaVerificaTitular.Text = txtB_TelCasaTitular.Text;
            txtB_CorreoElecVerificaTitular.Text = txtB_CorreoElecTitular.Text;
            RadioBL_VerificaTitularExaudem.SelectedIndex = RadioBL_TitularExaudem.SelectedIndex;
            txtB_CalleVerificaTitular.Text = txtB_Calle.Text;
            txtB_NumeroVerificaTitular.Text = txtB_Numero.Text;
            txtB_CodigoPostalVerificaTitular.Text = txtB_CodigoPostal.Text;
            txtB_EstadoVerificaTitular.Text = txtB_Estado.Text;
            ddl_coloniaVerificaTitular.Items.Add(ddl_colonia.SelectedItem.Text);
            txtB_MunicipioVerificaTitular.Text = txtB_Municipio.Text;
            txtB_PaisVerificaTitular.Text = txtB_Pais.Text;
        }
        protected void RadioBL_TitularExaudem_TextChanged(object sender, EventArgs e)
        {
            if (RadioBL_TitularExaudem.SelectedValue.Equals("True"))
            {
                td_Matricula_titular.Visible = true;
                td_NivelEgreso_titular.Visible = true;
            }
            else
            {
                td_Matricula_titular.Visible = false;
                td_NivelEgreso_titular.Visible = false;
            }
        }
        #endregion


        protected void FillStatusSolicitud()
        {
            if (SolicitudesCs.CurrentSolicitud != null)
            {
                string str_boolValue = (string)SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"];
                bool recibofiscal = bool.Parse(str_boolValue);

                if (SolicitudesCs.CurrentSolicitud["fases_solicitud"] is Dictionary<string, object> currSolicitud)
                {
                    var convertedDict = currSolicitud.ToDictionary(
               kvp => kvp.Key,
               kvp => (bool)kvp.Value
            );

                    Global.FasesSolicitud = convertedDict;
                    ReiniciaFase_Btns();
                }
                if (SolicitudesCs.CurrentSolicitud["titularDesignado"] != null)
                {
                    if (SolicitudesCs.CurrentSolicitud["titularDesignado"] is Dictionary<string, object> tituDesi)
                    {
                        string guidTituDesi = string.Empty;
                    }
                    //var titudesi = wsConContact.ConsultaContactGuid();
                }
            }
            else
            {
                Init_FasesSolicitud();
                Global.FasesSolicitud["titular"] = true;
            }
        }

        //Datos fiscales
        protected void Fill_DatosFiscales(string guid, string nombre, string razon_social, string rfc, string calle_numero, string codigo_postal, string estado, string colonia, string municipio, string pais)
        {
            for (int i = 0; i < Global.DatosFiscales.Count; i++)
            {
                var item = Global.DatosFiscales.ElementAt(i);

                switch (item.Key)
                {
                    case "guid_DatosFiscales":
                        if (guid.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = guid;
                        }
                        break;

                    case "nombre":
                        if (nombre.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = nombre;
                        }
                        break;

                    case "razon_social":
                        if (razon_social.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = razon_social;
                        }
                        break;

                    case "rfc":
                        if (rfc.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = rfc;
                        }
                        break;

                    case "calle_numero":
                        if (calle_numero.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = calle_numero;
                        }
                        break;

                    case "codigo_postal":
                        if (codigo_postal.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = codigo_postal;
                        }
                        break;

                    case "estado":
                        if (estado.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = estado;
                        }
                        break;

                    case "colonia":
                        if (colonia.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = colonia;
                        }
                        break;

                    case "municipio":
                        if (municipio.Length != 0)
                        {
                            Global.DatosFiscales[item.Key] = municipio;
                        }
                        break;

                    case "pais":
                        if (pais.Length != 0)
                        {
                            Global.Titular[item.Key] = pais;
                        }
                        break;
                }
            }
        }
        protected void Fill_Form_DatosFiscales()
        {
            if (Global.DatosFiscales != null)
            {
                foreach (var item in Global.DatosFiscales)
                {
                    switch (item.Key)
                    {
                        case "nombre":
                            txtB_NombreComercial.Text = (string)item.Value;
                            break;

                        case "razon_social":
                            txtB_RazonSocial.Text = (string)item.Value;
                            break;

                        case "rfc":
                            txtB_RFCReciboFiscal.Text = (string)item.Value;
                            break;

                        case "calle_numero":
                            txtB_CalleNumeroReciboFiscal.Text = (string)item.Value;
                            break;

                        case "codigo_postal":
                            txtB_CodigoPostalReciboFiscal.Text = (string)item.Value;
                            try
                            {
                                int chknumber = Convert.ToInt32(txtB_CodigoPostalReciboFiscal.Text);
                                Ddl_ColoniaReciboFiscal.Items.Clear();
                                txtB_EstadoReciboFiscal.Text = "";
                                Carga_CP_DireccionFiscal();
                            }
                            catch (Exception)
                            {
                                txtB_CodigoPostalReciboFiscal.Text = "";
                                txtB_CodigoPostalReciboFiscal.Focus();
                            }
                            break;
                    }
                }
            }
        }
        protected void Btn_VeriDatosFiscales_Click(object sender, EventArgs e)
        {
            Page.Validate("VGReciboFiscal");
            if (Page.IsValid)
            {
                Btn_EnviarDatosFiscales.Enabled = false;
                Btn_EnviarDatosFiscales.Visible = false;
                pnl_BoolVerificaInfoFiscal.Visible = true;
                RellenaFormInfoFiscal();
            }
        }
        protected void RellenaFormInfoFiscal()
        {
            txtB_NomComerVerificaDatFisc.Text = txtB_NombreComercial.Text;
            txtB_RazonSociVerificaDatFisc.Text = txtB_RazonSocial.Text;
            txtB_RFCVerificaDatFisc.Text = txtB_RFCReciboFiscal.Text;
            txtB_CalleNumeroVerificaDatFisc.Text = txtB_CalleNumeroReciboFiscal.Text;
            txtB_CodigoPostalVerificaDatFisc.Text = txtB_CodigoPostalReciboFiscal.Text;
            ddl_ColoniaVerificaDatFisc.Items.Add(Ddl_ColoniaReciboFiscal.SelectedItem.Text);
            txtB_EstadoVerificaDatFisc.Text = txtB_EstadoReciboFiscal.Text;
            txtB_MunicipioVerificaDatFisc.Text = txtB_Municipio.Text;
            txtB_PaisVerificaDatFisc.Text = txtB_PaisReciboFiscal.Text;
        }
        protected void btn_VerificaInfoFiscFalse_Click(object sender, EventArgs e)
        {
            LimpiaFormInfoFiscal();
            pnl_BoolVerificaInfoFiscal.Visible = false;
            Pnl_ReciboFiscal.Visible = true;
        }
        protected void Carga_CP_DireccionFiscal()
        {
            var pr = cp.Conscp(txtB_CodigoPostalReciboFiscal.Text);
            int ind = 0;
            ListItem i;
            Global.Arrcp = new string[pr.Count(), 9];
            Ddl_ColoniaReciboFiscal.Items.Clear();
            foreach (var dato in pr)
            {
                i = new ListItem(dato.recr_colonia, (ind + 1).ToString());
                Ddl_ColoniaReciboFiscal.Items.Add(i);
                Global.Arrcp[ind, 0] = dato.recr_name;
                Global.Arrcp[ind, 1] = dato.recr_colonia;
                Global.Arrcp[ind, 2] = dato.recr_alcaldiaomunicipio;
                Global.Arrcp[ind, 3] = dato.recr_estado;
                Global.Arrcp[ind, 4] = dato.recr_pais;
                Global.Arrcp[ind, 5] = dato.recr_asentamiento;
                Global.Arrcp[ind, 6] = dato.recr_zona;
                Global.Arrcp[ind, 7] = dato.mensajes;
                ind = ind + 1;
            }
            if (pr.Count() == 1)
            {
                Ddl_ColoniaReciboFiscal.SelectedItem.Text = Global.Arrcp[ind - 1, 1];
                txtB_EstadoReciboFiscal.Text = Global.Arrcp[ind - 1, 3];
                txtB_MunicipioReciboFiscal.Text = Global.Arrcp[ind - 1, 2];
                txtB_PaisReciboFiscal.Text = Global.Arrcp[ind - 1, 4];
            }
            else
            {
                Ddl_ColoniaReciboFiscal.Items.Insert(0, new ListItem("-- Seleccione Colonia --", "0"));
                txtB_EstadoReciboFiscal.Text = Global.Arrcp[ind - 1, 3];
                txtB_MunicipioReciboFiscal.Text = Global.Arrcp[ind - 1, 2];
                txtB_PaisReciboFiscal.Text = Global.Arrcp[ind - 1, 4];
            }
        }
        protected void LimpiaFormInfoFiscal()
        {
            txtB_NomComerVerificaDatFisc.Text = string.Empty;
            txtB_RazonSociVerificaDatFisc.Text = string.Empty;
            txtB_RFCVerificaDatFisc.Text = string.Empty;
            txtB_CalleNumeroVerificaDatFisc.Text = string.Empty;
            txtB_CodigoPostalVerificaDatFisc.Text = string.Empty;
            ddl_ColoniaVerificaDatFisc.ClearSelection();
            ddl_ColoniaVerificaDatFisc.Items.Clear();
            txtB_EstadoVerificaDatFisc.Text = string.Empty;
            txtB_MunicipioVerificaDatFisc.Text = string.Empty;
            txtB_PaisVerificaDatFisc.Text = string.Empty;
        }
        protected void Btn_Bool_TrueReciboFiscal_Click(object sender, EventArgs e)
        {
            SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"] = true;
            string guidContact = (string)Global.Titular["guid_titular"];
            var resultDatFisc = wsConsDatfisc.ConsDatosFiscales(guidContact);
            if (resultDatFisc[0].mensaje.Contains("Consulta Exitosa"))
            {
                Lbl_AlertaPersonalizada.Text = "¡Información encontrada! Te pedimos confirmar si los siguientes datos son correctos.";
                string script = "<script type='text/javascript'>showAlert();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                Init_Dict_DatosFiscales();
                if (resultDatFisc.Length > 0)
                {
                    Fill_DatosFiscales(resultDatFisc[0].new_datosfiscalesdecontactoid, resultDatFisc[0].new_name, resultDatFisc[0].new_razonsocial, resultDatFisc[0].new_rfc, resultDatFisc[0].new_direccionfiscalcalleynumero,
                        resultDatFisc[0].new_recr_codigopostal, resultDatFisc[0].new_direccionfiscalestado, resultDatFisc[0].new_direccionfiscalcolonia, resultDatFisc[0].new_direccionfiscalmunicipio, resultDatFisc[0].new_direccionfiscalpais);
                }
                Fill_Form_DatosFiscales();
            }
            Pnl_ReciboFiscal.Enabled = true;

            pnl_BoolReciboFiscal.Visible = false;
            dv_Btn_EnviarDatosFisc.Visible = true;
            Btn_EnviarDatosFiscales.Enabled = true;
            RBtnl_ReciboFiscalSoli.SelectedValue = "1";
            Global.BoolDatosFiscales = true;
        }
        protected void Btn_Bool_FalseReciboFiscal_Click(object sender, EventArgs e)
        {
            SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"] = true;
            pnl_BoolReciboFiscal.Visible = false;
            ReiniciaFase_Btns();
            Btn_CheckDatosFiscales.CssClass = "check";
            Btn_CheckDatosFiscales.Enabled = true;
            MuestraFase_Btns("titular_designado");
            Global.BoolDatosFiscales = false;
        }
        protected void TxtB_CodigoPostalReciboFiscal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int chknumber = Convert.ToInt32(txtB_CodigoPostalReciboFiscal.Text);
                Ddl_ColoniaReciboFiscal.Items.Clear();
                txtB_EstadoReciboFiscal.Text = "";
                Carga_CP_DireccionFiscal();
            }
            catch (Exception)
            {
                txtB_CodigoPostalReciboFiscal.Text = "";
                txtB_CodigoPostalReciboFiscal.Focus();
            }
        }
        protected void Btn_EnviarDatosFiscales_Click(object sender, EventArgs e)
        {
            Fill_DatosFiscales("", txtB_NombreComercial.Text, txtB_RazonSocial.Text, txtB_RFCReciboFiscal.Text, txtB_CalleNumeroReciboFiscal.Text, txtB_CodigoPostalReciboFiscal.Text, txtB_EstadoReciboFiscal.Text, Ddl_ColoniaReciboFiscal.SelectedItem.Text, txtB_MunicipioReciboFiscal.Text, txtB_PaisReciboFiscal.Text);

            WS_LE_ConsultaContac.WS_LE_ConsultaContac wsconContact = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
            var dats = wsconContact.ConsultaContactCorreo(Session["Usuario"].ToString(), "", "");

            WS_LE_InsertaDatosFiscalesContacto.WS_LE_InsertaDatosFiscalesContacto wsinsdfc = new WS_LE_InsertaDatosFiscalesContacto.WS_LE_InsertaDatosFiscalesContacto();
            var datsFisc = wsinsdfc.InsDatosFiscalesID(dats[0].contactid, "", txtB_NombreComercial.Text, txtB_RazonSocial.Text, txtB_RFCReciboFiscal.Text, txtB_PaisReciboFiscal.Text, txtB_EstadoReciboFiscal.Text, txtB_MunicipioReciboFiscal.Text, Ddl_ColoniaReciboFiscal.Text, txtB_CalleNumeroReciboFiscal.Text, "", txtB_CodigoPostalReciboFiscal.Text, "", "");

            var resultSol = wsInsSolCom.UpdtSolicitudCompra("", Global.GuidSolicitud, Global.GuidOportunidad, "", "", "", "", "Sí", datsFisc.Guid, "", "", "", "", "", "");

            pnl_BoolVerificaInfoFiscal.Visible = false;
            if (datsFisc.CodigoMs != null)
            {
                if (datsFisc.CodigoMs.Contains("correctamente") && resultSol.Mensaje.Contains("correctamente"))
                {
                    Global.GuidDatosFiscales = datsFisc.Guid.ToString();
                    Global.FasesSolicitud["datosfiscales"] = true;

                    Lbl_AlertaPersonalizada.Text = datsFisc.Mensaje + "<br />" + resultSol.Mensaje;
                    string script = "<script type='text/javascript'>showAlert();</script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                    ReiniciaFase_Btns();
                    Btn_CheckDatosFiscales.CssClass = "check";
                    Btn_CheckDatosFiscales.Enabled = true;
                    Pnl_ReciboFiscal.Enabled = false;

                    MuestraFase_Btns("titular_designado");
                }
                else
                {
                    dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_Warning";
                    dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_Warning";
                }
            }
        }
        protected void Btn_EditarDatosFisc_Click(object sender, EventArgs e)
        {
            DesactivarSoloBotonesCheck();
            Pnl_ReciboFiscal.Enabled = true;
            dv_Btn_EnviarDatosFisc.Visible = true;
            Btn_EnviarDatosFiscales.Visible = true;
            Btn_EnviarDatosFiscales.Enabled = true;
            Btn_EditarDatosFisc.Enabled = false;
            dv_Btn_EditarDatosFisc.Visible = false;
        }

        //Titular designado
        protected void Fill_TitularDesignado(string guid, string primer_nombre, string segundo_nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, string celular, string telefono_casa, string correo_electronico, string parentesco)
        {
            for (int i = 0; i < Global.Titular_Designado.Count; i++)
            {
                var item = Global.Titular_Designado.ElementAt(i);

                switch (item.Key)
                {
                    case "guid_titular_designado":
                        if (guid.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = guid;
                        }
                        break;

                    case "primer_nombre":
                        if (primer_nombre.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = primer_nombre;
                        }
                        break;

                    case "segundo_nombre":
                        if (segundo_nombre.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = segundo_nombre;
                        }
                        break;

                    case "apellido_paterno":
                        if (apellido_paterno.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = apellido_paterno;
                        }
                        break;

                    case "apellido_materno":
                        if (apellido_materno.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = apellido_materno;
                        }
                        break;

                    case "fecha_nacimiento":
                        if (fecha_nacimiento.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = fecha_nacimiento;
                        }
                        break;

                    case "celular":
                        if (celular.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = celular;
                        }
                        break;

                    case "telefono_casa":
                        if (telefono_casa.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = telefono_casa;
                        }
                        break;

                    case "correo_electronico":
                        if (correo_electronico.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = correo_electronico;
                        }
                        break;

                    case "parentesco":
                        if (parentesco.Length != 0)
                        {
                            Global.Titular_Designado[item.Key] = parentesco;
                        }
                        break;
                }
            }
        }
        protected void Fill_Form_TitularDesignado()
        {
            if (Global.Titular_Designado != null)
            {
                foreach (var item in Global.Titular_Designado)
                {
                    switch (item.Key)
                    {
                        case "primer_nombre":
                            txtB_PrimNomTituDesi.Text = item.Value;
                            break;

                        case "segundo_nombre":
                            txtB_SegunNomTituDesi.Text = item.Value;
                            break;

                        case "apellido_paterno":
                            txtB_ApePaterTituDesi.Text = item.Value;
                            break;

                        case "apellido_materno":
                            txtB_ApeMaterTituDesi.Text = item.Value;
                            break;

                        case "fecha_nacimiento":
                            DateTime fecha = DateTime.Parse(item.Value);
                            string fechaTxtB = fecha.ToString("yyyy-MM-dd");

                            txtB_FechaNacTituDesi.Text = fechaTxtB;
                            break;

                        case "celular":
                            txtB_MovilTituDesi.Text = item.Value;
                            break;

                        case "telefono_casa":
                            txtB_TelCasaTituDesi.Text = item.Value;
                            break;

                        case "correo_electronico":
                            txtB_CorreoElecTituDesi.Text = item.Value;
                            break;

                        case "parentesco":
                            ListItem itemSeleccionado = ddl_ParentescoTituDesi.Items.FindByText(item.Value);
                            if (itemSeleccionado != null)
                            {
                                itemSeleccionado.Selected = true;
                            }
                            break;
                    }
                }
            }

        }
        protected void Btn_EnviaTituDesi_Click(object sender, EventArgs e)
        {
            Page.Validate("VGTituDesi");
            if (Page.IsValid)
            {
                if (ConfirmaPrimNomTituDesi.Text != string.Empty)
                {
                    string msgeAlert = string.Empty;

                    string guidTitular = (string)Global.Titular["guid_titular"];

                    WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
                    DateTime splitfechaNacTituDesi = DateTime.Parse(txtB_FechaNacTituDesi.Text);
                    string fechaNacTituDesi = splitfechaNacTituDesi.ToString("dd/MM/yyyy");

                    var result = wsic.InsContact("", txtB_PrimNomTituDesi.Text, txtB_SegunNomTituDesi.Text, txtB_ApePaterTituDesi.Text, txtB_ApeMaterTituDesi.Text, "", fechaNacTituDesi, txtB_MovilTituDesi.Text, txtB_TelCasaTituDesi.Text, "", txtB_CorreoElecTituDesi.Text, "", "", "", "", "", "", "", "", "Sí", "No", "Sí", "No", "", "");
                    msgeAlert = result.CodigoMs;
                    string[] subSFamiliar = result.Guid.Split('|', ' ');

                    WS_LE_InsertaFamilia.WS_LE_InsertaFamilia wsifc = new WS_LE_InsertaFamilia.WS_LE_InsertaFamilia();
                    var fcdats = wsifc.InsFamiliar(txtB_PrimNomTituDesi.Text, txtB_SegunNomTituDesi.Text, txtB_ApePaterTituDesi.Text, txtB_ApeMaterTituDesi.Text, "No", guidTitular, subSFamiliar[0].ToString(), ddl_ParentescoTituDesi.SelectedItem.Text, "", "", txtB_MovilTituDesi.Text, txtB_CorreoElecTituDesi.Text, "", "", "", "", "", "");

                    var resultSol = wsInsSolCom.UpdtSolicitudCompra("", Global.GuidSolicitud, Global.GuidOportunidad, "", subSFamiliar[0], "", "", "", "", "", "", "", "", "", "");


                    if (result.CodigoMs.Contains("correctamente") && fcdats.CodigoMs.Contains("correctamente") && resultSol.Mensaje.Contains("correctamente"))
                    {
                        Fill_TitularDesignado(subSFamiliar[0], txtB_PrimNomTituDesi.Text, txtB_SegunNomTituDesi.Text, txtB_ApePaterTituDesi.Text, txtB_ApeMaterTituDesi.Text, txtB_FechaNacTituDesi.Text, txtB_MovilTituDesi.Text, txtB_TelCasaTituDesi.Text, txtB_CorreoElecTituDesi.Text, ddl_ParentescoTituDesi.SelectedItem.Text);
                        Global.FasesSolicitud["titular_designado"] = true;

                        Lbl_AlertaPersonalizada.Text = result.CodigoMs + "<br />" + fcdats.CodigoMs + "<br />" + resultSol.Mensaje;
                        string script = "<script type='text/javascript'>showAlert();</script>";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                        ReiniciaFase_Btns();
                        Btn_CheckTituDesi.CssClass = "check";
                        Btn_CheckTituDesi.Enabled = true;

                        Btn_EnviaTituDesi.Visible = false;
                        pnl_Cotizacion.Visible = true;
                        MuestraFase_Btns("cotizacion");

                        Pnl_TitularDesignado.Enabled = false;
                    }
                    else
                    {
                        Lbl_AlertaPersonalizada.Text = result.CodigoMs + "<br />" + fcdats.Mensaje;

                        string script = "<script type='text/javascript'>showErrorAlert();</script>";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "showErrorAlert", script);

                        dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1_Warning";
                        dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2_Warning";
                    }
                }
            }
        }
        protected void Btn_EditarTituDesi_Click(object sender, EventArgs e)
        {
            DesactivarSoloBotonesCheck();
            Pnl_TitularDesignado.Enabled = true;
            Btn_EnviaTituDesi.Enabled = true;
            dv_Btn_EnviarTituDesi.Visible = true;
            Btn_EditarTituDesi.Enabled = false;
            dv_Btn_EditarTituDesi.Visible = false;
        }


        //Cotización
        protected void Fill_Form_Cotizacion(int index)
        {
            Dictionary<string, object> cotizacion = Global.List_Cotizaciones[index];
            ListItem itemSeleccionado;
            double monto;
            if (cotizacion != null)
            {
                switch ((string)cotizacion["nivel"])
                {
                    #region Bachillerato
                    case "Bachillerato":
                        //Nivel
                        Ddl_NivelAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_NivelAplicarLE.Items.FindByText((string)cotizacion["nivel"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //unidad
                        CargaUniDiviProg((string)cotizacion["nivel"]);
                        Ddl_UniDiviProgAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_UniDiviProgAplicarLE.Items.FindByText((string)cotizacion["unidad"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //tipo_bachillerato
                        Ddl_TipoBachProgProf.ClearSelection();
                        itemSeleccionado = Ddl_TipoBachProgProf.Items.FindByText((string)cotizacion["tipo_bachillerato"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //FormularioConfirmacion

                        Verifica_lbl_Total.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total02.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total03.Text = (string)cotizacion["monto"];
                        Verifica_ProgramaAplicarLE.Text = Ddl_UniDiviProgAplicarLE.Text;
                        Verifica_CreditosAplicarLE.Text = "8";
                        break;
                    #endregion

                    #region Profesional
                    case "Profesional":
                        //Nivel
                        Ddl_NivelAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_NivelAplicarLE.Items.FindByText((string)cotizacion["nivel"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //division
                        CargaUniDiviProg((string)cotizacion["nivel"]);
                        Ddl_UniDiviProgAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_UniDiviProgAplicarLE.Items.FindByText((string)cotizacion["division"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //programa
                        CargaTipoBachProgProfCred((string)cotizacion["nivel"]);
                        Ddl_TipoBachProgProf.ClearSelection();
                        itemSeleccionado = Ddl_TipoBachProgProf.Items.FindByText((string)cotizacion["programa"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //Creditos
                        Ddl_CreditosAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_CreditosAplicarLE.Items.FindByText((string)cotizacion["creditos"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //FormularioConfirmacion
                        Verifica_lbl_Total.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total02.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total03.Text = (string)cotizacion["monto"];
                        Verifica_ProgramaAplicarLE.Text = Ddl_TipoBachProgProf.Text;
                        Verifica_CreditosAplicarLE.Text = (string)cotizacion["creditos"];
                        break;
                    #endregion

                    #region Posgrado
                    case "Posgrado":
                        //Nivel
                        Ddl_NivelAplicarLE.ClearSelection();
                        itemSeleccionado = Ddl_NivelAplicarLE.Items.FindByText((string)cotizacion["nivel"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //programa
                        Ddl_TipoBachProgProf.ClearSelection();
                        itemSeleccionado = Ddl_TipoBachProgProf.Items.FindByText((string)cotizacion["programa"]);
                        if (itemSeleccionado != null)
                        {
                            itemSeleccionado.Selected = true;
                        }
                        //FormularioConfirmacion
                        Verifica_lbl_Total.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total02.Text = (string)cotizacion["monto"];
                        Verifica_lbl_Total03.Text = (string)cotizacion["monto"];
                        Verifica_ProgramaAplicarLE.Text = Ddl_UniDiviProgAplicarLE.Text;
                        Verifica_CreditosAplicarLE.Text = (string)cotizacion["creditos"];
                        break;
                        #endregion
                }
            }
        }
        protected void LimpiaFormCotizacion()
        {
            Ddl_NivelAplicarLE.ClearSelection();
            Ddl_UniDiviProgAplicarLE.ClearSelection();
            Ddl_CreditosAplicarLE.ClearSelection();
            Ddl_TipoBachProgProf.ClearSelection();

            Lbl_UniDiviProgAplicarLE.Text = string.Empty;

            Pnl_UniDiviProgAplicarLE.Visible = false;
            Pnl_Creditos.Visible = false;
            Pnl_TipoBachProgProf.Visible = false;
        }
        protected void LoadGridViewCotizacion()
        {
            Container_GridV_Cotizacion.Visible = true;

            DataTable dtcotizaciones = new DataTable();
            dtcotizaciones.Columns.Add("Nivel", typeof(string));
            dtcotizaciones.Columns.Add("DiviUnidad", typeof(string));
            dtcotizaciones.Columns.Add("ProgTipBach", typeof(string));
            dtcotizaciones.Columns.Add("Créditos", typeof(string));
            dtcotizaciones.Columns.Add("Monto", typeof(string));

            foreach (var List_Cotizaciones in Global.List_Cotizaciones)
            {
                DataRow fila = dtcotizaciones.NewRow();

                fila["Nivel"] = List_Cotizaciones["nivel"];
                if (((string)List_Cotizaciones["nivel"]).Equals("Bachillerato"))
                {
                    fila["DiviUnidad"] = List_Cotizaciones["unidad"];
                    fila["ProgTipBach"] = List_Cotizaciones["tipo_bachillerato"];
                }
                else
                {
                    fila["DiviUnidad"] = List_Cotizaciones["division"];
                    fila["ProgTipBach"] = List_Cotizaciones["programa"];
                }
                fila["Créditos"] = List_Cotizaciones["creditos"];
                fila["Monto"] = List_Cotizaciones["monto"];


                dtcotizaciones.Rows.Add(fila);
            }
            GridV_Cotizacion.DataSource = dtcotizaciones;
            GridV_Cotizacion.DataBind();
        }
        protected void Fill_Cotizacion(string numero_cotizacion, string guid_cotizacion, string nivel, string unidad, string tipo_bachillerato, string creditos,
           string monto, string division, string programa)
        {
            Init_Dict_Cotizacion(nivel);
            string moneda = " MXN";
            switch (nivel)
            {
                case "Bachillerato":
                    if (numero_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["numero_cotizacion"] = numero_cotizacion;
                    }
                    if (guid_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["guid_cotizacion"] = guid_cotizacion;
                    }
                    if (nivel.Length != 0)
                    {
                        Global.Cotizacion["nivel"] = nivel;
                    }
                    if (unidad.Length != 0)
                    {
                        Global.Cotizacion["unidad"] = unidad;
                    }
                    if (tipo_bachillerato.Length != 0)
                    {
                        Global.Cotizacion["tipo_bachillerato"] = tipo_bachillerato;
                    }
                    if (creditos.Length != 0)
                    {
                        double strcreditos = double.Parse(creditos);
                        string formattedcreditos = strcreditos.ToString();
                        Global.Cotizacion["creditos"] = formattedcreditos;
                    }
                    if (monto.Length != 0)
                    {
                        if (monto.Contains("MXN"))
                        {
                            Global.Cotizacion["monto"] = monto;
                        }
                        else
                        {
                            double strMonto = double.Parse(monto);
                            string formattedMonto = strMonto.ToString("C") + moneda;
                            Global.Cotizacion["monto"] = formattedMonto;
                        }
                    }
                    break;

                case "Profesional":
                    if (numero_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["numero_cotizacion"] = numero_cotizacion;
                    }
                    if (guid_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["guid_cotizacion"] = guid_cotizacion;
                    }
                    if (nivel.Length != 0)
                    {
                        Global.Cotizacion["nivel"] = nivel;
                    }
                    if (division.Length != 0)
                    {
                        Global.Cotizacion["division"] = division;
                    }
                    if (programa.Length != 0)
                    {
                        Global.Cotizacion["programa"] = programa;
                    }
                    if (creditos.Length != 0)
                    {
                        double strcreditos = double.Parse(creditos);
                        string formattedcreditos = strcreditos.ToString();
                        Global.Cotizacion["creditos"] = formattedcreditos;
                    }
                    if (monto.Length != 0)
                    {
                        if (monto.Contains("MXN"))
                        {
                            Global.Cotizacion["monto"] = monto;
                        }
                        else
                        {
                            double strMonto = double.Parse(monto);
                            string formattedMonto = strMonto.ToString("C") + moneda;
                            Global.Cotizacion["monto"] = formattedMonto;
                        }
                    }
                    break;

                case "Posgrado":
                    if (numero_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["numero_cotizacion"] = numero_cotizacion;
                    }
                    if (guid_cotizacion.Length != 0)
                    {
                        Global.Cotizacion["guid_cotizacion"] = guid_cotizacion;
                    }
                    if (nivel.Length != 0)
                    {
                        Global.Cotizacion["nivel"] = nivel;
                    }
                    if (programa.Length != 0)
                    {
                        Global.Cotizacion["programa"] = programa;
                    }
                    if (creditos.Length != 0)
                    {
                        double strcreditos = double.Parse(creditos);
                        string formattedcreditos = strcreditos.ToString();
                        Global.Cotizacion["creditos"] = formattedcreditos;
                    }
                    if (monto.Length != 0)
                    {
                        if (monto.Contains("MXN"))
                        {
                            Global.Cotizacion["monto"] = monto;
                        }
                        else
                        {
                            double strMonto = double.Parse(monto);
                            string formattedMonto = strMonto.ToString("C") + moneda;
                            Global.Cotizacion["monto"] = formattedMonto;
                        }
                    }
                    break;
            }
        }
        protected void GridV_Cotizacion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit_Cotizacion"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                ActualizaCotizacion.Actualiza = true;
                ActualizaCotizacion.Index = index;

                Pnl_boolCompra.Visible = true;
                Pnl_boolCompra.Enabled = true;
                pnl_Cotizacion.Visible = true;
                pnl_Cotizacion.Enabled = true;
                Container_GridV_Cotizacion.Visible = false;
                Fill_Form_Cotizacion(index);
            }

        }
        protected void Btn_NuevaCotizacion_Click(object sender, EventArgs e)
        {
            ActualizaCotizacion.Actualiza = false;
            LimpiaFormCotizacion();
            pnl_Cotizacion.Visible = true;
            pnl_Cotizacion.Enabled = true;
            Container_GridV_Cotizacion.Visible = false;
        }
        protected void Btn__Bool_trueCotizacionExtra_Click(object sender, EventArgs e)
        {
            LimpiaFormCotizacion();
            Ddl_NivelAplicarLE.ClearSelection();
            pnl_BoolCotizacionExtra.Visible = false;
            Pnl_boolCompra.Visible = false;
        }
        protected void Btn__Bool_falseCotizacionExtra_Click(object sender, EventArgs e)
        {
            pnl_BoolCotizacionExtra.Visible = false;
            MuestraFase_Btns("beneficiario");
        }
        protected void Btn_CrearCotizacion_Click(object sender, EventArgs e)
        {
            Page.Validate("VGCompra");
            if (Page.IsValid && ChBox_AvisoDePrivacidad.Checked.Equals(true))
            {
                Lbl_AvisoDePrivacidad.Text = string.Empty;
                double montototal;
                string moneda = " MXN";
                int listaPrecios = Global.List_ListaDePrecios.Count();
                Init_Dict_Cotizacion(Ddl_NivelAplicarLE.SelectedItem.Text);

                int index;
                switch (Ddl_NivelAplicarLE.Text)
                {
                    case "Bachillerato":
                        foreach (var lista in Global.List_ListaDePrecios)
                        {
                            if (lista["product_name"].Equals(Ddl_TipoBachProgProf.SelectedItem.Text))
                            {
                                foreach (var programa in Global.List_ProgramasBach)
                                {
                                    if (programa["new_programa"].ToString().Contains(Ddl_TipoBachProgProf.SelectedItem.Text))
                                    {
                                        double.TryParse(lista["amount"].ToString(), out double monto);
                                        double.TryParse(Ddl_CreditosAplicarLE.Text, out double cantidad);
                                        double monto_total = monto * cantidad;

                                        Verifica_lbl_Total.Text = monto_total.ToString("C") + moneda;
                                        Verifica_lbl_Total02.Text = monto_total.ToString("C") + moneda;
                                        Verifica_lbl_Total03.Text = monto_total.ToString("C") + moneda;
                                        Verifica_ProgramaAplicarLE.Text = Ddl_UniDiviProgAplicarLE.Text;
                                        Verifica_CreditosAplicarLE.Text = Ddl_CreditosAplicarLE.Text;
                                        Llb_Verifica_CreditosSemestres.Text = "Semestres";

                                        DeterminaCotizacionCrm((string)programa["new_programa"], "", (string)programa["udem_semestresporprograma"], (string)programa["udem_productorelacionado_name"], (string)lista["uom_name"], (string)programa["udem_tipodeperiodo"],
                                        "Periodos", Ddl_CreditosAplicarLE.Text, "", "", Ddl_CreditosAplicarLE.Text, (string)lista["amount"], monto_total.ToString(), Ddl_UniDiviProgAplicarLE.SelectedItem.Value);
                                    }
                                }
                            }
                        }
                        break;

                    case "Profesional":
                        foreach (var programa in Global.List_ProgramasProf)
                        {
                            if (programa["new_programa"].Equals(Ddl_TipoBachProgProf.SelectedItem.Text))
                            {

                                foreach (var lista in Global.List_ListaDePrecios)
                                {
                                    if (lista["product_name"].Equals(programa["udem_productorelacionado_name"]))
                                    {
                                        string _temp = Ddl_CreditosAplicarLE.Text;
                                        int.TryParse(_temp, out int creditos);

                                        double.TryParse(lista["amount"].ToString(), out double monto);
                                        montototal = monto * creditos;
                                        string _montototal = montototal.ToString("C");
                                        Verifica_lbl_Total.Text = _montototal + moneda;
                                        Verifica_lbl_Total02.Text = _montototal + moneda;
                                        Verifica_lbl_Total03.Text = _montototal + moneda;
                                        Verifica_ProgramaAplicarLE.Text = Ddl_TipoBachProgProf.Text;
                                        Verifica_CreditosAplicarLE.Text = creditos.ToString();
                                        Llb_Verifica_CreditosSemestres.Text = "Créditos";
                                        string[] _montototal_ = _montototal.Split('$', ',', '.');
                                        string __montototal_ = _montototal_[1] + _montototal_[2];
                                        DeterminaCotizacionCrm((string)programa["new_programa"], (string)programa["udem_creditosporprograma"], (string)programa["udem_semestresporprograma"], (string)programa["udem_productorelacionado_name"], (string)lista["uom_name"], (string)programa["udem_tipodeperiodo"],
                                        "Créditos", Ddl_CreditosAplicarLE.SelectedItem.Text, "0", Ddl_CreditosAplicarLE.SelectedItem.Text, Ddl_CreditosAplicarLE.SelectedItem.Text, (string)lista["amount"], __montototal_, "");
                                    }
                                }
                            }

                        }
                        break;

                    case "Posgrado":
                        foreach (var programa in Global.List_ProgramasPosg)
                        {
                            if (programa["new_programa"].Equals(Ddl_UniDiviProgAplicarLE.SelectedItem.Text))
                            {
                                index = Global.List_ProgramasPosg.IndexOf(programa);

                                foreach (var lista in Global.List_ListaDePrecios)
                                {
                                    if (lista["product_name"].Equals(programa["udem_productorelacionado_name"]))
                                    {
                                        string _temp = Ddl_CreditosAplicarLE.Text;
                                        int.TryParse(_temp, out int creditos);

                                        double.TryParse(lista["amount"].ToString(), out double monto);
                                        montototal = monto * creditos;
                                        Verifica_lbl_Total.Text = montototal.ToString("C") + moneda;
                                        Verifica_lbl_Total02.Text = montototal.ToString("C") + moneda;
                                        Verifica_lbl_Total03.Text = montototal.ToString("C") + moneda;
                                        Verifica_ProgramaAplicarLE.Text = Ddl_TipoBachProgProf.Text;
                                        Verifica_CreditosAplicarLE.Text = creditos.ToString();
                                        Llb_Verifica_CreditosSemestres.Text = "Créditos";

                                        DeterminaCotizacionCrm((string)programa["new_programa"], (string)programa["udem_creditosporprograma"], (string)programa["udem_semestresporprograma"], (string)programa["udem_productorelacionado_name"], (string)lista["uom_name"], "",
                                        "Programa Completo", Verifica_CreditosAplicarLE.Text, "", "", Verifica_CreditosAplicarLE.Text, (string)lista["amount"], monto.ToString(), "");
                                    }
                                }
                            }

                        }
                        break;
                }
                Pnl_boolCompra.Visible = true;
                Pnl_boolCompra.Enabled = true;
            }
            else
            {
                if (ChBox_AvisoDePrivacidad.Checked.Equals(true))
                {
                    Lbl_AvisoDePrivacidad.Text = string.Empty;
                }
                else
                {
                    Lbl_AvisoDePrivacidad.Text = "Es necesario aceptar el aviso de privacidad para continuar";
                }
            }
        }
        public class CotizacionCrm
        {
            public static string udem_programaacademico { get; set; }
            public static string udem_le_creditosporproducto { get; set; }
            public static string udem_le_semestresporproducto { get; set; }
            public static string productid { get; set; }
            public static string uomid { get; set; }
            public static string udem_tipodeperiodo { get; set; }
            public static string udem_unidadacotizar { get; set; }
            public static string udem_cantidadacotizar { get; set; }
            public static string udem_le_porcentajebeca { get; set; }
            public static string udem_le_semestrestotales { get; set; }
            public static string quantity { get; set; }
            public static string priceperunit { get; set; }
            public static string baseamount { get; set; }
            public static string new_unidadudem { get; set; }
            public CotizacionCrm()
            {
                udem_programaacademico = string.Empty;
                udem_le_creditosporproducto = string.Empty;
                udem_le_semestresporproducto = string.Empty;
                productid = string.Empty;
                uomid = string.Empty;
                udem_tipodeperiodo = string.Empty;
                udem_unidadacotizar = string.Empty;
                udem_cantidadacotizar = string.Empty;
                udem_le_porcentajebeca = string.Empty;
                udem_le_semestrestotales = string.Empty;
                quantity = string.Empty;
                priceperunit = string.Empty;
                baseamount = string.Empty;
                new_unidadudem = string.Empty;
            }
        }
        protected void DeterminaCotizacionCrm(string udem_programaacademico, string udem_le_creditosporproducto, string udem_le_semestresporproducto, string productid, string uomid, string udem_tipodeperiodo,
            string udem_unidadacotizar, string udem_cantidadacotizar, string udem_le_porcentajebeca, string udem_le_semestrestotales, string quantity, string priceperunit, string baseamount, string new_unidadudem)
        {
            CotizacionCrm cotizacionCrm = new CotizacionCrm();

            CotizacionCrm.udem_programaacademico = udem_programaacademico;
            CotizacionCrm.udem_le_creditosporproducto = udem_le_creditosporproducto;
            CotizacionCrm.udem_le_semestresporproducto = udem_le_semestresporproducto;
            CotizacionCrm.productid = productid;
            CotizacionCrm.uomid = uomid;
            CotizacionCrm.udem_tipodeperiodo = udem_tipodeperiodo;
            CotizacionCrm.udem_unidadacotizar = udem_unidadacotizar;
            CotizacionCrm.udem_cantidadacotizar = udem_cantidadacotizar;
            CotizacionCrm.udem_le_porcentajebeca = udem_le_porcentajebeca;
            CotizacionCrm.udem_le_semestrestotales = udem_le_semestrestotales;
            CotizacionCrm.quantity = quantity;
            CotizacionCrm.priceperunit = priceperunit;
            CotizacionCrm.baseamount = baseamount;
            CotizacionCrm.new_unidadudem = new_unidadudem;
        }

        protected void InsertaCotizacionCRM()
        {
            Init_Dict_Cotizacion(Ddl_NivelAplicarLE.SelectedItem.Text);
            string strTemp = string.Empty;
            strTemp = "Cotización obtenida desde landing page";

            DateTime fechaActualSF = DateTime.Now;
            string fechaActual = fechaActualSF.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string NombreContactoTitular = Global.Titular["primer_nombre"] + " " + Global.Titular["segundo_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"]; ;
            var resultHeadCoti = wsInsCoti.InsCotizacionHead(guid_ListaPrecio_LE, Global.GuidOportunidad, strTemp, Global.GuidSolicitud, "LE - " + NombreContactoTitular + " - " + fechaActual);

            if (resultHeadCoti.Mensaje.Contains("correctamente"))
            {
                var resultProdCoti = wsInsCoti.InsCotizacionProdu(resultHeadCoti.Guid, CotizacionCrm.udem_programaacademico, CotizacionCrm.udem_le_creditosporproducto, CotizacionCrm.udem_le_semestresporproducto, CotizacionCrm.productid,
                CotizacionCrm.uomid, CotizacionCrm.udem_tipodeperiodo, CotizacionCrm.udem_unidadacotizar, CotizacionCrm.udem_cantidadacotizar, CotizacionCrm.udem_le_porcentajebeca, CotizacionCrm.udem_le_semestrestotales,
                CotizacionCrm.quantity, CotizacionCrm.priceperunit, CotizacionCrm.baseamount, CotizacionCrm.new_unidadudem);
                if (resultProdCoti.Mensaje.Contains("correctamente"))
                {
                    Lbl_AlertaPersonalizada.Text = resultProdCoti.Mensaje;
                    string script = "<script type='text/javascript'>showAlert();</script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                    switch (Ddl_NivelAplicarLE.SelectedItem.Text)
                    {
                        case "Bachillerato":
                            Fill_Cotizacion("", resultProdCoti.Guid, Ddl_NivelAplicarLE.SelectedItem.Text, Ddl_UniDiviProgAplicarLE.SelectedItem.Text, Ddl_TipoBachProgProf.SelectedItem.Text, Verifica_CreditosAplicarLE.Text,
                            Verifica_lbl_Total.Text, "", "");
                            Global.List_Cotizaciones.Add(Global.Cotizacion);
                            break;

                        case "Profesional":
                            Fill_Cotizacion("", resultProdCoti.Guid, Ddl_NivelAplicarLE.SelectedItem.Text, "", "", Verifica_CreditosAplicarLE.Text,
                            Verifica_lbl_Total.Text, Ddl_UniDiviProgAplicarLE.SelectedItem.Text, Ddl_TipoBachProgProf.SelectedItem.Text);
                            Global.List_Cotizaciones.Add(Global.Cotizacion);
                            break;

                        case "Posgrado":
                            Fill_Cotizacion("", resultProdCoti.Guid, Ddl_NivelAplicarLE.SelectedItem.Text, "", "", Verifica_CreditosAplicarLE.Text,
                            Verifica_lbl_Total.Text, "", Ddl_UniDiviProgAplicarLE.SelectedItem.Text);
                            Global.List_Cotizaciones.Add(Global.Cotizacion);
                            break;
                    }
                }
            }

            Global.FasesSolicitud["cotizacion"] = true;

            ReiniciaFase_Btns();
            Btn_CheckCotizacion.CssClass = "check";
            Btn_CheckCotizacion.Enabled = true;

            dv_phase_1Cotizacion.Attributes["class"] = "dv_phase_1_Check";
            dv_phase_2Cotizacion.Attributes["class"] = "dv_phase_2_Check";
            Btn_CheckCotizacion.CssClass = "check";
            Btn_CheckCotizacion.Enabled = true;

            pnl_BoolCotizacionExtra.Visible = true;

            InteraccionMenu.cantidadDeCotizaciones++;
        }
        protected void ActualizaCotizacionCRM()
        {
            int index = ActualizaCotizacion.Index;
            Dictionary<string, object> cotiActual = Global.List_Cotizaciones[index];
            string guid = (string)cotiActual["guid_cotizacion"];
            switch (Ddl_NivelAplicarLE.SelectedItem.Text)
            {
                case "Bachillerato":
                    Fill_Cotizacion("", guid, Ddl_NivelAplicarLE.SelectedItem.Text, Ddl_UniDiviProgAplicarLE.SelectedItem.Text, Ddl_TipoBachProgProf.SelectedItem.Text, Verifica_CreditosAplicarLE.Text,
                    Verifica_lbl_Total.Text, "", "");
                    break;

                case "Profesional":
                    Fill_Cotizacion("", guid, Ddl_NivelAplicarLE.SelectedItem.Text, "", "", Verifica_CreditosAplicarLE.Text,
                    Verifica_lbl_Total.Text, Ddl_UniDiviProgAplicarLE.SelectedItem.Text, Ddl_TipoBachProgProf.SelectedItem.Text);
                    Global.List_Cotizaciones[index] = Global.Cotizacion;
                    break;

                case "Posgrado":
                    Fill_Cotizacion("", guid, Ddl_NivelAplicarLE.SelectedItem.Text, "", "", Verifica_CreditosAplicarLE.Text,
                    Verifica_lbl_Total.Text, "", Ddl_UniDiviProgAplicarLE.SelectedItem.Text);
                    Global.List_Cotizaciones[index] = Global.Cotizacion;
                    break;
            }

            var resultProdCoti = wsInsCoti.InsCotizacionProdu(guid, CotizacionCrm.udem_programaacademico, CotizacionCrm.udem_le_creditosporproducto, CotizacionCrm.udem_le_semestresporproducto, CotizacionCrm.productid,
            CotizacionCrm.uomid, CotizacionCrm.udem_tipodeperiodo, CotizacionCrm.udem_unidadacotizar, CotizacionCrm.udem_cantidadacotizar, CotizacionCrm.udem_le_porcentajebeca, CotizacionCrm.udem_le_semestrestotales,
            CotizacionCrm.quantity, CotizacionCrm.priceperunit, CotizacionCrm.baseamount, CotizacionCrm.new_unidadudem);

            if (resultProdCoti.Mensaje.Contains("correctamente"))
            {
                Lbl_AlertaPersonalizada.Text = resultProdCoti.Mensaje;
                string script = "<script type='text/javascript'>showAlert();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);
            }


            Global.FasesSolicitud["cotizacion"] = true;
            ReiniciaFase_Btns();
            Btn_CheckCotizacion.CssClass = "check";
            Btn_CheckCotizacion.Enabled = true;
            dv_phase_1Cotizacion.Attributes["class"] = "dv_phase_1_Check";
            dv_phase_2Cotizacion.Attributes["class"] = "dv_phase_2_Check";
            Btn_CheckCotizacion.CssClass = "check";
            Btn_CheckCotizacion.Enabled = true;

            MuestraFase_Btns("cotizacion");
        }

        protected void Btn_boolTrueCompra_Click(object sender, EventArgs e)
        {

            if (ActualizaCotizacion.Actualiza)
            {
                ActualizaCotizacionCRM();
            }
            else
            {
                InsertaCotizacionCRM();
            }

        }
        protected void Btn_boolFalseCompra_Click(object sender, EventArgs e)
        {
            Pnl_boolCompra.Visible = false;
        }

        protected void Ddl_NivelAplicarLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pnl_UniDiviProgAplicarLE.Visible = false;
            Pnl_Creditos.Visible = false;
            Pnl_TipoBachProgProf.Visible = false;

            CargaUniDiviProg(Ddl_NivelAplicarLE.Text);
        }
        protected void CargaUniDiviProg(string nivel)
        {
            switch (nivel)
            {
                case "Bachillerato":
                    Pnl_UniDiviProgAplicarLE.Visible = true;
                    Lbl_UniDiviProgAplicarLE.Text = "Unidad de interés *";
                    Ddl_UniDiviProgAplicarLE.Items.Clear();
                    Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem("-----Seleccionar unidad-----", "0"));
                    foreach (var item in Global.List_UnidadesBach)
                    {
                        Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem((string)item["new_name"]));
                    }
                    break;

                case "Profesional":
                    Pnl_UniDiviProgAplicarLE.Visible = true;
                    Lbl_UniDiviProgAplicarLE.Text = "División de interés *";
                    Ddl_UniDiviProgAplicarLE.Items.Clear();
                    Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem("-----Seleccionar división-----", "0"));
                    foreach (var item in Global.List_ProgramasProf)
                    {
                        Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem((string)item["new_division_name"]));
                    }
                    break;

                case "Posgrado":
                    Pnl_UniDiviProgAplicarLE.Visible = true;
                    Lbl_UniDiviProgAplicarLE.Text = "Programa de interés *";
                    Ddl_UniDiviProgAplicarLE.Items.Clear();
                    Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem("-----Seleccionar programa-----", "0"));
                    foreach (var item in Global.List_ProgramasPosg)
                    {
                        Ddl_UniDiviProgAplicarLE.Items.Add(new ListItem((string)item["new_programa"]));
                    }
                    break;
            }
        }
        protected void Ddl_UniDiviProgAplicarLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pnl_TipoBachProgProf.Visible = false;
            Pnl_Creditos.Visible = false;

            CargaTipoBachProgProfCred(Ddl_NivelAplicarLE.Text);
        }
        protected void CargaTipoBachProgProfCred(string nivel)
        {
            switch (nivel)
            {
                case "Bachillerato":
                    Pnl_TipoBachProgProf.Visible = true;
                    Ddl_TipoBachProgProf.Items.Clear();

                    Lbl_TipoBachProgProfAplicarLE.Text = "Tipo de bachillerato *";
                    Ddl_TipoBachProgProf.Items.Clear();
                    Ddl_TipoBachProgProf.Items.Add(new ListItem("-----Seleccionar-----", "0"));

                    if (Ddl_UniDiviProgAplicarLE.Text.Equals("Unidad Obispado"))
                    {
                        Ddl_TipoBachProgProf.Items.Add(new ListItem("Bachillerato Bicultural"));
                    }
                    else
                    {
                        Ddl_TipoBachProgProf.Items.Add(new ListItem("Bachillerato Multicultural"));
                        Ddl_TipoBachProgProf.Items.Add(new ListItem("Bachillerato Bicultural"));
                        Ddl_TipoBachProgProf.Items.Add(new ListItem("Bachillerato Internacional"));
                    }
                    break;

                case "Profesional":
                    Pnl_TipoBachProgProf.Visible = true;
                    Lbl_TipoBachProgProfAplicarLE.Text = "Programa de interés *";
                    Ddl_TipoBachProgProf.Items.Clear();
                    Ddl_TipoBachProgProf.Items.Add(new ListItem("-----Seleccionar programa-----", "0"));

                    foreach (var item in Global.List_ProgramasProf)
                    {
                        if (item["new_division_name"].Equals(Ddl_UniDiviProgAplicarLE.Text))
                        {
                            Ddl_TipoBachProgProf.Items.Add(new ListItem((string)item["new_programa"]));
                        }
                    }


                    break;

                case "Posgrado":
                    Pnl_Creditos.Visible = true;
                    Ddl_CreditosAplicarLE.Items.Clear();
                    foreach (var item in Global.List_ProgramasPosg)
                    {
                        if (item["new_programa"].Equals(Ddl_UniDiviProgAplicarLE.Text))
                        {
                            if (item["udem_creditosporprograma"] == null)
                            {
                                Ddl_CreditosAplicarLE.Items.Add(new ListItem("No se encontro un valor"));
                            }
                            else
                            {
                                int creditos = int.Parse((string)item["udem_creditosporprograma"]);
                                for (int i = 6; i <= creditos; i++)
                                {
                                    Ddl_CreditosAplicarLE.Items.Add(new ListItem(i.ToString()));
                                }
                            }
                        }
                    }

                    break;
            }
        }
        protected void Ddl_TipoBachProgProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Ddl_NivelAplicarLE.Text)
            {
                case "Bachillerato":
                    Lbl_CreditosPeriodos.Text = "Semestres a comprar *";
                    Pnl_Creditos.Visible = true;
                    Ddl_CreditosAplicarLE.Items.Clear();
                    foreach (var item in Global.List_ProgramasBach)
                    {
                        if (item["new_programa"].Equals(Ddl_TipoBachProgProf.Text))
                        {
                            if (item["udem_semestresporprograma"] == null)
                            {
                                Ddl_CreditosAplicarLE.Items.Add(new ListItem("No se encontro un valor"));
                            }
                            else
                            {
                                int creditos = int.Parse((string)item["udem_semestresporprograma"]);
                                for (int i = 1; i <= creditos; i++)
                                {
                                    Ddl_CreditosAplicarLE.Items.Add(new ListItem(i.ToString()));
                                }
                            }
                        }
                    }
                    break;
                case "Profesional":
                    Lbl_CreditosPeriodos.Text = "Créditos a comprar *";
                    Pnl_Creditos.Visible = true;
                    Ddl_CreditosAplicarLE.Items.Clear();
                    foreach (var item in Global.List_ProgramasProf)
                    {
                        if (item["new_programa"].Equals(Ddl_TipoBachProgProf.Text))
                        {
                            if (item["udem_creditosporprograma"] == null)
                            {
                                Ddl_CreditosAplicarLE.Items.Add(new ListItem("No se encontro un valor"));
                            }
                            else
                            {
                                int creditos = int.Parse((string)item["udem_creditosporprograma"]);
                                for (int i = 6; i <= creditos; i++)
                                {
                                    Ddl_CreditosAplicarLE.Items.Add(new ListItem(i.ToString()));
                                }
                            }
                        }
                    }
                    break;
            }
        }

        //Beneficiario
        protected void Fill_Beneficiario(string numBeneficiario, string guid, string primer_nombre, string segundo_nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, string celular, string parentesco, string correo_electronico, string beca, string nivel_estudio, string escuela_procedencia, string carrera_NoUDEM, string grado_beca, string porcentaje_beca)
        {
            Init_Dict_Beneficiario();
            for (int i = 0; i < Global.Beneficiario.Count; i++)
            {
                var item = Global.Beneficiario.ElementAt(i);
                switch (item.Key)
                {
                    case "numero_beneficiario":
                        if (numBeneficiario != null && numBeneficiario.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = numBeneficiario;
                        }
                        break;

                    case "guid_beneficiario":
                        if (guid != null && guid.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = guid;
                        }
                        break;

                    case "primer_nombre":
                        if (primer_nombre != null && primer_nombre.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = primer_nombre;
                        }
                        break;

                    case "segundo_nombre":
                        if (segundo_nombre != null && segundo_nombre.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = segundo_nombre;
                        }
                        break;

                    case "apellido_paterno":
                        if (apellido_paterno != null && apellido_paterno.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = apellido_paterno;
                        }
                        break;

                    case "apellido_materno":
                        if (apellido_materno != null && apellido_materno.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = apellido_materno;
                        }
                        break;

                    case "fecha_nacimiento":
                        if (fecha_nacimiento != null && fecha_nacimiento.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = fecha_nacimiento;
                        }
                        break;

                    case "celular":
                        if (celular != null && celular.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = celular;
                        }
                        break;

                    case "correo_electronico":
                        if (correo_electronico != null && correo_electronico.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = correo_electronico;
                        }
                        break;

                    case "parentesco":
                        if (parentesco != null && parentesco.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = parentesco;
                        }
                        break;

                    case "beca":
                        if (beca != null && beca.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = beca;
                        }
                        break;

                    case "nivel_estudio":
                        if (nivel_estudio != null && nivel_estudio.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = nivel_estudio;
                        }
                        break;

                    case "escuela_procedencia":
                        if (escuela_procedencia != null && escuela_procedencia.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = escuela_procedencia;
                        }
                        break;

                    case "carrera_NoUDEM":
                        if (carrera_NoUDEM != null && carrera_NoUDEM.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = carrera_NoUDEM;
                        }
                        break;

                    case "grado_beca":
                        if (grado_beca != null && grado_beca.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = grado_beca;
                        }
                        break;

                    case "porcentaje_beca":
                        if (porcentaje_beca != null && porcentaje_beca.Length != 0)
                        {
                            Global.Beneficiario[item.Key] = porcentaje_beca;
                        }
                        break;
                }
            }
        }
        protected void Fill_Form_Beneficiario(int index)
        {
            Dictionary<string, string> beneficiario = Global.List_Beneficiarios[index];
            if (beneficiario != null)
            {
                foreach (var item in beneficiario)
                {
                    ListItem itemSeleccionado;

                    switch (item.Key)
                    {
                        case "primer_nombre":
                            txtB_PrimNomBenefi.Text = item.Value;
                            break;

                        case "segundo_nombre":
                            txtB_SegunNomBenefi.Text = item.Value;
                            break;

                        case "apellido_paterno":
                            txtB_AperPaterBenefi.Text = item.Value;
                            break;

                        case "apellido_materno":
                            txtB_AperMaterBenefi.Text = item.Value;
                            break;

                        case "fecha_nacimiento":
                            DateTime fecha = DateTime.Parse(item.Value);
                            string fechaTxtB = fecha.ToString("yyyy-MM-dd");
                            txtB_FechaNacBenefi.Text = fechaTxtB;
                            break;

                        case "celular":
                            txtB_MovilBenefi.Text = item.Value;
                            break;

                        case "correo_electronico":
                            txtB_CorreoElecBenefi.Text = item.Value;
                            break;

                        case "parentesco":
                            ddl_ParentescoBenefi.ClearSelection();
                            itemSeleccionado = ddl_ParentescoBenefi.Items.FindByText(item.Value);
                            if (itemSeleccionado != null)
                            {
                                itemSeleccionado.Selected = true;
                            }
                            break;

                        //case "beca":
                        //    rbl_BecaBenefi.Text = item.Value;
                        //    break;

                        case "nivel_estudio":
                            ddl_NivelProcede.ClearSelection();
                            itemSeleccionado = ddl_NivelProcede.Items.FindByText(item.Value);
                            if (itemSeleccionado != null)
                            {
                                itemSeleccionado.Selected = true;
                            }
                            CargaNivelBenefi(item.Value);
                            break;

                        case "escuela_procedencia":
                            ddl_NombreInstiProce.ClearSelection();
                            foreach (ListItem listItem in ddl_NombreInstiProce.Items)
                            {
                                if (listItem.Text.Contains(item.Value))
                                {
                                    listItem.Selected = true;
                                    break;
                                }
                            }
                            break;

                        case "porcentaje_beca":
                            if (item.Value.Equals("Sí"))
                            {
                                rbl_BecaBenefi.Text = "Sí";
                                txtB_PorcentBecaBenefi.Text = item.Value;
                            }
                            else
                            {
                                rbl_BecaBenefi.Text = "No";
                            }
                            break;
                    }
                }
            }

        }
        protected Dictionary<string, string> Dict_Benefi_Capturado()
        {
            DateTime splitfechaNacBenefi = DateTime.Parse(txtB_FechaNacBenefi.Text);
            string fechaNacBenefi = splitfechaNacBenefi.ToString("dd/MM/yyyy");
            Dictionary<string, string> beneficiarioCapurado = new Dictionary<string, string>
                {
                { "numero_beneficiario", string.Empty},
                { "guid_beneficiario", string.Empty},
                { "primer_nombre", txtB_PrimNomBenefi.Text},
                { "segundo_nombre", txtB_SegunNomBenefi.Text},
                { "apellido_paterno", txtB_AperPaterBenefi.Text},
                { "apellido_materno", txtB_AperMaterBenefi.Text},
                { "fecha_nacimiento", fechaNacBenefi},
                { "celular", txtB_MovilBenefi.Text},
                { "correo_electronico", txtB_CorreoElecBenefi.Text},
                { "parentesco", ddl_ParentescoBenefi.Text},
                { "beca", rbl_BecaBenefi.Text},
                { "nivel_estudio", ddl_NivelProcede.SelectedItem.Text},
                { "escuela_procedencia", ddl_NombreInstiProce.SelectedItem.Text},
                { "carrera_NoUDEM", string.Empty},
                { "grado_beca", string.Empty},
                { "porcentaje_beca", txtB_PorcentBecaBenefi.Text},
                };
            return beneficiarioCapurado;
        }
        protected void Ddl_NivelProcede_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nivel = ddl_NivelProcede.SelectedItem.Text;
            CargaNivelBenefi(nivel);
        }
        protected void Ddl_NombreInstiProce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (ddl_NombreInstiProce.SelectedItem.Text.Contains("No se encuentra en la lista"))
            //    {

            //        ConfirmatxtBNombreInstiProce.Enabled = true;
            //        ConfirmatxtBNombreInstiProce.Visible = true;
            //        ConfirmaNombreInstiProce.Enabled = false;
            //        ConfirmaNombreInstiProce.Visible = false;
            //        txtB_NombreInstiProce.Visible = true;
            //        ddl_NombreInstiProce.Visible = false;
            //    }
            //    ddl_EstadoInstiProce.Items.Clear();

            //    if (ddl_NombreInstiProce.SelectedIndex > 0)
            //    {
            //        if (!ddl_NombreInstiProce.SelectedItem.Text.Contains("No se encuentra en la lista"))
            //        {
            //            ConfirmatxtBNombreInstiProce.Enabled = false;
            //            ConfirmatxtBNombreInstiProce.Visible = false;

            //            int opt = Convert.ToInt32(ddl_NombreInstiProce.SelectedIndex) - 1;
            //            if (Global.Arresccue[opt, 1] != null)
            //            {
            //                ListItem ii = new ListItem(Global.Arresccue[opt, 1]);
            //                ddl_EstadoInstiProce.Items.Add(ii);
            //            }
            //        }
            //    }
        }
        protected void InsertaBeneficiario()
        {
            string guidTitular = (string)Global.Titular["guid_titular"];

            WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
            DateTime splitfechaNacBenefi = DateTime.Parse(txtB_FechaNacBenefi.Text);
            string fechaNacBenefi = splitfechaNacBenefi.ToString("dd/MM/yyyy");
            var result = wsic.InsContact("", txtB_PrimNomBenefi.Text, txtB_SegunNomBenefi.Text, txtB_AperPaterBenefi.Text, txtB_AperMaterBenefi.Text, "", fechaNacBenefi, txtB_MovilBenefi.Text, "", "", txtB_CorreoElecBenefi.Text, "", "", "", "", "", "", "", "", "Sí", "No", "No", "Si", "", "");

            string[] subSFamiliar = result.Guid.Split('|', ' ');

            WS_LE_InsertaFamilia.WS_LE_InsertaFamilia wsifc = new WS_LE_InsertaFamilia.WS_LE_InsertaFamilia();
            var fcdats = wsifc.InsFamiliar(txtB_PrimNomBenefi.Text, txtB_SegunNomBenefi.Text, txtB_AperPaterBenefi.Text, txtB_AperMaterBenefi.Text, "", guidTitular, subSFamiliar[0].ToString(), ddl_ParentescoBenefi.SelectedItem.Text, "", "", txtB_MovilBenefi.Text, txtB_CorreoElecBenefi.Text, "", "", "", "", "", "");

            string[] subSNombreInsti = ddl_NombreInstiProce.SelectedItem.Text.Split('[', ']');
            string NombreInsti = subSNombreInsti[0];
            var resultSol = wsInsBenefi.InsBeneficiario(Global.GuidSolicitud, subSFamiliar[0], ddl_NivelProcede.SelectedItem.Text, NombreInsti, "", "", txtB_PorcentBecaBenefi.Text);

            if (result.CodigoMs.Contains("correctamente") && resultSol.Mensaje.Contains("correctamente"))
            {
                Fill_Beneficiario(Global.NumBeneficiarios.ToString(), subSFamiliar[0].ToString(), txtB_PrimNomBenefi.Text, txtB_SegunNomBenefi.Text, txtB_AperPaterBenefi.Text,
                    txtB_AperMaterBenefi.Text, fechaNacBenefi, txtB_MovilBenefi.Text, ddl_ParentescoBenefi.SelectedItem.Text, txtB_CorreoElecBenefi.Text, rbl_BecaBenefi.Text,
                    ddl_NivelProcede.SelectedItem.Text, ddl_NombreInstiProce.SelectedItem.Text, "", "", txtB_PorcentBecaBenefi.Text);

                int indice = -1;
                foreach (var beneficiarios in Global.List_Beneficiarios)
                {
                    if (indice == -1)
                    {
                        if (beneficiarios["correo_electronico"].Equals(Global.Beneficiario["correo_electronico"]))
                        {
                            indice = Global.List_Beneficiarios.IndexOf(beneficiarios);
                        }
                    }
                    else
                    {
                        break;
                    }
                }


                if (indice >= 0)
                {
                    Global.List_Beneficiarios[indice] = Global.Beneficiario;

                    Lbl_AlertaPersonalizada.Text = "El beneficiario se actualizo correctamente.";
                    string script = "<script type='text/javascript'>showAlert();</script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);
                }
                else
                {
                    Global.NumBeneficiarios++;
                    Global.Beneficiario["numero_beneficiario"] = Global.NumBeneficiarios.ToString();
                    Global.List_Beneficiarios.Add(Global.Beneficiario);

                    Lbl_AlertaPersonalizada.Text = "El beneficiario se inserto correctamente.";
                    string script = "<script type='text/javascript'>showAlert();</script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);
                }

                Global.FasesSolicitud["beneficiario"] = true;


                ReiniciaFase_Btns();
                Btn_CheckBenefi.CssClass = "check";
                Btn_CheckBenefi.Enabled = true;

                Pnl_Beneficiario.Enabled = false;
                pnl_BoolBeneficiarioExtra.Visible = true;
            }
            else
            {
                Lbl_AlertaPersonalizada.Text = result.CodigoMs + "<br />" + fcdats.CodigoMs + "<br />";

                string script = "<script type='text/javascript'>showErrorAlert();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showErrorAlert", script);

                dv_phase_1Benefi.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Benefi.Attributes["class"] = "dv_phase_2_Warning";
            }
        }
        protected void Btn_EnviaBeneficiario_Click(object sender, EventArgs e)
        {
            Page.Validate("VGBeneficiario");
            if (Page.IsValid)
            {
                if (PosibleDuplicado.Actualiza)
                {
                    InsertaBeneficiario();
                }
                else
                {
                    Dictionary<string, string> beneficiarioCapturado = Dict_Benefi_Capturado();
                    if (Global.List_Beneficiarios != null)
                    {
                        foreach (Dictionary<string, string> beneficiario in Global.List_Beneficiarios)
                        {
                            if (!PosibleDuplicado.Duplicado)
                            {
                                CompararDiccionarios(beneficiario, beneficiarioCapturado);
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (PosibleDuplicado.CorreoIgual || PosibleDuplicado.PorPorcentaje)
                        {
                            if (PosibleDuplicado.CorreoIgual)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert",
                                "alert('El correo capturado coincide con el de un beneficiario ya existente en esta solicitud. En consecuencia, su información será actualizada.');", true);
                            }
                            else if (PosibleDuplicado.PorPorcentaje)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert",
                                "alert('La información coincide un " + PosibleDuplicado.Coincidencia + "& con el de un beneficiario ya existente en esta solicitud. ¿Desea Insertar esta información en un beneficiario nuevo?');", true);
                            }
                        }
                        else if (!PosibleDuplicado.CorreoIgual && !PosibleDuplicado.PorPorcentaje)
                        {
                            InsertaBeneficiario();
                        }
                    }
                    else
                    {
                        InsertaBeneficiario();
                    }
                }
            }
        }
        protected void LimpiaFormBenefi()
        {
            txtB_PrimNomBenefi.Text = string.Empty;
            txtB_SegunNomBenefi.Text = string.Empty;
            txtB_AperPaterBenefi.Text = string.Empty;
            txtB_AperMaterBenefi.Text = string.Empty;
            txtB_FechaNacBenefi.Text = string.Empty;
            txtB_MovilBenefi.Text = string.Empty;
            txtB_CorreoElecBenefi.Text = string.Empty;
            txtB_NombreInstiProce.Text = string.Empty;
            rbl_BecaBenefi.ClearSelection();
            ddl_ParentescoBenefi.ClearSelection();
            ddl_NivelProcede.ClearSelection();
            ddl_NombreInstiProce.ClearSelection();
            ddl_NombreInstiProce.Items.Clear();
            ddl_EstadoInstiProce.ClearSelection();
            ddl_EstadoInstiProce.Items.Clear();
        }
        protected void Btn__Bool_trueBeneficiarioExtra_Click(object sender, EventArgs e)
        {
            LimpiaFormBenefi();
            Pnl_Beneficiario.Visible = true;
            Pnl_Beneficiario.Enabled = true;
            pnl_BoolBeneficiarioExtra.Visible = false;
            MuestraFase_Btns("Beneficiario");
        }
        protected void Btn__Bool_falseBeneficiarioExtra_Click(object sender, EventArgs e)
        {
            pnl_BoolBeneficiarioExtra.Visible = false;
            MuestraFase_Btns("confirmacion");
        }
        protected void Btn_NuevoBeneficiario_Click(object sender, EventArgs e)
        {
            PosibleDuplicado.Actualiza = false;
            LimpiaFormBenefi();
            Pnl_Beneficiario.Visible = true;
            Pnl_Beneficiario.Enabled = true;
            Container_GridV_Beneficiario.Visible = false;
        }
        protected void LoadGridViewBeneficiario()
        {
            DataTable dtBeneficiarios = new DataTable();
            dtBeneficiarios.Columns.Add("num", typeof(int));
            dtBeneficiarios.Columns.Add("Beneficiario", typeof(string));

            foreach (var List_Beneficiarios in Global.List_Beneficiarios)
            {
                DataRow fila = dtBeneficiarios.NewRow();

                foreach (var Beneficiario in List_Beneficiarios)
                {
                    switch (Beneficiario.Key)
                    {
                        case "numero_beneficiario":
                            fila["num"] = Beneficiario.Value;
                            break;

                        case "primer_nombre":
                            fila["Beneficiario"] += Beneficiario.Value + " ";
                            break;

                        case "segundo_nombre":
                            fila["Beneficiario"] += Beneficiario.Value + " ";
                            break;

                        case "apellido_paterno":
                            fila["Beneficiario"] += Beneficiario.Value + " ";
                            break;

                        case "apellido_materno":
                            fila["Beneficiario"] += Beneficiario.Value;
                            break;
                    }
                }
                dtBeneficiarios.Rows.Add(fila);
            }
            dtBeneficiarios.DefaultView.Sort = "num ASC";

            Container_GridV_Beneficiario.Visible = true;
            GridV_Beneficiario.DataSource = dtBeneficiarios;
            GridV_Beneficiario.DataBind();
        }
        protected void CargaNivelBenefi(string nivel)
        {
            ddl_NombreInstiProce.Items.Clear();
            switch (nivel)
            {
                case "Primaria":
                    if (Global.Escuelas["primaria"] is List<string> primaria)
                    {
                        int ind = 0;
                        ListItem i;

                        ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));
                        foreach (var dato in primaria)
                        {
                            i = new ListItem(dato, ind + 1.ToString());
                            ddl_NombreInstiProce.Items.Add(i);
                            ind = ind + 1;
                        }
                    }
                    break;

                case "Secundaria":
                    if (Global.Escuelas["secundaria"] is List<string> secundaria)
                    {
                        int ind = 0;
                        ListItem i;

                        ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));
                        foreach (var dato in secundaria)
                        {
                            i = new ListItem(dato, ind + 1.ToString());
                            ddl_NombreInstiProce.Items.Add(i);
                            ind = ind + 1;
                        }
                    }
                    break;

                case "Bachillerato":
                    if (Global.Escuelas["bachillerato"] is List<string> bachillerato)
                    {
                        int ind = 0;
                        ListItem i;

                        ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));
                        foreach (var dato in bachillerato)
                        {
                            i = new ListItem(dato, ind + 1.ToString());
                            ddl_NombreInstiProce.Items.Add(i);
                            ind = ind + 1;
                        }
                    }
                    break;

                case "Profesional":
                    if (Global.Escuelas["profesional"] is List<string> profesional)
                    {
                        int ind = 0;
                        ListItem i;

                        ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));
                        foreach (var dato in profesional)
                        {
                            i = new ListItem(dato, ind + 1.ToString());
                            ddl_NombreInstiProce.Items.Add(i);
                            ind = ind + 1;
                        }
                    }
                    break;

                case "Posgrado":
                    if (Global.Escuelas["posgrado"] is List<string> posgrado)
                    {
                        int ind = 0;
                        ListItem i;

                        ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));
                        foreach (var dato in posgrado)
                        {
                            i = new ListItem(dato, ind + 1.ToString());
                            ddl_NombreInstiProce.Items.Add(i);
                            ind = ind + 1;
                        }
                    }
                    break;
            }
        }

        public static void CompararDiccionarios<TKey, TValue>(Dictionary<TKey, TValue> dictionary1, Dictionary<TKey, TValue> dictionary2)
        {
            int cantiDatos = 0;
            const int datosComparables = 11;

            foreach (var dic1 in dictionary1)
            {
                if (!dic1.Key.ToString().Equals("numero_beneficiario") && !dic1.Key.ToString().Equals("guid_beneficiario") &&
                    !dic1.Key.ToString().Equals("carrera_NoUDEM") && !dic1.Key.ToString().Equals("grado_beca") && !dic1.Key.ToString().Equals("beca"))
                {
                    if (dic1.Key.Equals("correo_electronico"))
                    {
                        if (dic1.Value.Equals(dictionary2[dic1.Key]))
                        {
                            PosibleDuplicado.CorreoIgual = true;
                            PosibleDuplicado.Duplicado = true;
                            break;
                        }
                        else
                        {
                            PosibleDuplicado.CorreoIgual = false;
                            PosibleDuplicado.Duplicado = false;
                        }
                    }
                    if (dic1.Value.Equals(dictionary2[dic1.Key]))
                    {
                        cantiDatos++;

                        int porcentaje = (cantiDatos * 100) / datosComparables;
                        PosibleDuplicado.Coincidencia = porcentaje;
                        if (porcentaje < 80)
                        {
                            PosibleDuplicado.PorPorcentaje = false;
                            PosibleDuplicado.Duplicado = false;
                        }
                        else
                        {
                            PosibleDuplicado.PorPorcentaje = true;
                            PosibleDuplicado.Duplicado = true;
                            break;
                        }
                    }
                }

            }
        }
        async Task Obtener_Escuelas()
        {
            Global.Escuelas = new Dictionary<string, List<string>>
            {
                { "primaria", new List<string>()},
                { "secundaria", new List<string>()},
                { "bachillerato", new List<string>()},
                { "profesional", new List<string>()},
                { "posgrado", new List<string>()},
            };

            Stopwatch crono = new Stopwatch();
            crono.Start();
            await Escuelas_BachilleratoAsync();
            await Escuelas_ProfesionalAsync();
            await Escuelas_PosgradoAsync();
            crono.Stop();
        }
        async protected Task Escuelas_BachilleratoAsync()
        {
            List<string> bachillerato = new List<string>();
            var escuela = await Task.Run(() => wsConsEscCue.ConsEscuela("Profesional"));
            foreach (var item in escuela)
            {
                bachillerato.Add(item.name + "     [" + item.address1_stateorprovince + "]");
            }
            Global.Escuelas["bachillerato"] = bachillerato;
        }
        async protected Task Escuelas_ProfesionalAsync()
        {
            List<string> profesional = new List<string>();
            var escuela = await Task.Run(() => wsConsEscCue.ConsEscuela("Posgrado"));
            foreach (var item in escuela)
            {
                profesional.Add(item.name);
            }
            Global.Escuelas["profesional"] = profesional;
        }
        async protected Task Escuelas_PosgradoAsync()
        {
            List<string> posgrado = new List<string>();
            var escuela = await Task.Run(() => wsConsEscCue.ConsEscuela("Doctorado"));
            foreach (var item in escuela)
            {
                posgrado.Add(item.name);
            }
            Global.Escuelas["posgrado"] = posgrado;
        }

        //Confirmación
        protected void Fill_Confirmacion()
        {

        }
        public void Logout(string mensaje, string url)
        {
            if (mensaje != null && url != null)
            {
                Session.Abandon();
                string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
            }
            else
            {
                mensaje = "Se ha cerrado sesion";
                url = "WebLE02InicioCreaCuenta.aspx";
                Session.Abandon();
                string script = "alert('" + mensaje + "'); window.location.replace('" + url + "');";
                ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
            }
        }
        protected void Carga_CP()
        {
            var pr = cp.Conscp(txtB_CodigoPostal.Text);
            int ind = 0;
            ListItem i;
            Global.Arrcp = new string[pr.Count(), 9];
            ddl_colonia.Items.Clear();
            foreach (var dato in pr)
            {
                i = new ListItem(dato.recr_colonia, (ind + 1).ToString());
                ddl_colonia.Items.Add(i);
                Global.Arrcp[ind, 0] = dato.recr_name;
                Global.Arrcp[ind, 1] = dato.recr_colonia;
                Global.Arrcp[ind, 2] = dato.recr_alcaldiaomunicipio;
                Global.Arrcp[ind, 3] = dato.recr_estado;
                Global.Arrcp[ind, 4] = dato.recr_pais;
                Global.Arrcp[ind, 5] = dato.recr_asentamiento;
                Global.Arrcp[ind, 6] = dato.recr_zona;
                Global.Arrcp[ind, 7] = dato.mensajes;
                ind = ind + 1;
            }
            if (pr.Count() == 1)
            {
                ddl_colonia.Items.Insert(1, new ListItem(Global.Arrcp[ind - 1, 1], "1"));
                txtB_Estado.Text = Global.Arrcp[ind - 1, 3];
                txtB_Municipio.Text = Global.Arrcp[ind - 1, 2];
                txtB_Pais.Text = Global.Arrcp[ind - 1, 4];
            }
            else
            {
                ddl_colonia.Items.Insert(0, new ListItem("-- Seleccione Colonia --", "0"));
                txtB_Estado.Text = Global.Arrcp[ind - 1, 3];
                txtB_Municipio.Text = Global.Arrcp[ind - 1, 2];
                txtB_Pais.Text = Global.Arrcp[ind - 1, 4];
            }
        }
        protected void TxtB_CP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int chknumber = Convert.ToInt32(txtB_CodigoPostal.Text);
                ddl_colonia.Items.Clear();
                txtB_Estado.Text = "";
                Carga_CP();
            }
            catch (Exception)
            {
                txtB_CodigoPostal.Text = "";
                txtB_CodigoPostal.Focus();
            }
        }
        protected void Btn_LeerAvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = true;
        }
        protected void Btn_AvisoDePrivacidad_Click(object sender, EventArgs e)
        {
            pnl_AvisoPrivacidad.Visible = false;
        }
        protected void Btn_EnviarSoliCompra_Click(object sender, EventArgs e)
        {
            Page.Validate("VGConfirmaSolicitud");
            if (Page.IsValid && chb_UsoDeDatos.Checked.Equals(true))
            {
                DateTime fechahoy = DateTime.Now;
                string _fechahoy = fechahoy.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                var asdf = wsInsSolCom.UpdtSolicitudCompra("", Global.GuidSolicitud, Global.GuidOportunidad, "", "", "", "", "", "", "", "Sí", "Sí", "Sí", "Sí", "");

                if (asdf.Mensaje.Contains("correctamente"))
                {
                    Global.FasesSolicitud["confirmacion"] = true;
                }

                bool terminada = false;
                foreach (var item in Global.FasesSolicitud)
                {
                    switch (item.Key)
                    {
                        case "titular":
                            if (item.Value)
                            {
                                terminada = true;
                            }
                            break;

                        case "datosfiscales":
                            if (SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"].ToString().Equals("True"))
                            {
                                if (item.Value)
                                {
                                    terminada = true;
                                }
                            }
                            else
                            {
                                terminada = true;
                            }
                            break;

                        case "titular_designado":
                            if (item.Value)
                            {
                                terminada = true;
                            }
                            break;

                        case "cotizacion":
                            if (item.Value)
                            {
                                terminada = true;
                            }
                            break;

                        case "beneficiario":
                            if (item.Value)
                            {
                                terminada = true;
                            }
                            break;

                        case "confirmacion":
                            if (item.Value)
                            {
                                terminada = true;
                            }
                            break;
                    }
                }
                TerminaSolicitud(terminada);

                pnl_Confirmacion.Visible = false;
                Pnl_CreacionSolicitud.Visible = true;
                Pnl_btn_Home.Visible = true;
                Btn_Home.Visible = true;

                if (Ddl_FormaPagoSoli.SelectedItem.ToString().Contains("Tarjeta"))
                {
                    Pnl_FichaDePago.Visible = false;
                    Pnl_MetodoDePago.Visible = true;
                }
                else if (Ddl_FormaPagoSoli.SelectedItem.ToString().Contains("Ficha"))
                {
                    Pnl_FichaDePago.Visible = true;
                    Pnl_MetodoDePago.Visible = false;
                }
            }
            else
            {
                if (chb_UsoDeDatos.Checked.Equals(true))
                {
                    Lbl_AcepteUsoDeDatos.Text = string.Empty;
                }
                else
                {
                    Lbl_AcepteUsoDeDatos.Text = "Es necesario aceptar el acuerdo de recursos lícitos para continuar.";
                }
            }
        }
        protected void TerminaSolicitud(bool terminada)
        {
            if (terminada)
            {
                ReiniciaFase_Btns();
                DesactivarSoloBotonesCheck();

                dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_Check";
                dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_Check";

                lbl_CreacioSolicitud.Text = "¡Tu solicitud se completo correctamente! ✔";
                lbl_CreacioSolicitud.ForeColor = Color.Green;
            }
            else
            {
                dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_Warning";
                lbl_CreacioSolicitud.Text = "¡Tu solicitud esta incompleta! ❌";
                lbl_CreacioSolicitud.ForeColor = Color.Red;

                ReiniciaFase_Btns();
                DesactivarSoloBotonesCheck();
            }
        }

        protected void Btn_GenerarFicha_Click(object sender, EventArgs e)
        {
            Global.ArchivoFichaDePago = new string[2];
            string depto, cc, fechaproceso, importe;
            string matricula = LlamadoApisMatricula();
            Global.Matricula = matricula;
            //string matricula = "123456789";
            string _import = lbl_MontoConfirmacion.Text;
            string[] _montototal_ = _import.Split('$', ',', '.');
            string __montototal_ = _montototal_[1] + _montototal_[2];
            importe = __montototal_;

            depto = "LEGA";
            cc = "0000";

            DateTime fechaActual = DateTime.Now.AddDays(5);
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");
            fechaproceso = fechaFormateada;
            string archivoRuta = LlamaGeneraFicha(matricula, depto, cc, fechaproceso, importe);
            string[] splitarchivoRuta = archivoRuta.Split('|');
            Global.ArchivoFichaDePago[0] = splitarchivoRuta[0];
            Global.ArchivoFichaDePago[1] = splitarchivoRuta[1];

            LlamaGeneraFicha(matricula, depto, cc, fechaproceso, importe);

            Btn_GenerarFicha.Visible = false;
            Btn_DescargarFicha.Visible = true;

        }
        static string LlamadoApisMatricula()
        {
            string matricula = string.Empty;
            string apiLoginUrl = "https://brim365tst.udem.edu.mx/api/Authentication/login";
            string token = string.Empty;

            var requestBody = new { CorreoElectronico = "sergio.parrav", Password = "123456" };
            string requestBodyJson = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiLoginUrl);
                    request.Content = new StringContent(requestBodyJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = httpClient.SendAsync(request).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        token = response.Content.ReadAsStringAsync().Result;
                        string[] _token = token.Split('/', '"');
                        token = _token[3];
                    }
                    else
                    {
                        Console.WriteLine("Error en la llamada al Web API. Código de estado: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Error en la llamada al Web API. Error: " + ex);
                }
            }

            if (token != string.Empty)
            {
                string recr_correo = Global.Titular["correo_electronico"].ToString();
                string apiCreateUrl = "https://brim365tst.udem.edu.mx/api/Migration/migrate/createperson";
                string bearerToken = token;
                var jsonData = "[{ \"recr_correo\":\"" + recr_correo + "\", \"recr_direccion\":\"DIDE\"}]";
                // Crear el objeto HttpClient
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var request = new HttpRequestMessage(HttpMethod.Post, apiCreateUrl)
                        {
                            Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
                        };
                        HttpResponseMessage response = httpClient.SendAsync(request).Result;
                        string respuestaJson = response.Content.ReadAsStringAsync().Result;

                        WebSolicitudCompraLE instanciaClase = new WebSolicitudCompraLE();
                        matricula = instanciaClase.ObtenerValoresJson(respuestaJson);
                        return matricula;
                    }
                    catch (HttpRequestException ex)
                    {
                        // Manejo de errores
                        Console.WriteLine("Error al realizar la solicitud HTTP: " + ex.Message);
                    }
                }
            }
            return matricula;
        }
        public string ObtenerValoresJson(string jsonString)
        {
            List<Person> userList = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            string matricula = string.Empty;

            foreach (Person user in userList)
            {
                matricula = user.id;
            }

            return matricula;
        }
        protected string LlamaGeneraFicha(string matricula, string depto, string cc, string fechaproceso, string importe)
        {
            string msj;
            GeneraFicha genera = new GeneraFicha();
            msj = genera.GeneraFichaPago(matricula, depto, cc, fechaproceso, importe);
            return msj;
        }
        protected void Btn_DescargarFicha_Click(object sender, EventArgs e)
        {
            HttpResponse response = HttpContext.Current.Response;
            response.Clear();
            response.ContentType = "application/octet-stream";
            response.AddHeader("Content-Disposition", "attachment; filename=" + Global.ArchivoFichaDePago[0]);
            response.WriteFile(Global.ArchivoFichaDePago[1]);
            response.End();
        }
        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            InteraccionMenu.cantidadDeCotizaciones = 0;
            Response.Redirect("HomePerfil.aspx", true);
        }

        //Carga solicitudes
        protected void LoadDatosFiscales()
        {
            if (Global.FasesSolicitud["datosfiscales"])
            {
                //var resultDatosFisc = 
            }
        }

        //Botones Check
        protected void DesactivarSoloBotonesCheck()
        {
            Btn_CheckTitu.CssClass = "check_Disable";
            Btn_CheckTitu.Enabled = false;

            Btn_CheckCotizacion.CssClass = "check_Disable";
            Btn_CheckCotizacion.Enabled = false;

            Btn_CheckDatosFiscales.CssClass = "check_Disable";
            Btn_CheckDatosFiscales.Enabled = false;

            Btn_CheckTituDesi.CssClass = "check_Disable";
            Btn_CheckTituDesi.Enabled = false;

            Btn_CheckBenefi.CssClass = "check_Disable";
            Btn_CheckBenefi.Enabled = false;

            Btn_CheckConfirmacion.CssClass = "check_Disable";
            Btn_CheckConfirmacion.Enabled = false;
        }
        protected void Btn_CheckTitu_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("titular");
        }
        protected void Btn_CheckDatosFiscales_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("datos_fiscales");
        }
        protected void Btn_CheckCotizacion_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("cotizacion");
        }
        protected void Btn_CheckTituDesi_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("titular_designado");
        }
        protected void Btn_CheckBenefi_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("beneficiario");
        }
        protected void Btn_CheckConfirmacion_Click(object sender, EventArgs e)
        {
            MuestraFase_Btns("confirmacion");
        }

        //Fases
        protected void CargaFaseConfirmacion()
        {

            DataTable dtDocumentos = new DataTable();
            dtDocumentos.Columns.Add("Estatus", typeof(string));
            dtDocumentos.Columns.Add("Quien", typeof(string));
            dtDocumentos.Columns.Add("Nombre", typeof(string));

            DataRow fila = dtDocumentos.NewRow();
            fila["Estatus"] = "Pendiente";
            fila["Quien"] = "Titular";
            fila["Nombre"] = Global.Titular["primer_nombre"] + " " + Global.Titular["segundo_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];
            dtDocumentos.Rows.Add(fila);

            fila = dtDocumentos.NewRow();
            fila["Estatus"] = "Pendiente";
            fila["Quien"] = "Titular designado";
            fila["Nombre"] = Global.Titular_Designado["primer_nombre"] + " " + Global.Titular_Designado["segundo_nombre"] + " " + Global.Titular_Designado["apellido_paterno"] + Global.Titular_Designado["apellido_materno"];
            dtDocumentos.Rows.Add(fila);

            foreach (var beneficiarios in Global.List_Beneficiarios)
            {
                int i = 1;
                fila = dtDocumentos.NewRow();
                fila["Estatus"] = "Pendiente";
                fila["Quien"] = "Beneficiario " + i;
                fila["Nombre"] = beneficiarios["primer_nombre"] + " " + beneficiarios["segundo_nombre"] + " " + beneficiarios["apellido_paterno"] + beneficiarios["apellido_materno"];
                dtDocumentos.Rows.Add(fila);
            }

            GridV_Documentos.DataSource = dtDocumentos;
            GridV_Documentos.DataBind();

            string moneda = " MXN";

            double _montoTotal = 0;
            foreach (var item in Global.List_Cotizaciones)
            {
                string _monto = (string)item["monto"];
                string[] split_monto = _monto.Split(' ', '$');
                string __monto = split_monto[1];
                double doubMonto = double.Parse(__monto);
                _montoTotal = _montoTotal + doubMonto;
            }

            lbl_MontoConfirmacion.Text = _montoTotal.ToString("C") + moneda;

            RBtnl_ReciboFiscalSoli.ClearSelection();
            if (SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"].ToString().Equals("True"))
            {
                RBtnl_ReciboFiscalSoli.SelectedValue = "1";
            }
            else
            {
                RBtnl_ReciboFiscalSoli.SelectedValue = "0";
            }
        }
        protected void CargaFaseBeneficiario()
        {
            if (Global.List_Beneficiarios != null)
            {
                if (Global.List_Beneficiarios.Count.Equals(0))
                {
                    Pnl_Beneficiario.Visible = true;
                }
                else
                {
                    Pnl_Beneficiario.Visible = false;
                }
            }
        }
        protected void CargaFaseCotizacion()
        {
            if (Global.List_Cotizaciones != null)
            {
                if (Global.List_Cotizaciones.Count.Equals(0))
                {
                    pnl_Cotizacion.Visible = true;
                }
                else
                {
                    pnl_Cotizacion.Visible = false;
                    LoadGridViewCotizacion();
                }
            }
        }
        protected void MuestraFase_Btns(string fase)
        {
            switch (fase)
            {
                case "titular":
                    OcultarForms();
                    pnl_Titular.Visible = true;

                    if (Global.FasesSolicitud["titular"])
                    {
                        dv_Btn_EditarTitular.Visible = true;
                        Btn_EditarTitular.Enabled = true;
                    }
                    else
                    {
                        dv_Btn_EditarTitular.Visible = false;
                        Btn_EditarTitular.Enabled = false;
                    }

                    ReiniciaFase_Btns();
                    dv_phase_1Titu.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2Titu.Attributes["class"] = "dv_phase_2_active";
                    indicador_phase_Titu.Style["display"] = "block";
                    Btn_CheckTitu.CssClass = "check_Disable";
                    Btn_CheckTitu.Enabled = false;
                    break;

                case "datos_fiscales":
                    pnl_BoolReciboFiscal.Visible = true;
                    if (SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"].Equals("False"))
                    {
                        OcultarForms();
                        Pnl_ReciboFiscal.Visible = true;
                        pnl_BoolReciboFiscal.Visible = true;

                        ReiniciaFase_Btns();
                        dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_active";
                        dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_active";
                        indicador_phase_DatosFis.Style["display"] = "block";
                        Btn_CheckDatosFiscales.CssClass = "check_Disable";
                        Btn_CheckDatosFiscales.Enabled = false;

                        dv_Btn_EnviarDatosFisc.Visible = true;
                        Btn_EnviarDatosFiscales.Enabled = true;
                    }
                    else
                    {
                        OcultarForms();
                        Pnl_ReciboFiscal.Visible = true;
                        if (Global.FasesSolicitud["datosfiscales"])
                        {
                            dv_Btn_EditarDatosFisc.Visible = true;
                            Btn_EditarDatosFisc.Enabled = true;
                        }
                        else
                        {
                            dv_Btn_EditarDatosFisc.Visible = false;
                            Btn_EditarDatosFisc.Enabled = false;
                        }
                    }
                    ReiniciaFase_Btns();
                    dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_active";
                    indicador_phase_DatosFis.Style["display"] = "block";
                    Btn_CheckDatosFiscales.CssClass = "check_Disable";
                    Btn_CheckDatosFiscales.Enabled = false;


                    break;

                case "titular_designado":
                    OcultarForms();
                    Pnl_TitularDesignado.Visible = true;

                    if (Global.FasesSolicitud["titular_designado"])
                    {
                        dv_Btn_EditarTituDesi.Visible = true;
                        Btn_EditarTituDesi.Enabled = true;
                    }
                    else
                    {
                        dv_Btn_EnviarTituDesi.Visible = true;
                        Btn_EnviaTituDesi.Enabled = true;
                        Pnl_TitularDesignado.Enabled = true;
                    }
                    ReiniciaFase_Btns();
                    dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2_active";
                    indicador_phase_TituDesi.Style["display"] = "block";

                    Btn_CheckTituDesi.CssClass = "check_Disable";
                    Btn_CheckTituDesi.Enabled = false;
                    break;

                case "cotizacion":
                    OcultarForms();
                    if (Global.FasesSolicitud["cotizacion"])
                    {
                        LoadGridViewCotizacion();
                    }
                    else
                    {
                        pnl_Cotizacion.Visible = true;
                        pnl_Cotizacion.Enabled = true;
                    }

                    ReiniciaFase_Btns();
                    indicador_phase_Cotizacion.Style["display"] = "block";
                    dv_phase_1Cotizacion.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2Cotizacion.Attributes["class"] = "dv_phase_2_active";

                    Btn_CheckCotizacion.CssClass = "check_Disable";
                    Btn_CheckCotizacion.Enabled = false;
                    break;

                case "beneficiario":
                    OcultarForms();

                    if (Global.FasesSolicitud["beneficiario"])
                    {
                        LoadGridViewBeneficiario();
                    }
                    else
                    {

                        Pnl_Beneficiario.Visible = true;
                        Pnl_Beneficiario.Enabled = true;
                    }
                    ReiniciaFase_Btns();
                    dv_phase_1Benefi.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2Benefi.Attributes["class"] = "dv_phase_2_active";
                    indicador_phase_Benefi.Style["display"] = "block";

                    Btn_CheckBenefi.CssClass = "check_Disable";
                    Btn_CheckBenefi.Enabled = false;
                    break;

                case "confirmacion":
                    bool titularDesignado = false, cotizacion = false, beneficiario = false;

                    OcultarForms();
                    pnl_Confirmacion.Visible = true;
                    pnl_Confirmacion.Enabled = true;
                    ReiniciaFase_Btns();
                    dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_active";
                    dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_active";
                    indicador_phase_Confirmacion.Style["display"] = "block";

                    Btn_CheckConfirmacion.CssClass = "check_Disable";
                    Btn_CheckConfirmacion.Enabled = false;

                    CargaFaseConfirmacion();
                    break;
            }
        }
        protected void ReiniciaFase_Btns()
        {
            if (Global.FasesSolicitud != null)
            {
                foreach (var item in Global.FasesSolicitud)
                {
                    if (item.Key.Equals("titular"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1Titu.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2Titu.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1Titu.Attributes["class"] = "dv_phase_1";
                            dv_phase_2Titu.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_Titu.Style["display"] = "none";
                        Btn_CheckTitu.CssClass = "check";
                        Btn_CheckTitu.Enabled = true;
                    }
                    else if (item.Key.Equals("datosfiscales"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1";
                            dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_DatosFis.Style["display"] = "none";
                        Btn_CheckDatosFiscales.CssClass = "check";
                        Btn_CheckDatosFiscales.Enabled = true;
                    }
                    else if (item.Key.Equals("titular_designado"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1";
                            dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_TituDesi.Style["display"] = "none";
                        Btn_CheckTituDesi.CssClass = "check";
                        Btn_CheckTituDesi.Enabled = true;
                    }
                    else if (item.Key.Equals("cotizacion"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1Cotizacion.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2Cotizacion.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1Cotizacion.Attributes["class"] = "dv_phase_1";
                            dv_phase_2Cotizacion.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_Cotizacion.Style["display"] = "none";
                        Btn_CheckCotizacion.CssClass = "check";
                        Btn_CheckCotizacion.Enabled = true;
                    }
                    else if (item.Key.Equals("beneficiario"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1Benefi.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2Benefi.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1Benefi.Attributes["class"] = "dv_phase_1";
                            dv_phase_2Benefi.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_Benefi.Style["display"] = "none";
                        Btn_CheckBenefi.CssClass = "check";
                        Btn_CheckBenefi.Enabled = true;
                    }
                    else if (item.Key.Equals("confirmacion"))
                    {
                        if (item.Value)
                        {
                            dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_Check";
                            dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_Check";
                        }
                        else
                        {
                            dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1";
                            dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2";
                        }
                        indicador_phase_Confirmacion.Style["display"] = "none";
                        Btn_CheckConfirmacion.CssClass = "check";
                        Btn_CheckConfirmacion.Enabled = true;
                    }
                }
            }
        }
        protected void OcultarForms()
        {
            Pnl_boolCompra.Visible = false;
            pnl_BoolCotizacionExtra.Visible = false;
            pnl_BoolReciboFiscal.Visible = false;
            pnl_BoolBeneficiarioExtra.Visible = false;

            pnl_BoolVerificaInfoFiscal.Visible = false;
            Pnl_BoolVerificaTitular.Visible = false;

            pnl_Titular.Visible = false;
            pnl_Cotizacion.Visible = false;
            Pnl_ReciboFiscal.Visible = false;
            Pnl_TitularDesignado.Visible = false;
            Pnl_Beneficiario.Visible = false;
            pnl_Confirmacion.Visible = false;

            pnl_Titular.Enabled = false;
            pnl_Cotizacion.Enabled = false;
            Pnl_ReciboFiscal.Enabled = false;
            Pnl_TitularDesignado.Enabled = false;
            Pnl_Beneficiario.Enabled = false;
            pnl_Confirmacion.Enabled = false;

            dv_Btn_EnviarTitular.Visible = false;
            dv_Btn_EnviarDatosFisc.Visible = false;
            dv_Btn_EnviarTituDesi.Visible = false;

            dv_Btn_EditarTitular.Visible = false;
            dv_Btn_EditarDatosFisc.Visible = false;
            dv_Btn_EditarTituDesi.Visible = false;

            Container_GridV_Beneficiario.Visible = false;
            Container_GridV_Cotizacion.Visible = false;
        }
        protected void GridV_Beneficiario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit_Beneficiario"))
            {
                PosibleDuplicado.Actualiza = true;
                PosibleDuplicado.Coincidencia = 0;
                PosibleDuplicado.CorreoIgual = false;
                PosibleDuplicado.Duplicado = false;
                PosibleDuplicado.PorPorcentaje = false;



                int index = Convert.ToInt32(e.CommandArgument);
                Pnl_Beneficiario.Visible = true;
                Pnl_Beneficiario.Enabled = true;
                Container_GridV_Beneficiario.Visible = false;
                Fill_Form_Beneficiario(index);
            }
        }

        protected void rbl_BecaBenefi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_BecaBenefi.Text.Equals("Sí"))
            {
                Pnl_PorcentBecaBenefi.Visible = true;
                Pnl_PorcentBecaBenefi.Enabled = true;
                ConfirmatxtB_PorcentBecaBenefi.Enabled = true;
            }
            else
            {
                Pnl_PorcentBecaBenefi.Visible = false;
                Pnl_PorcentBecaBenefi.Enabled = false;
                ConfirmatxtB_PorcentBecaBenefi.Enabled = false;
            }
        }

        protected void Btn_Cerrar_UsoDeRecursos_Click(object sender, EventArgs e)
        {
            pnl_UsoDeRecursos.Visible = false;
        }

        protected void Btn_LeerUsoDeDatos_Click(object sender, EventArgs e)
        {
            pnl_UsoDeRecursos.Visible = true;
        }

        protected void GridV_Documentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Enviar")
            {

                InsArchivoSP.ObtenerServer(Server);
                InsArchivoSP.ObtenerGrid(GridV_Documentos);
                Button btnEnviar = e.CommandSource as Button;
                int rowIndex = 0;
                if (btnEnviar != null)
                {
                    // Obtener la fila del GridView que contiene el botón
                    GridViewRow _row = btnEnviar.NamingContainer as GridViewRow;

                    if (_row != null)
                    {
                        rowIndex = _row.RowIndex;

                        Button _btnEnviar = (Button)_row.FindControl("BtnEnviarArchivo");
                        _btnEnviar.Visible = false;

                        Button _btnEditar = (Button)_row.FindControl("BtnEditarArchivo");
                        _btnEditar.Visible = true;

                        _row.Enabled = false;

                        foreach (TableCell cell in _row.Cells)
                        {
                            if(cell.Text.Contains("Pendiente"))
                            {
                                cell.Text = "Enviado";
                            }
                            if (cell.Controls.Contains(_btnEnviar) && cell.Controls.Contains(_btnEditar))
                            {
                                cell.Enabled = true;

                                foreach (Control control in cell.Controls)
                                {
                                    if (control is WebControl)
                                    {
                                        ((WebControl)control).Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                cell.Enabled = false;
                            }
                        }
                    }
                }
                GridViewRow row = GridV_Documentos.Rows[rowIndex];
                FileUpload fileUpload = (FileUpload)row.FindControl("file_upload");
                if (fileUpload.HasFile)
                {
                    string _fullname = string.Empty;
                    if (Global.Titular["segundo_nombre"] != null)
                    {
                        _fullname = Global.Titular["primer_nombre"] + " " + Global.Titular["segundo_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];
                    }
                    else
                    {
                        _fullname = Global.Titular["primer_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];

                    }
                    RadioButtonList radioList = row.FindControl("RadioBL_TipoArchivo") as RadioButtonList;
                    string doc = radioList.SelectedItem.Text.Replace(" ", "_");
                    string _guidcontactid = (string)Global.Titular["guid_titular"];
                    string SolicitudId = Global.GuidSolicitud;
                    string quien = row.Cells[1].Text.Replace(" ", "_");
                    string que = row.Cells[0].Text.Replace(" ", "_"); ;
                    InsArchivoSP insArchivo = new InsArchivoSP();
                    insArchivo.SubirArchivo(rowIndex, _fullname, _guidcontactid, SolicitudId, quien, que, doc);

                    Lbl_AlertaPersonalizada.Text = "El archivo se cargo correctamente.";
                    string script = "<script type='text/javascript'>showAlert();</script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "showAlert", script);

                    row.BackColor = Color.LimeGreen;

                    // Bloquea la fila deshabilitando todos los controles en ella
                    foreach (TableCell cell in row.Cells)
                    {
                        if (cell.FindControl("BtnEnviarArchivo") == null && cell.FindControl("BtnEditar") == null)
                        {
                            foreach (Control control in cell.Controls)
                            {
                                if (control is WebControl)
                                {
                                    ((WebControl)control).Enabled = false;
                                }
                            }
                        }

                    }
                }
                else
                {
                    fileUpload.Focus();
                    fileUpload.BorderColor = Color.Red;
                }
            }
            else if (e.CommandName == "Editar")
            {
                Button btnEditar = e.CommandSource as Button;
                int rowIndex = 0;
                if (btnEditar != null)
                {
                    // Obtener la fila del GridView que contiene el botón
                    GridViewRow _row = btnEditar.NamingContainer as GridViewRow;

                    if (_row != null)
                    {
                        rowIndex = _row.RowIndex;

                        Button _btnEnviar = (Button)_row.FindControl("BtnEnviarArchivo");
                        _btnEnviar.Visible = true;

                        Button _btnEditar = (Button)_row.FindControl("BtnEditarArchivo");
                        _btnEditar.Visible = false;

                        foreach (TableCell cell in _row.Cells)
                        {
                            if (cell.FindControl("BtnEnviarArchivo") == null && cell.FindControl("BtnEditarArchivo") == null)
                            {
                                cell.Enabled = true;

                                foreach (Control control in cell.Controls)
                                {
                                    if (control is WebControl)
                                    {
                                        ((WebControl)control).Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                cell.Enabled = false;
                            }

                        }
                    }
                }
            }
        }

        protected void Btn_SubirComprobante_Click(object sender, EventArgs e)
        {
            string _fullname = string.Empty;
            if (Global.Titular["segundo_nombre"] != null)
            {
                _fullname = Global.Titular["primer_nombre"] + " " + Global.Titular["segundo_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];
            }
            else
            {
                _fullname = Global.Titular["primer_nombre"] + " " + Global.Titular["apellido_paterno"] + " " + Global.Titular["apellido_materno"];

            }
            InsArchivoSP insArchivo = new InsArchivoSP();
            insArchivo.SubirArchivo(0, _fullname, (string)Global.Titular["guid_titular"], Global.GuidSolicitud, _fullname, "", "Comprobante_de_domicilio");
        }
    }
}