using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLegadoEducativo02.ClasesWS;

namespace WebLegadoEducativo02
{
    public partial class WebSolicitudCompraLE : System.Web.UI.Page
    {
        public class Global
        {
            public static string[,] Arrcp { get; set; }
            public static string[,] Arresccue { get; set; }
            public static string[,] GuidTitular { get; set; }
            public static string[,] GuidTitularDesi { get; set; }
            public static string[,] GuidBeneficiario { get; set; }
            public static bool AvisoPrivacidad { get; set; }
            public static bool ReciboFiscal { get; set; }
            public static string GuidOportunidad { get; set; }
            public static int NumBeneficiarios { get; set; }

        }
        WS_LE_ConsCP.WS_LE_ConsCP cp = new WS_LE_ConsCP.WS_LE_ConsCP();
        //WS_LE_ConsNivelAcademico.WS_LE_ConsNivelAcademico wscne = new WS_LE_ConsNivelAcademico.WS_LE_ConsNivelAcademico();
        WS_LE_ConsEscuelaCuenta.WS_LE_ConsEscuelaCuenta wscec = new WS_LE_ConsEscuelaCuenta.WS_LE_ConsEscuelaCuenta();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Global.NumBeneficiarios = 1;
                Global.ReciboFiscal = false;

                pnl_BoolReciboFiscal.Visible = false;
                Pnl_BoolDireccionFiscal.Visible = false;
                pnl_BoolBeneficiarioExtra.Visible = false;
                Pnl_BoolVerificaTitular.Visible = false;
                pnl_BoolVerificaInfoFiscal.Visible = false;

                Pnl_ReciboFiscal.Visible = false;
                Pnl_TitularDesignado.Visible = false;
                Pnl_Beneficiario.Visible = false;
                pnl_FuenteLead.Visible = false;
                pnl_Solicitud.Visible = false;


                txtB_NombreInstiProce.Visible = false;
                lbl_CorreoBoolTitular.Text = Session["Usuario"].ToString();
            }

