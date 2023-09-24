using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLegadoEducativo02.Clases;

namespace WebLegadoEducativo02
{
    public partial class HomePerfil : System.Web.UI.Page
    {

        public class Global
        {
            public static string guidContactoTitular = string.Empty;
            public static string NombreContactoTitular = string.Empty;

            public static List<Dictionary<string, object>> List_Cotizaciones { get; set; }
            public static Dictionary<string, object> Cotizacion { get; set; }
            public static List<Dictionary<string, object>> List_Solicitudes { get; set; }
            public static Dictionary<string, object> Solicitud { get; set; }
            public static Dictionary<string, object> Titular { get; set; }
            public static Dictionary<string, object> DatosFiscales { get; set; }
            public static Dictionary<string, object> TitularDesigando { get; set; }
            public static Dictionary<string, object> FasesSolicitud { get; set; }
            public static List<Dictionary<string, object>> List_Beneficiarios { get; set; }
            public static Dictionary<string, object> Beneficiario { get; set; }
        }
        const string guid_ListaPrecio_LE = "577A2185-552A-EE11-BDF4-000D3A343FEF";

        WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom wsInsSoliCom = new WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom();
        WS_LE_Oportunidad.WS_LE_Oportunidad wsOppor = new WS_LE_Oportunidad.WS_LE_Oportunidad();
        WS_LE_ConsSolicitudCompra.WS_LE_ConsSolicitudCompra wsConSoliCom = new WS_LE_ConsSolicitudCompra.WS_LE_ConsSolicitudCompra();
        WS_LE_ConsultaContac.WS_LE_ConsultaContac wsconsContac = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
        WS_LE_ConsOferta.WS_LE_ConsOferta wsConsOferta = new WS_LE_ConsOferta.WS_LE_ConsOferta();
        WS_LE_ConsProductOferta.WS_LE_ConsProductOferta wsConsProdOferta = new WS_LE_ConsProductOferta.WS_LE_ConsProductOferta();
        WS_LE_Cotizaciones.WS_LE_Cotizaciones wsInsCoti = new WS_LE_Cotizaciones.WS_LE_Cotizaciones();
        WS_LE_ProgramaAcademico.WS_LE_ProgramaAcademico wsConsProgAca = new WS_LE_ProgramaAcademico.WS_LE_ProgramaAcademico();
        WS_LE_Beneficiarios.WS_LE_Beneficiarios wsInsBenefi = new WS_LE_Beneficiarios.WS_LE_Beneficiarios();
        WS_LE_Documentos.WS_LE_Documentos wsInsDocumentos = new WS_LE_Documentos.WS_LE_Documentos();


        protected void Init_Cotizacion()
        {
            Global.Cotizacion = new Dictionary<string, object>()
            {
                { "guidProducto", string.Empty },
                { "guidOferta", string.Empty },
                { "guidprograma_academico", string.Empty },
                { "programa_academico", string.Empty },
                { "creditos_programa", string.Empty },
                { "periodos_programa", string.Empty },
                { "guidproducto", string.Empty },
                { "producto", string.Empty },
                { "unidad_Venta", string.Empty },
                { "tipo_de_periodo", new Dictionary<string, object>() },
                { "que_QuiereCotizar", new Dictionary<string, object>() },
                { "cuanto_QuiereCotizar", new Dictionary<string, object>() },
                { "porcentaje_Beca", new List<Dictionary<string, object>>() },
                { "total_a_cotizar", new List<Dictionary<string, object>>() },
                { "cantidad_creditos_periodos", new Dictionary<string, object>() },
                { "precio_unidadVenta", string.Empty },
                { "importe", string.Empty },
            };
        }
        protected void Init_Solicitud()
        {
            Global.Solicitud = new Dictionary<string, object>()
            {
                { "GuidOportunidad", string.Empty },
                { "GuidSolicitud", string.Empty },
                { "udem_name", string.Empty },
                { "udem_documentosentregadostitular", string.Empty },
                { "udem_documentosentregadostitulardesignado", string.Empty },
                { "udem_documentosentregadosbeneficiarios", string.Empty },
                { "udem_requiererecibofiscal", string.Empty },
                { "titular", new Dictionary<string, object>() },
                { "titularDesignado", new Dictionary<string, object>() },
                { "datosFiscales", new Dictionary<string, object>() },
                { "beneficiarios", new List<Dictionary<string, object>>() },
                { "cotizaciones", new List<Dictionary<string, object>>() },
                { "fases_solicitud", new Dictionary<string, object>() },
                { "estatus", string.Empty },
            };
        }
        protected void Init_Titular()
        {
            Global.Titular = new Dictionary<string, object>()
            {
                { "nombreTitular", string.Empty },
                { "guidTitular", string.Empty },
            };
        }
        protected void Init_TitularDesignado()
        {
            Global.TitularDesigando = new Dictionary<string, object>()
            {
                { "nombreTitularDesignado", string.Empty },
                { "guidTitularDesignado", string.Empty },
            };
        }
        protected void Init_Beneficiario()
        {
            Global.Beneficiario = new Dictionary<string, object>()
            {
                { "nombreBeneficiario", string.Empty },
                { "guidBeneficiario", string.Empty },
            };
        }
        protected void Init_DatosFiscales()
        {
            Global.DatosFiscales = new Dictionary<string, object>()
            {
                { "nombreDatosFiscales", string.Empty },
                { "guidDatosFiscales", string.Empty },
            };
        }
        protected void Init_FasesSolicitud()
        {
            Global.FasesSolicitud = new Dictionary<string, object>
            {
                { "titular", false },
                { "datosfiscales", false },
                { "titular_designado", false },
                { "cotizacion", false },
                { "beneficiario", false },
                { "confirmacion", false },
            };
        }

        protected void Fill_Solicitudes()
        {
            Global.List_Solicitudes = new List<Dictionary<string, object>>();
            Global.List_Cotizaciones = new List<Dictionary<string, object>>();

            var dats = wsConSoliCom.ConsSoli(Global.guidContactoTitular);
            if (!dats[0].mensaje.Contains("Sin Registros"))
            {
                foreach (var item in dats)
                {
                    Init_Solicitud();
                    Init_Titular();
                    Init_TitularDesignado();
                    Init_FasesSolicitud();
                    Init_DatosFiscales();

                    if (item.udem_name != null)
                    {
                        Global.Solicitud["udem_name"] = item.udem_name;
                    }
                    if (item.opportunityid != null)
                    {
                        Global.Solicitud["GuidOportunidad"] = item.opportunityid;

                    }
                    if (item.udem_solicituddecompraid != null)
                    {
                        Global.Solicitud["GuidSolicitud"] = item.udem_solicituddecompraid;
                    }
                    if (item.udem_titular != null)
                    {
                        Global.Titular["guidTitular"] = item.Guid_udem_titular;
                        Global.Titular["nombreTitular"] = item.udem_titular;
                        Global.Solicitud["titular"] = Global.Titular;
                        Global.FasesSolicitud["titular"] = true;
                    }
                    if (item.udem_titulardesignado != null)
                    {
                        Global.TitularDesigando["guidTitularDesignado"] = item.Guid_udem_titulardesignado;
                        Global.TitularDesigando["nombreTitularDesignado"] = item.udem_titulardesignado;
                        Global.Solicitud["titularDesignado"] = Global.TitularDesigando;
                        Global.FasesSolicitud["titular_designado"] = true;
                    }
                    if (item.udem_datosfiscales != null)
                    {
                        Global.FasesSolicitud["datosfiscales"] = true;
                        Global.DatosFiscales["guidDatosFiscales"] = item.Guid_udem_datosfiscales;
                        Global.DatosFiscales["nombreDatosFiscales"] = item.udem_datosfiscales;
                        Global.Solicitud["datosFiscales"] = Global.DatosFiscales;
                    }
                    if (item.Beneficiarios != null)
                    {
                        Global.FasesSolicitud["beneficiario"] = true;
                        Global.List_Beneficiarios = new List<Dictionary<string, object>>();

                        foreach (var _item in item.Beneficiarios)
                        {
                            Init_Beneficiario();
                            Global.Beneficiario["guidBeneficiario"] = _item.udem_beneficiariosid;
                            Global.Beneficiario["nombreBeneficiario"] = _item.udem_beneficiario;
                            Global.List_Beneficiarios.Add(Global.Beneficiario);
                        }
                        Global.Solicitud["beneficiarios"] = Global.List_Beneficiarios;
                    }
                    if (item.udem_documentosentregadostitular != null)
                    {
                        Global.Solicitud["udem_documentosentregadostitular"] = item.udem_documentosentregadostitular;
                        if (item.udem_documentosentregadostitular.Equals("False"))
                        {
                            Global.FasesSolicitud["confirmacion"] = false;
                        }
                        else
                        {
                            Global.FasesSolicitud["confirmacion"] = true;
                        }
                    }
                    if (item.udem_documentosentregadostitulardesignado != null)
                    {
                        Global.Solicitud["udem_documentosentregadostitulardesignado"] = item.udem_documentosentregadostitulardesignado;
                    }
                    if (item.udem_documentosentregadosbeneficiarios != null)
                    {
                        Global.Solicitud["udem_documentosentregadosbeneficiarios"] = item.udem_documentosentregadosbeneficiarios;
                    }
                    if (item.udem_requiererecibofiscal != null)
                    {
                        Global.Solicitud["udem_requiererecibofiscal"] = item.udem_requiererecibofiscal;
                    }

                    string opp = (string)Global.Solicitud["GuidOportunidad"];
                    string titu = (string)Global.Titular["guidTitular"];
                    if (opp != null && titu != null)
                    {
                        var oferta = wsConsOferta.ConsOfert(opp, titu);
                        string guidOferta = oferta[0].quoteid;

                        var productoOferta = wsConsProdOferta.ConsProductOfert(guidOferta);
                        foreach (var productos in productoOferta)
                        {
                            if (productos.mensaje.Contains("Exitosa"))
                            {
                                Global.FasesSolicitud["cotizacion"] = true;
                                Init_Cotizacion();
                                Global.Cotizacion["guidProducto"] = productos.quotedetailid;
                                Global.Cotizacion["guidOferta"] = productos.quoteid;
                                Global.Cotizacion["guidprograma_academico"] = productos.udem_programaacademico_id;
                                Global.Cotizacion["programa_academico"] = productos.udem_programaacademico_name;
                                Global.Cotizacion["creditos_programa"] = productos.udem_le_creditosporproducto;
                                Global.Cotizacion["periodos_programa"] = productos.udem_le_semestresporproducto;
                                Global.Cotizacion["guidproducto"] = productos.product_id;
                                Global.Cotizacion["producto"] = productos.product_name;
                                Global.Cotizacion["unidad_Venta"] = productos.uom_id;
                                Global.Cotizacion["tipo_de_periodo"] = productos.udem_tipodeperiodo;
                                Global.Cotizacion["que_QuiereCotizar"] = productos.udem_unidadacotizar;
                                Global.Cotizacion["cuanto_QuiereCotizar"] = productos.udem_cantidadacotizar;
                                Global.Cotizacion["porcentaje_Beca"] = productos.udem_le_porcentajebeca;
                                Global.Cotizacion["cantidad_creditos_periodos"] = productos.quantity;
                                Global.Cotizacion["precio_unidadVenta"] = productos.priceperunit;
                                Global.Cotizacion["importe"] = productos.baseamount;

                                Global.List_Cotizaciones.Add(Global.Cotizacion);
                            }
                        }
                        Global.Solicitud["cotizaciones"] = Global.List_Cotizaciones;
                    }
                    Global.Solicitud["fases_solicitud"] = Global.FasesSolicitud;
                    DetermStatusSolis();

                    Global.List_Solicitudes.Add(Global.Solicitud);
                }
                SolicitudesCs.List_Solicitudes = Global.List_Solicitudes;
            }
        }
        protected void LoadGridV_Solicitudes()
        {
            try
            {
                Fill_Solicitudes();

                DataTable dtSolicitudes = new DataTable();
                dtSolicitudes.Columns.Add("Nombre de la solicitud", typeof(string));
                dtSolicitudes.Columns.Add("Titular", typeof(string));
                dtSolicitudes.Columns.Add("Beneficiarios", typeof(string));
                dtSolicitudes.Columns.Add("Estatus", typeof(string));

                if (Global.List_Solicitudes != null)
                {
                    if (Global.List_Solicitudes.Count.Equals(0))
                    {
                        Pnl_InfoSolicitudes.Visible = false;
                    }
                    else
                    {
                        for (int i = 0; i < Global.List_Solicitudes.Count; i++)
                        {
                            var solicitudes = Global.List_Solicitudes.ElementAt(i);

                            DataRow fila = dtSolicitudes.NewRow();

                            for (int j = 0; j < solicitudes.Count; j++)
                            {
                                var solicitud = solicitudes.ElementAt(j);

                                switch (solicitud.Key)
                                {
                                    case "udem_name":
                                        fila["Nombre de la solicitud"] = solicitud.Value;
                                        break;

                                    case "titular":
                                        if (solicitud.Key.Equals("titular") && solicitud.Value is Dictionary<string, object> titular)
                                        {
                                            foreach (var item in titular)
                                            {
                                                if (item.Key.Equals("nombreTitular"))
                                                {
                                                    fila["Titular"] = item.Value;
                                                }
                                            }
                                        }
                                        break;

                                    case "beneficiarios":
                                        if (solicitud.Key.Equals("beneficiarios"))
                                        {
                                            if (solicitud.Value is List<Dictionary<string, object>> beneficiarios)
                                            {
                                                foreach (var beneficiario in beneficiarios)
                                                {
                                                    foreach (var item in beneficiario)
                                                    {
                                                        if (item.Key.Equals("nombreBeneficiario"))
                                                        {
                                                            fila["Beneficiarios"] = item.Value + "<br/>";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;

                                    case "estatus":
                                        fila["Estatus"] = solicitud.Value;
                                        break;
                                }
                            }
                            dtSolicitudes.Rows.Add(fila);
                        }
                        GridV_InfoSolicitudes.DataSource = dtSolicitudes;
                        GridV_InfoSolicitudes.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Logout("Se ha cerrado su sesión debido a un error =>" + ex, "WebLE02InicioCreaCuenta.aspx");
            }

        }

        protected void DetermStatusSolis()
        {
            for (int j = 0; j < Global.Solicitud.Count; j++)
            {
                var solicitud = Global.Solicitud.ElementAt(j);
                bool recibofiscal = false;
                string status = string.Empty;
                if (solicitud.Key.Equals("udem_requiererecibofiscal"))
                {
                    if (solicitud.Value.ToString().Length < 0)
                    {
                        string str_boolValue = (string)solicitud.Value;
                        recibofiscal = bool.Parse(str_boolValue);
                    }
                }
                if (solicitud.Key.Equals("fases_solicitud") && solicitud.Value is Dictionary<string, object> fasesSolicitud)
                {
                    foreach (var fase in fasesSolicitud)
                    {
                        switch (fase.Key)
                        {
                            case "titular":
                                if (fase.Value.Equals(false))
                                {
                                    status = "En captura";
                                }
                                else
                                {
                                    status = "Completada";
                                }
                                break;

                            case "datosfiscales":
                                if (recibofiscal)
                                {
                                    if (fase.Value.Equals(false))
                                    {
                                        status = "En captura";
                                    }
                                    else
                                    {
                                        status = "Completada";
                                    }
                                }
                                break;

                            case "titular_designado":
                                if (fase.Value.Equals(false))
                                {
                                    status = "En captura";
                                }
                                else
                                {
                                    status = "Completada";
                                }
                                break;

                            case "cotizacion":
                                if (fase.Value.Equals(false))
                                {
                                    status = "En captura";
                                }
                                break;

                            case "beneficiario":
                                if (fase.Value.Equals(false))
                                {
                                    status = "En captura";
                                }
                                else
                                {
                                    status = "Completada";
                                }
                                break;

                            case "confirmacion":
                                if (fase.Value.Equals(false))
                                {
                                    status = "En captura";
                                }
                                else
                                {
                                    status = "Completada";
                                }
                                break;
                        }

                        if (status.Equals("En captura"))
                            break;
                    }
                    Global.Solicitud["estatus"] = status;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Id"].Equals(1))
                {
                    if (!IsPostBack)
                    {
                        Pnl_InfoSolicitudes.Visible = true;
                        Lbl_Perfil.Text = "Sus solicitudes de compra";
                        var titu = wsconsContac.ConsultaContactCorreo(Session["Usuario"].ToString(), "", "");
                        Global.guidContactoTitular = titu[0].contactid;

                        Global.NombreContactoTitular = titu[0].fullname;


                        LoadGridV_Solicitudes();
                    }
                    InteraccionMenu.cantidadDeCotizaciones = 0;
                }
                else
                {
                    if (Session["Id"].Equals(null) && Session.IsNewSession)
                    {
                        Logout("Se ha cerrado su sesión debido a inactividad.", "WebLE02InicioCreaCuenta.aspx");
                    }
                    Logout("Se ha cerrado su sesión", "WebLE02InicioCreaCuenta.aspx");
                }
                Pnl_infoCuenta.Visible = false;
                Pnl_solicitudes.Visible = false;

                if (Session["Usuario"] != null)
                {
                    Lbl_mensaje.Text = "Bienvenido " + Global.NombreContactoTitular;
                }
                else
                {
                    Logout("Se ha cerrado su sesión", "WebLE02InicioCreaCuenta.aspx");
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                Logout("Es necesario iniciar sesión", "WebLE02InicioCreaCuenta.aspx");
            }

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

        protected void Btn_Perfil_Click(object sender, EventArgs e)
        {
            try
            {
                Clases_Btns_Desactivadas();
                Btn_Perfil.CssClass = "BtnsOptionsPerfilCheck";
                Habilita_Btns();
                OcultaConteOpts();
                Pnl_infoCuenta.Visible = true;
                Lbl_Perfil.Text = "Perfil";

                WS_LE_ConClientePotencial.WS_LE_ConClientePotencial wsconscp = new WS_LE_ConClientePotencial.WS_LE_ConClientePotencial();
                var dats = wsconscp.ConsClientePotencialcorStatus(Session["Usuario"].ToString(), "", "");
                txtB_nombre.Text = dats[0].firstname;
                txtB_SegunNombre.Text = dats[0].middlename;
                txtB_apePater.Text = dats[0].udem_apellidopaterno;
                txtB_apeMater.Text = dats[0].udem_apellidomaterno;
                txtB_correoElec.Text = dats[0].emailaddress1;
                txtB_TelefonoMovil.Text = dats[0].mobilephone;
                txtB_TelefonoParti.Text = dats[0].telephone2;
                string[] splitFechaNac = dats[0].udem_fechadenacimiento.Split('/', ' ');
                string fechaNac = splitFechaNac[0] + "/";
                fechaNac += splitFechaNac[1] + "/";
                fechaNac += splitFechaNac[2];
                txtB_fechaNac.Text = fechaNac;
                if (dats[0].udem_contactoprincipal_diceserexalumno == "True")
                {
                    txtB_exUdem.Text = "Si";
                }
                else
                {
                    txtB_exUdem.Text = "No";
                }

            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Logout("Se cerrara su sesion debido a un error inesperado", "UnexpectedError.aspx");
            }
        }

        protected void Btn_Solicitudes_Click(object sender, EventArgs e)
        {
            bool allSolEnd = false;
            if (Global.List_Solicitudes.Count != 0)
            {
                foreach (var solicitudes in Global.List_Solicitudes)
                {
                    foreach (var solicitud in solicitudes)
                    {
                        if (solicitud.Key.Equals("estatus"))
                        {
                            if (solicitud.Value.Equals("En captura"))
                            {
                                allSolEnd = false;
                                break;
                            }
                            else
                            {
                                allSolEnd = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                allSolEnd = true;
            }
            Clases_Btns_Desactivadas();
            Btn_Solicitudes.CssClass = "BtnsOptionsPerfilCheck";
            Habilita_Btns();
            OcultaConteOpts();
            Lbl_Perfil.Text = "Sus solicitudes de compra";
            Pnl_InfoSolicitudes.Visible = true;

            if (!allSolEnd)
            {
                Pnl_solicitudes.Visible = false;
            }
            else if (allSolEnd)
            {
                Pnl_solicitudes.Visible = true;
            }
        }
        protected void Btn_Familiares_Click(object sender, EventArgs e)
        {
            try
            {
                OcultaConteOpts();
                Pnl_Familiares.Visible = true;
                Clases_Btns_Desactivadas();
                Btn_Familiares.CssClass = "BtnsOptionsPerfilCheck";
                Habilita_Btns();
                Lbl_Perfil.Text = "Familiares registrados";
                WS_LE_ConsFamiliaContacto.WS_LE_ConsFamiliaContacto WSCFamiCon = new WS_LE_ConsFamiliaContacto.WS_LE_ConsFamiliaContacto();
                var famicontact = WSCFamiCon.ConsFam(Global.guidContactoTitular);

                DataTable dtFamiliares = new DataTable();
                dtFamiliares.Columns.Add("Nombre", typeof(string));
                dtFamiliares.Columns.Add("Parentesco", typeof(string));

                foreach (var item in famicontact)
                {
                    DataRow filaFami = dtFamiliares.NewRow();

                    filaFami["Nombre"] = item.new_name;
                    filaFami["Parentesco"] = item.new_parentesco;

                    dtFamiliares.Rows.Add(filaFami);
                }

                GridV_Familiares.DataSource = dtFamiliares;
                GridV_Familiares.DataBind();
            }
            catch (Exception ex)
            {
                Session["Exception"] = ex.Message.ToString();
                Logout("Se cerrara su sesion debido a un error inesperado", "UnexpectedError.aspx");
            }

        }

        protected void Habilita_Btns()
        {
            Btn_Perfil.Enabled = true;
            Btn_Solicitudes.Enabled = true;
            Btn_Certificados.Enabled = true;
            Btn_Compras.Enabled = true;
            Btn_Familiares.Enabled = true;
        }

        protected void Clases_Btns_Desactivadas()
        {
            Btn_Perfil.CssClass = "BtnsOptionsPerfil";
            Btn_Solicitudes.CssClass = "BtnsOptionsPerfil";
            Btn_Certificados.CssClass = "BtnsOptionsPerfil";
            Btn_Compras.CssClass = "BtnsOptionsPerfil";
            Btn_Familiares.CssClass = "BtnsOptionsPerfil";
        }

        protected void Btn_CrearSoliCompra_Click(object sender, EventArgs e)
        {
            DateTime fechaActualSF = DateTime.Now;
            string fechaActual = fechaActualSF.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string area = "Legado Educativo";
            string name = "LE - " + Global.NombreContactoTitular + " - " + fechaActual;
            string asunto = "Compra - Legado Educativo";

            var resultOpp = wsOppor.InsOportunidadContacto(name, area, asunto, Global.guidContactoTitular, "", "", guid_ListaPrecio_LE);
            var resultSoli = wsInsSoliCom.InsSolicitudCompra("LE-SOL-" + Global.NombreContactoTitular, resultOpp.Guid, Global.guidContactoTitular, "", "", "", "", "", "", "", "", "", "Legado Educativo");
            var resultDocs = wsInsDocumentos.InSuplementalSub("", Global.guidContactoTitular, resultSoli.Guid, "", "", "", "", "", "", "", "", "");

            Fill_Solicitudes();
            SolicitudesCs.CurrentSolicitud = Global.List_Solicitudes[0];


            Response.Redirect("~/WebSolicitudCompraLE.aspx");
        }

        protected void MuestraDetallesSolicitud(int index)
        {
            Label1.Text = string.Empty;
            Label2.Text = string.Empty;
            Label3.Text = string.Empty;
            Pnl_InfoSolicitudes.Visible = false;
            Pnl_DetallesSolicitud.Visible = true;
            bool reciboFiscal = false;
            foreach (var item in Global.List_Solicitudes[index])
            {
                if (item.Key.Equals("estatus"))
                {
                    if (item.Value.Equals("Completada"))
                    {
                        container_btn_Recompra.Visible = true;
                    }
                    else
                    {
                        container_btn_Recompra.Visible = false;
                    }
                }
                if (item.Key.Equals("udem_name"))
                {
                    Lbl_DetallesSoliName.Text = item.Value.ToString();
                }
                if (item.Key.Equals("udem_requiererecibofiscal"))
                {
                    string str_boolValue = (string)item.Value;
                    reciboFiscal = bool.Parse(str_boolValue);
                }
                if (item.Key.Equals("fases_solicitud"))
                {
                    if (item.Value is Dictionary<string, object> fasesSolicitud)
                    {
                        reciboFiscal = (bool)fasesSolicitud["datosfiscales"];
                        MuestraFasesSolicitud(fasesSolicitud, reciboFiscal);
                    }
                }
                if (item.Key.Equals("titular") && item.Value is Dictionary<string, object> titular)
                {
                    Label1.Text = (string)titular["nombreTitular"];
                }

                if (item.Key.Equals("titularDesignado") && item.Value is Dictionary<string, object> tituDesi)
                {
                    if (tituDesi.Count > 0)
                    {
                        Label2.Text = (string)tituDesi["nombreTitularDesignado"];
                    }
                }

                if (item.Key.Equals("beneficiarios") && item.Value is List<Dictionary<string, object>> beneficiarios)
                {
                    if (beneficiarios.Count > 0)
                    {
                        foreach (var beneficiario in beneficiarios)
                        {
                            foreach (var _item in beneficiario)
                            {
                                if (_item.Key.Equals("nombreBeneficiario"))
                                {
                                    Label3.Text += _item.Value + " <br/>";
                                }
                            }
                        }
                    }
                }
            }
        }
        protected void MuestraFasesSolicitud(Dictionary<string, object> Dictfases, bool reciboFiscal)
        {
            double pctAvance = 0;
            ReiniciaFaseDetalles();

            if (Dictfases is Dictionary<string, object> fasesSolicitud)
            {
                foreach (var fase in fasesSolicitud)
                {
                    switch (fase.Key)
                    {
                        case "titular":
                            if (fase.Value.Equals(true))
                            {
                                dv_phase_1Titu.Attributes["class"] = "dv_detalles_1_active";
                                dv_phase_2Titu.Attributes["class"] = "dv_detalles_2_active";
                                pctAvance = pctAvance + 20;
                            }
                            break;

                        case "titular_designado":
                            if (fase.Value.Equals(true))
                            {
                                dv_phase_1TituDesi.Attributes["class"] = "dv_detalles_1_active";
                                dv_phase_2TituDesi.Attributes["class"] = "dv_detalles_2_active";
                                pctAvance = pctAvance + 20;
                            }
                            break;

                        case "datosfiscales":
                            if (reciboFiscal)
                            {
                                if (fase.Value.Equals(true))
                                {
                                    container_phase_DatosFisc.Visible = true;
                                    dv_phase_1DatosFisc.Attributes["class"] = "dv_detalles_1_active";
                                    dv_phase_2DatosFisc.Attributes["class"] = "dv_detalles_2_active";
                                    pctAvance = pctAvance + 20;
                                }
                            }
                            else
                            {
                                container_phase_DatosFisc.Visible = false;
                            }
                            break;

                        case "cotizacion":
                            if (fase.Value.Equals(true))
                            {
                                dv_phase_1Cotizacion.Attributes["class"] = "dv_detalles_1_active";
                                dv_phase_2Cotizacion.Attributes["class"] = "dv_detalles_2_active";
                                pctAvance = pctAvance + 20;
                            }
                            break;

                        case "beneficiario":
                            if (fase.Value.Equals(true))
                            {
                                dv_phase_1Benefi.Attributes["class"] = "dv_detalles_1_active";
                                dv_phase_2Benefi.Attributes["class"] = "dv_detalles_2_active";
                                pctAvance = pctAvance + 20;
                            }
                            break;

                        case "confirmacion":
                            if (fase.Value.Equals(true))
                            {
                                dv_phase_1Confirmacion.Attributes["class"] = "dv_detalles_1_active";
                                dv_phase_2Confirmacion.Attributes["class"] = "dv_detalles_2_active";
                                pctAvance = pctAvance + 20;
                            }
                            break;
                    }
                }
            }
            pctAvance = 100;
            lineaPunteada.Style["border-image"] = "linear-gradient(to bottom, #03afa3 0%, #03afa3 " + pctAvance + "%, gray " + pctAvance + "%, gray 100%) 1";
        }


        protected void ReiniciaFaseDetalles()
        {
            container_phase_Titu.Visible = true;
            dv_phase_1Titu.Attributes["class"] = "dv_detalles_1";
            dv_phase_2Titu.Attributes["class"] = "dv_detalles_2";

            container_phase_DatosFisc.Visible = true;
            dv_phase_1DatosFisc.Attributes["class"] = "dv_detalles_1";
            dv_phase_2DatosFisc.Attributes["class"] = "dv_detalles_2";

            container_phase_TituDesi.Visible = true;
            dv_phase_1TituDesi.Attributes["class"] = "dv_detalles_1";
            dv_phase_2TituDesi.Attributes["class"] = "dv_detalles_2";

            container_phase_Cotizacion.Visible = true;
            dv_phase_1Cotizacion.Attributes["class"] = "dv_detalles_1";
            dv_phase_2Cotizacion.Attributes["class"] = "dv_detalles_2";

            container_phase_Benefi.Visible = true;
            dv_phase_1Benefi.Attributes["class"] = "dv_detalles_1";
            dv_phase_2Benefi.Attributes["class"] = "dv_detalles_2";

            container_phase_Confirmacion.Visible = true;
            dv_phase_1Confirmacion.Attributes["class"] = "dv_detalles_1";
            dv_phase_2Confirmacion.Attributes["class"] = "dv_detalles_2";
        }

        protected void GridV_InfoSolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Detalles_Solis"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                SolicitudesCs.CurrentSolicitud = Global.List_Solicitudes[index];
                MuestraDetallesSolicitud(index);
            }
        }

        protected void Btn_ContiCaptura_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebSolicitudCompraLE.aspx");
        }
        protected void OcultaConteOpts()
        {
            Lbl_Perfil.Text = "";
            Pnl_DetallesSolicitud.Visible = false;
            Pnl_InfoSolicitudes.Visible = false;
            Pnl_infoCuenta.Visible = false;
            Pnl_solicitudes.Visible = false;
            Pnl_Familiares.Visible = false;
            Pnl_Compras.Visible = false;
        }

        protected void Btn_Recompra_Click(object sender, EventArgs e)
        {
            DateTime fechaActualSF = DateTime.Now;
            string fechaActual = fechaActualSF.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string area = "Legado Educativo";
            string name = "LE - " + Global.NombreContactoTitular + " - " + fechaActual;
            string asunto = "Compra Adicional - Legado Educativo";
            string guidDatosFisc = string.Empty;
            string guidtituDesi = string.Empty;
            string guidsbeneficiarios = string.Empty;

            if (SolicitudesCs.CurrentSolicitud != null)
            {

                if (SolicitudesCs.CurrentSolicitud["estatus"].Equals("Completada"))
                {
                    if (SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"].Equals("True"))
                    {
                        if (SolicitudesCs.CurrentSolicitud["datosFiscales"] is Dictionary<string, object> DatosFisc)
                        {
                            guidDatosFisc = (string)DatosFisc["guidDatosFiscales"];
                        }
                    }
                    if (SolicitudesCs.CurrentSolicitud["titularDesignado"] is Dictionary<string, object> titularDesi)
                    {
                        if (titularDesi.Count > 0)
                        {
                            guidtituDesi = (string)titularDesi["guidTitularDesignado"];
                        }
                    }
                    if (SolicitudesCs.CurrentSolicitud["beneficiarios"] is List<Dictionary<string, object>> beneficiarios)
                    {
                        if (beneficiarios.Count > 0)
                        {
                            foreach (var item in beneficiarios)
                            {
                                int indice = beneficiarios.IndexOf(item);

                                guidsbeneficiarios = (string)item["guidBeneficiario"];
                            }
                        }
                    }
                    if (SolicitudesCs.CurrentSolicitud["cotizaciones"] is List<Dictionary<string, object>> cotizaciones)
                    {
                        if (cotizaciones.Count > 0)
                        {
                            foreach (var item in cotizaciones)
                            {
                                int indice = cotizaciones.IndexOf(item);

                                string guidOferta = (string)item["guidOferta"];
                                string guidProducto = (string)item["guidProducto"];
                                string guidPrograma = (string)item["guidprograma_academico"];

                                var programa = wsConsProgAca.ConsProgramaAcademicoGuid("true", guidPrograma);

                                if (programa[0].mensaje != "Sin Registros")
                                {
                                    switch (programa[0].new_nivelacademico_name)
                                    {
                                        case "Bachillerato":
                                            DeterminaCotizacionCrm(programa[0].new_programaacademicoid, "", "", guidProducto, "", "", "", "", "", "", (string)item["importe"], (string)item["importe"], (string)item["importe"], programa[0].recr_campus_name);
                                            break;

                                        case "Profesional":
                                            DeterminaCotizacionCrm(programa[0].new_programaacademicoid, "", "", guidProducto, "", "", "", (string)item["cantidad_creditos_periodos"], "", "", (string)item["importe"], (string)item["importe"], (string)item["importe"], programa[0].recr_campus_name);
                                            break;

                                        case "Posgrado":
                                            DeterminaCotizacionCrm(programa[0].new_programaacademicoid, "", "", guidProducto, "", "", "", (string)item["cantidad_creditos_periodos"], "", "", (string)item["importe"], (string)item["importe"], (string)item["importe"], programa[0].recr_campus_name);
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            var resultOpp = wsOppor.InsOportunidadContacto(name, area, asunto, Global.guidContactoTitular, "", "", guid_ListaPrecio_LE);

            var resultSoli = wsInsSoliCom.InsSolicitudCompra("LE-SOL-" + Global.NombreContactoTitular, resultOpp.Guid, Global.guidContactoTitular, guidtituDesi, "", "", (string)SolicitudesCs.CurrentSolicitud["udem_requiererecibofiscal"],
                guidDatosFisc, "", (string)SolicitudesCs.CurrentSolicitud["udem_documentosentregadostitular"], (string)SolicitudesCs.CurrentSolicitud["udem_documentosentregadostitulardesignado"], (string)SolicitudesCs.CurrentSolicitud["udem_documentosentregadosbeneficiarios"], "Legado Educativo");
            var resultSol = wsInsBenefi.InsBeneficiario(resultSoli.Guid, guidsbeneficiarios, "", "", "", "", "");
            var resultHeadCoti = wsInsCoti.InsCotizacionHead(guid_ListaPrecio_LE, resultOpp.Guid, "", resultSoli.Guid, name);

            if (resultHeadCoti.Mensaje.Contains("correctamente"))
            {
                var resultProdCoti = wsInsCoti.InsCotizacionProdu(resultHeadCoti.Guid, CotizacionCrm.udem_programaacademico, CotizacionCrm.udem_le_creditosporproducto, CotizacionCrm.udem_le_semestresporproducto, CotizacionCrm.productid,
                CotizacionCrm.uomid, CotizacionCrm.udem_tipodeperiodo, CotizacionCrm.udem_unidadacotizar, CotizacionCrm.udem_cantidadacotizar, CotizacionCrm.udem_le_porcentajebeca, CotizacionCrm.udem_le_semestrestotales,
                CotizacionCrm.quantity, CotizacionCrm.priceperunit, CotizacionCrm.baseamount, CotizacionCrm.new_unidadudem);
                if (resultProdCoti.Mensaje.Contains("correctamente"))
                {
                    string script = "alert('Se genero una compra adicional.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "Redireccionar", script, true);
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
    }
}