            if (Global.ReciboFiscal == true)
            {
                RBtnl_ReciboFiscalSoli.SelectedValue = "True";
            }
        }

        protected void LimpiaFormInfoFiscal()
        {
            txtB_NomComerVerificaDatFisc.Text = string.Empty;
            txtB_RazonSociVerificaDatFisc.Text = string.Empty;
            txtB_RFCVerificaDatFisc.Text = string.Empty;
            txtB_CalleVerificaDatFisc.Text = string.Empty;
            txtB_NumeroVerificaDatFisc.Text = string.Empty;
            txtB_CodigoPostalVerificaDatFisc.Text = string.Empty;
            ddl_ColoniaVerificaDatFisc.ClearSelection();
            ddl_ColoniaVerificaDatFisc.Items.Clear();
            txtB_EstadoVerificaDatFisc.Text = string.Empty;
            txtB_MunicipioVerificaDatFisc.Text = string.Empty;
            txtB_PaisVerificaDatFisc.Text = string.Empty;
        }

        protected void RellenaFormInfoFiscal()
        {
            txtB_NomComerVerificaDatFisc.Text = txtB_NombreComercial.Text;
            txtB_RazonSociVerificaDatFisc.Text = txtB_RazonSocial.Text;
            txtB_RFCVerificaDatFisc.Text = txtB_RFCReciboFiscal.Text;
            txtB_CalleVerificaDatFisc.Text = txtB_CalleReciboFiscal.Text;
            txtB_NumeroVerificaDatFisc.Text = txtB_NumeroReciboFiscal.Text;
            txtB_CodigoPostalVerificaDatFisc.Text = txtB_CodigoPostalReciboFiscal.Text;
            ddl_ColoniaVerificaDatFisc.Items.Add(Ddl_ColoniaReciboFiscal.SelectedItem.Text);
            txtB_EstadoVerificaDatFisc.Text = txtB_EstadoReciboFiscal.Text;
            txtB_MunicipioVerificaDatFisc.Text = txtB_Municipio.Text;
            txtB_PaisVerificaDatFisc.Text = txtB_PaisReciboFiscal.Text;
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
            txtB_FechaNacVerificaTitular.Text = txtB_FechaNacTitular.Text;
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
        protected void Btn_CorreoBoolTrueTitular_Click(object sender, EventArgs e)
        {

            WS_LE_ConsultaContac.WS_LE_ConsultaContac wsconContact = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
            var dats = wsconContact.ConsultaContactCorreo(Session["Usuario"].ToString(), "", "");

            txtB_NombrePilaTitular.Text = dats[0].firstname;
            txtB_SeguNomTitular.Text = dats[0].middlename;
            txtB_ApePaterTitular.Text = dats[0].new_apellidopaterno;
            txtB_ApeMaterTitular.Text = dats[0].new_apellidomaterno;
            txtB_FechaNacTitular.Text = Convert.ToDateTime(dats[0].new_fechacompletanacimiento).ToString("dd/MM/yyyy");
            txtB_movilTitular.Text = dats[0].mobilephone;
            txtB_TelCasaTitular.Text = dats[0].telephone2;
            txtB_CorreoElecTitular.Text = dats[0].emailaddress1;
            txtB_CorreoElecTitular.Enabled = false;
            txtB_Calle.Text = dats[0].address1_line1;
            txtB_Numero.Text = dats[0].address1_line2;
            txtB_CodigoPostal.Text = dats[0].recr_codigopostal;
            RadioBL_TitularExaudem.SelectedValue = dats[0].new_exalumno;

            try
            {
                int chknumber = Convert.ToInt32(txtB_CodigoPostal.Text);
                ddl_colonia.Items.Clear();
                txtB_Estado.Text = "";
                Carga_CP();
            }
            catch (Exception ex)
            {
                txtB_CodigoPostal.Text = "";
                txtB_CodigoPostal.Focus();
            }

            Pnl_boolTitular.Visible = false;
            pnl_Titular.Visible = true;
        }
        protected void Btn_CorreoBoolFalseTitular_Click(object sender, EventArgs e)
        {
            Pnl_boolTitular.Visible = false;
            txtB_CorreoElecTitular.Enabled = true;
            pnl_Titular.Visible = true;
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
                ddl_colonia.SelectedItem.Text = Global.Arrcp[ind - 1, 1];
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


        protected void TxtB_CP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int chknumber = Convert.ToInt32(txtB_CodigoPostal.Text);
                ddl_colonia.Items.Clear();
                txtB_Estado.Text = "";
                Carga_CP();
            }
            catch (Exception ex)
            {
                txtB_CodigoPostal.Text = "";
                txtB_CodigoPostal.Focus();
            }
        }

        protected void Btn_EnviarTitular_Click(object sender, EventArgs e)
        {
            WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
            var result = wsic.InsContact(txtB_NombrePilaTitular.Text, txtB_SeguNomTitular.Text, txtB_ApePaterTitular.Text, txtB_ApeMaterTitular.Text, "", txtB_FechaNacTitular.Text, txtB_movilTitular.Text, txtB_TelCasaTitular.Text, "", txtB_CorreoElecTitular.Text, txtB_Calle.Text, txtB_Numero.Text, txtB_CodigoPostal.Text, ddl_colonia.Text, txtB_Estado.Text, txtB_Municipio.Text, txtB_Pais.Text, "", "Sí", "Sí", "No", "No", "", "");

            string[] subSTitular = result.Guid.Split('|', ' ');
            Global.GuidTitular = new string[1, 5];
            Global.GuidTitular[0, 0] = subSTitular[0];
            Global.GuidTitular[0, 1] = txtB_NombrePilaTitular.Text;
            Global.GuidTitular[0, 2] = txtB_SeguNomTitular.Text;
            Global.GuidTitular[0, 3] = txtB_ApePaterTitular.Text;
            Global.GuidTitular[0, 4] = txtB_ApeMaterTitular.Text;

            Btn_EnviarTitular.Enabled = false;
            Pnl_BoolVerificaTitular.Visible = false;
            pnl_Titular.Visible = false;
            Pnl_ReciboFiscal.Visible = true;
            pnl_BoolReciboFiscal.Visible = true;

            if (result.CodigoMs.Contains("correctamente"))
            {
                dv_phase_1Titu.Attributes["class"] = "dv_phase_1_Check";
                dv_phase_2Titu.Attributes["class"] = "dv_phase_2_Check";
            }
            else
            {
                dv_phase_1Titu.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Titu.Attributes["class"] = "dv_phase_2_Warning";
            }
        }

        protected void Btn_Bool_TrueReciboFiscal_Click(object sender, EventArgs e)
        {
            Pnl_BoolDireccionFiscal.Visible = true;
            Pnl_ReciboFiscal.Visible = true;
            pnl_BoolReciboFiscal.Visible = false;
            Global.ReciboFiscal = true;
        }

        protected void Btn_Bool_FalseReciboFiscal_Click(object sender, EventArgs e)
        {
            Pnl_ReciboFiscal.Visible = false;
            pnl_BoolReciboFiscal.Visible = false;
            Pnl_TitularDesignado.Visible = true;
            Global.ReciboFiscal = false;
        }

        protected void Btn_BoolTrueDireccionFiscal_Click(object sender, EventArgs e)
        {
            WS_LE_ConsultaContac.WS_LE_ConsultaContac wsconContact = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
            var dats = wsconContact.ConsultaContactCorreo(Session["Usuario"].ToString(), "", "");

            txtB_CodigoPostalReciboFiscal.Text = dats[0].recr_codigopostal;
            txtB_CalleReciboFiscal.Text = dats[0].address1_line1;
            txtB_NumeroReciboFiscal.Text = dats[0].address1_line2;
            txtB_CalleReciboFiscal.Text = dats[0].address1_line1;
            txtB_EstadoReciboFiscal.Text = dats[0].new_estadodecontacto;

            try
            {
                int chknumber = Convert.ToInt32(txtB_CodigoPostalReciboFiscal.Text);
                Ddl_ColoniaReciboFiscal.Items.Clear();
                txtB_EstadoReciboFiscal.Text = "";
                Carga_CP_DireccionFiscal();
            }
            catch (Exception ex)
            {
                txtB_CodigoPostalReciboFiscal.Text = "";
                txtB_CodigoPostalReciboFiscal.Focus();
            }
            Pnl_BoolDireccionFiscal.Visible = false;
        }

        protected void Btn_BoolFalseDireccionFiscal_Click(object sender, EventArgs e)
        {
            Pnl_BoolDireccionFiscal.Visible = false;
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
            catch (Exception ex)
            {
                txtB_CodigoPostalReciboFiscal.Text = "";
                txtB_CodigoPostalReciboFiscal.Focus();
            }
        }

        protected void Btn_EnviarDatosFiscales_Click(object sender, EventArgs e)
        {
            WS_LE_ConsultaContac.WS_LE_ConsultaContac wsconContact = new WS_LE_ConsultaContac.WS_LE_ConsultaContac();
            var dats = wsconContact.ConsultaContactCorreo(Session["Usuario"].ToString(), "", "");

            WS_LE_InsertaDatosFiscalesContacto.WS_LE_InsertaDatosFiscalesContacto wsinsdfc = new WS_LE_InsertaDatosFiscalesContacto.WS_LE_InsertaDatosFiscalesContacto();
            var datsFisc = wsinsdfc.InsDatosFiscalesID(dats[0].contactid, "", txtB_NombreComercial.Text, txtB_RazonSocial.Text, txtB_RFCReciboFiscal.Text, txtB_PaisReciboFiscal.Text, txtB_EstadoReciboFiscal.Text, txtB_MunicipioReciboFiscal.Text, Ddl_ColoniaReciboFiscal.Text, txtB_CalleReciboFiscal.Text + " " + txtB_NumeroReciboFiscal.Text, "", txtB_CodigoPostalReciboFiscal.Text, "", "");

            Pnl_ReciboFiscal.Visible = false;
            Pnl_TitularDesignado.Visible = true;
            pnl_BoolVerificaInfoFiscal.Visible = false;


            if (datsFisc.CodigoMs.Contains("correctamente"))
            {
                dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_Check";
                dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_Check";
            }
            else
            {
                dv_phase_1DatosFisc.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2DatosFisc.Attributes["class"] = "dv_phase_2_Warning";
            }
        }

        protected void Btn_EnviaTituDesi_Click(object sender, EventArgs e)
        {
            if (ConfirmaPrimNomTituDesi.Text != string.Empty)
            {
                string[] subSContacto = Global.GuidTitular[0, 0].Split('|', ' ');

                WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
                var result = wsic.InsContact(txtB_PrimNomTituDesi.Text, txtB_SegunNomTituDesi.Text, txtB_ApePaterTituDesi.Text, txtB_ApeMaterTituDesi.Text, "", txtB_FechaNacTituDesi.Text, txtB_MovilTituDesi.Text, txtB_TelCasaTituDesi.Text, "", txtB_CorreoElecTituDesi.Text, "", "", "", "", "", "", "", "", "Sí", "No", "Sí", "No", "", "");


                string[] subSFamiliar = result.Guid.Split('|', ' ');

                Global.GuidTitularDesi = new string[1, 5];
                Global.GuidTitularDesi[0, 0] = subSFamiliar[0];
                Global.GuidTitularDesi[0, 1] = txtB_PrimNomTituDesi.Text;
                Global.GuidTitularDesi[0, 2] = txtB_SegunNomTituDesi.Text;
                Global.GuidTitularDesi[0, 3] = txtB_ApePaterTituDesi.Text;
                Global.GuidTitularDesi[0, 4] = txtB_ApeMaterTituDesi.Text;

                WS_LE_InsertaFamilia.WS_LE_InsertaFamilia wsifc = new WS_LE_InsertaFamilia.WS_LE_InsertaFamilia();
                var fcdats = wsifc.InsFamiliar(txtB_PrimNomTituDesi.Text, txtB_SegunNomTituDesi.Text, txtB_ApePaterTituDesi.Text, txtB_ApeMaterTituDesi.Text, "No", subSContacto[0].ToString(), subSFamiliar[0].ToString(), ddl_ParentescoTituDesi.SelectedItem.Text, "", "", txtB_MovilTituDesi.Text, txtB_CorreoElecTituDesi.Text, "", "", "", "", "", "");

                Pnl_TitularDesignado.Visible = false;
                Pnl_Beneficiario.Visible = true;

                if (result.CodigoMs.Contains("correctamente") && fcdats.Mensaje.Contains("correctamente"))
                {
                    dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1_Check";
                    dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2_Check";
                }
                else
                {
                    dv_phase_1TituDesi.Attributes["class"] = "dv_phase_1_Warning";
                    dv_phase_2TituDesi.Attributes["class"] = "dv_phase_2_Warning";
                }
            }
        }

        protected void Ddl_NivelProcede_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_NombreInstiProce.Items.Clear();
            ddl_EstadoInstiProce.Items.Clear();
            txtB_NombreInstiProce.Text = string.Empty;
            txtB_NombreInstiProce.Visible = false;
            ddl_NombreInstiProce.Visible = true;

            string ItemddlNivel = ddl_NivelProcede.SelectedItem.Text.ToString();

            string _nivel = "";

            switch (ItemddlNivel)
            {
                case "Primaria":
                    _nivel = "Secundaria";
                    break;

                case "Secundaria":
                    _nivel = "Bachillerato";
                    break;

                case "Bachillerato":
                    _nivel = "Profesional";
                    break;

                case "Profesional":
                    _nivel = "Posgrado";
                    break;

                case "Posgrado":
                    _nivel = "Doctorado";
                    break;
            }

            var escuela = wscec.ConsEscuela(_nivel);

            int ind = 0;
            ListItem i;
            Global.Arresccue = new string[escuela.Count(), 2];
            ddl_NombreInstiProce.Items.Insert(0, new ListItem("---Seleccione Escuela---", "0"));

            foreach (var dato in escuela)
            {
                i = new ListItem(dato.name + "      [" + dato.address1_stateorprovince + "]", ind + 1.ToString());
                ddl_NombreInstiProce.Items.Add(i);
                Global.Arresccue[ind, 0] = dato.name;
                Global.Arresccue[ind, 1] = dato.address1_stateorprovince;
                ind = ind + 1;
            }
        }

        protected void Ddl_NombreInstiProce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_NombreInstiProce.SelectedItem.Text.Contains("No se encuentra en la lista"))
            {
                txtB_NombreInstiProce.Visible = true;
                ddl_NombreInstiProce.Visible = false;
            }
            ddl_EstadoInstiProce.Items.Clear();

            if (ddl_NombreInstiProce.SelectedIndex > 0)
            {
                if (!ddl_NombreInstiProce.SelectedItem.Text.Contains("No se encuentra en la lista"))
                {
                    int opt = Convert.ToInt32(ddl_NombreInstiProce.SelectedIndex) - 1;
                    if (Global.Arresccue[opt, 1] != null)
                    {
                        ListItem ii = new ListItem(Global.Arresccue[opt, 1]);
                        ddl_EstadoInstiProce.Items.Add(ii);
                    }
                }
            }
        }

        protected void Btn_EnviaBeneficiario_Click(object sender, EventArgs e)
        {

            string[] subSContacto = Global.GuidTitular[0, 0].Split('|', ' ');

            WS_LE_InsertaContactos.WS_LE_InsertaContactos wsic = new WS_LE_InsertaContactos.WS_LE_InsertaContactos();
            var result = wsic.InsContact(txtB_PrimNomBenefi.Text, txtB_SegunNomBenefi.Text, txtB_AperPaterBenefi.Text, txtB_AperMaterBenefi.Text, "", txtB_FechaNacBenefi.Text, txtB_MovilBenefi.Text, "", "", txtB_CorreoElecBenefi.Text, "", "", "", "", "", "", "", "", "Sí", "No", "No", "Si", "", "");

            string[] subSFamiliar = result.Guid.Split('|', ' ');
            Global.GuidBeneficiario = new string[Global.NumBeneficiarios, 5];
            for (int i = 1; i == Global.NumBeneficiarios; i++)
            {
                Global.GuidBeneficiario[Global.NumBeneficiarios - 1, 0] = subSFamiliar[0];
                Global.GuidBeneficiario[Global.NumBeneficiarios - 1, 1] = txtB_PrimNomBenefi.Text;
                Global.GuidBeneficiario[Global.NumBeneficiarios - 1, 2] = txtB_SegunNomBenefi.Text;
                Global.GuidBeneficiario[Global.NumBeneficiarios - 1, 3] = txtB_AperPaterBenefi.Text;
                Global.GuidBeneficiario[Global.NumBeneficiarios - 1, 4] = txtB_AperMaterBenefi.Text;
            }

            WS_LE_InsertaFamilia.WS_LE_InsertaFamilia wsifc = new WS_LE_InsertaFamilia.WS_LE_InsertaFamilia();
            var fcdats = wsifc.InsFamiliar(txtB_PrimNomBenefi.Text, txtB_SegunNomBenefi.Text, txtB_AperPaterBenefi.Text, txtB_AperMaterBenefi.Text, "", subSContacto[0].ToString(), subSFamiliar[0].ToString(), ddl_ParentescoBenefi.SelectedItem.Text, "", "", txtB_MovilBenefi.Text, txtB_CorreoElecBenefi.Text, "", "", "", "", "", "");

            string[] subSNombreInsti = ddl_NombreInstiProce.SelectedItem.Text.Split('[', ']');

            WS_LE_Oportunidad.WS_LE_Oportunidad wsio = new WS_LE_Oportunidad.WS_LE_Oportunidad();
            var oppdats = wsio.InsertaOportunidad(subSFamiliar[0].ToString(), ddl_NivelProcede.SelectedItem.Text, subSNombreInsti[0].ToString(), txtB_NombreInstiProce.Text, rbl_BecaBenefi.SelectedItem.Text);

            Pnl_Beneficiario.Visible = false;
            pnl_BoolBeneficiarioExtra.Visible = true;

            Global.NumBeneficiarios++;


            if (result.CodigoMs.Contains("correctamente") && fcdats.Mensaje.Contains("correctamente") && oppdats.Codigo.Contains("correctamente"))
            {
                dv_phase_1Benefi.Attributes["class"] = "dv_phase_1_Check";
                dv_phase_2Benefi.Attributes["class"] = "dv_phase_2_Check";
            }
            else
            {
                dv_phase_1Benefi.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Benefi.Attributes["class"] = "dv_phase_2_Warning";
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
            txtB_carreraBenefi.Text = string.Empty;
            txtB_SemestreBenefi.Text = string.Empty;
            txtB_NombreInstiProce.Text = string.Empty;
            rbl_BecaBenefi.ClearSelection();
            ddl_ParentescoBenefi.ClearSelection();
            ddl_NivelProcede.ClearSelection();
            ddl_NombreInstiProce.ClearSelection();
            ddl_EstadoInstiProce.ClearSelection();
        }

        protected void Btn__Bool_trueBeneficiarioExtra_Click(object sender, EventArgs e)
        {
            LimpiaFormBenefi();
            Pnl_Beneficiario.Visible = true;
            pnl_BoolBeneficiarioExtra.Visible = false;
            dv_phase_1Benefi.Attributes["class"] = "dv_phase_1";
            dv_phase_2Benefi.Attributes["class"] = "dv_phase_2";
        }
        protected void Btn__Bool_falseBeneficiarioExtra_Click(object sender, EventArgs e)
        {
            pnl_BoolBeneficiarioExtra.Visible = false;
            pnl_FuenteLead.Visible = false;
            pnl_Solicitud.Visible = true;

            txtB_NombreTituSoli.Text = Global.GuidTitular[0, 1] + " " + Global.GuidTitular[0, 2] + " " + Global.GuidTitular[0, 3] + " " + Global.GuidTitular[0, 4];
            txtB_NombreTituSoli.Enabled = false;

            txtB_NombreTituDesiSoli.Text = Global.GuidTitularDesi[0, 1] + " " + Global.GuidTitularDesi[0, 2] + " " + Global.GuidTitularDesi[0, 3] + " " + Global.GuidTitularDesi[0, 4];
            txtB_NombreTituDesiSoli.Enabled = false;

            txtB_NombreBenefiSoli.Text = Global.GuidBeneficiario[0, 1] + " " + Global.GuidBeneficiario[0, 2] + " " + Global.GuidBeneficiario[0, 3] + " " + Global.GuidBeneficiario[0, 4];
            txtB_NombreBenefiSoli.Enabled = false;
        }

        protected void RBtn_AceptaAvisoPrivacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_AceptaAvisoPrivacidad.Checked == true)
            {
                Global.AvisoPrivacidad = true;
            }
        }

        protected void Btn_ContiAvisoPriva_Click(object sender, EventArgs e)
        {
            if (Global.AvisoPrivacidad == false)
            {
                lbl_AceptaAvisoPrivacidad.Text = "Es necesario aceptar el aviso de privacidad para continuar";
            }
            else
            {
                pnl_AvisoPrivacidad.Visible = false;
            }
        }

        protected void Btn_EnviarSoliCompra_Click(object sender, EventArgs e)
        {
            CrmServiceClient service = null;
            service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            if (service != null)
            {
                if (service.IsReady)
                {


                    Guid __contacto = new Guid(Global.GuidTitular[0, 0]);
                    Guid BuscaOpportunity = Guid.Empty;
                    CatalogosCRM buscaopport = new CatalogosCRM();
                    BuscaOpportunity = buscaopport.getExisteOport(service, __contacto);
                    Global.GuidOportunidad = BuscaOpportunity.ToString();
                }
            }
            WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom wsisc = new WS_LE_InsertaSolicitudCom.WS_LE_InsertaSolicitudCom();
            var result = wsisc.InsSolicitudCompra(Global.GuidOportunidad, Global.GuidTitular[0, 0], Global.GuidTitularDesi[0, 0], "", "", RBtnl_ReciboFiscalSoli.SelectedItem.Text, "", Ddl_FormaPagoSoli.SelectedItem.Text, "Sí", "Sí", "Sí");


            if (result.CodigoMs.Contains("correctamente"))
            {
                dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_Check";
                dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_Check";
            }
            else
            {
                dv_phase_1Confirmacion.Attributes["class"] = "dv_phase_1_Warning";
                dv_phase_2Confirmacion.Attributes["class"] = "dv_phase_2_Warning";
            }
        }

        protected void Btn_BoolfalseVerificaTitular_Click(object sender, EventArgs e)
        {
            LimpiaFormTitular();
            Pnl_BoolVerificaTitular.Visible = false;
            pnl_Titular.Visible = true;
        }

        protected void Btn_EnviarTitularPrevi_Click(object sender, EventArgs e)
        {
            Pnl_BoolVerificaTitular.Visible = true;
            RellenaFormTitular();
        }

        protected void Btn_VeriDatosFiscales_Click(object sender, EventArgs e)
        {
            pnl_BoolVerificaInfoFiscal.Visible = true;
            RellenaFormInfoFiscal();
        }

        protected void btn_VerificaInfoFiscFalse_Click(object sender, EventArgs e)
        {
            LimpiaFormInfoFiscal();
            pnl_BoolVerificaInfoFiscal.Visible = false;
            Pnl_ReciboFiscal.Visible = true;
        }
    }
}