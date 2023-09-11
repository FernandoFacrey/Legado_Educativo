<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebSolicitudCompraLE.aspx.cs" Inherits="WebLegadoEducativo02.WebSolicitudCompraLE" MaintainScrollPositionOnPostback="True" Async="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/CrearCuentaStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JScriptsSolicitudCompra.js" />
        </Scripts>
    </asp:ScriptManager>

    <div id="alertaPersonalizada" class="AlertaCorrecto">
        <asp:Label ID="Lbl_AlertaPersonalizada" runat="server" Text=""></asp:Label>
    </div>

    <!----------Uso de recursos---------->
    <asp:Panel ID="pnl_UsoDeRecursos" runat="server" Visible="false">
        <div id="div_pnl_UsoDeRecursos" class="div_Pnl_AvisoPrivacidad">
            <div id="container01_pnl_UsoDeRecursos" class="container01_AvisoPrivacidad">
                <div id="container02_pnl_UsoDeRecursos" class="container02_AvisoPrivacidad" style="width: 75%">
                    <div class="Container_Btn_close">
                        <asp:Button ID="Btn_Cerrar_UsoDeRecursos" runat="server" Text="X" class="Btn_close" OnClick="Btn_Cerrar_UsoDeRecursos_Click" />
                    </div>
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <div>
                                    <%--<h1 class="fecha_UsoDeDatos">San Pedro Garza García, Nuevo León a <%: DateTime.Now.Day%> de <%: DateTime.Now.Month.ToString("00")%> de <%:DateTime.Now.Year%></h1>--%>
                                    <h2 class="title_UsoDeDatos">Acuerdo de compra</h2>
                                    <div class="div-AvisoPrivacidadtxt">
                                        <p>
                                            Previo a la adquisición de la compra de Legado Educativo; Yo
                                            <asp:Label ID="lbl_NombreTitular_UsoDeDatos" runat="server" Text="" ForeColor="DodgerBlue"></asp:Label>
                                            hago constar bajo protesta de decir verdad que cuento con plena capacidad legal y económica para llevar a cabo la adquisición del Legado Educativo emitido por la Universidad de Monterrey, el cual se compra con recursos propios de procedencia lícita.                                       
                                        </p>
                                        <br />
                                        <p>
                                            Por lo tanto, estoy enterado que deberé dar cumplimiento a las obligaciones fiscales que se deriven de la compra realizada y que, en caso de ser requerida por la autoridad, la Universidad podrá compartir información relacionada con esta adquisición.                                       
                                        </p>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <!----------Aviso de privacidad---------->
    <asp:Panel ID="pnl_AvisoPrivacidad" runat="server" Visible="false">
        <div id="div_pnl_AvisoPrivacidad" class="div_Pnl_AvisoPrivacidad">
            <div id="container01_AvisoPrivacidad" class="container01_AvisoPrivacidad">
                <div id="container02_AvisoPrivacidad" class="container02_AvisoPrivacidad" style="width: 75%">
                    <div class="Container_Btn_close">
                        <asp:Button ID="Btn_AvisoDePrivacidad" runat="server" Text="X" class="Btn_close" OnClick="Btn_AvisoDePrivacidad_Click" />
                    </div>
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <div>
                                    <h1 class="div-AvisoPrivacidad">Aviso  de privacidad</h1>
                                    <div class="div-AvisoPrivacidadtxt">
                                        <p>
                                            Universidad de Monterrey, UDEM, Institución Educativa Privada con domicilio en Avenida Ignacio Morones Prieto, Número 4500 Poniente, Piso 4, Colonia Jesús M. Garza, Municipio San Pedro Garza García, Nuevo León, Código Postal 66238, México, sitio web: <a href="www.udem.edu.mx">www.udem.edu.mx</a>, correo electrónico datospersonales@udem.edu, teléfono (81) 8215-1000 ext. 2000 y horario de atención de lunes a jueves de 10 a 13h; hace de su conocimiento que sus datos personales de identificación y de contacto de usted, así como académica de terceros se relacionan con brindar atención al cliente y la prestación de servicios de trámites administrativos relacionados con los legados educativos. Adicionalmente tratamos sus datos personales con fines de beneficios extraordinarios, invitaciones a eventos, encuestas y mercadotecnia.
                                    Conozca la versión Integral de este Aviso de Privacidad en nuestro sitio web oficial <a href="www.udem.edu.mx">www.udem.edu.mx</a>.
                                        </p>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <!--Paneles Booleanos-->
    <asp:Panel ID="Pnl_boolCompra" runat="server" Visible="false">
        <div id="div_Pnl_boolCompra" class="div_PantallaEmergente">
            <div id="container01_boolCompra" class="container01_PantallaEmergente" style="width: 75%;">
                <div id="container02_boolCompra" class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div>
                                    <div>
                                        <div style="margin-bottom: 3%; border-bottom: .1vw solid #e6e6e6;">
                                            <p class="secciones">CÁLCULO PARA EL COTIZADOR LEGADO EDUCATIVO</p>
                                        </div>
                                    </div>
                                    <div>
                                        <div>
                                            <table>
                                                <tr>
                                                    <td style="width: 60%">
                                                        <div class="dv_containerPrimCol">
                                                            <div class="dv_titulo">
                                                                <%--<asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>--%>
                                                                <p class="titleCampos">Programa académico</p>
                                                            </div>
                                                            <div>
                                                                <asp:Label ID="Verifica_ProgramaAplicarLE" runat="server" Text="" CssClass="txtcol1" Style=""></asp:Label>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <p class="tituloMontoTotal01">PAGO TOTAL DEL SEMESTRE</p>
                                                        <div class="dv_montoTotal01">
                                                            <asp:Label ID="Verifica_lbl_Total" runat="server" Text="" CssClass="montoTotal01"></asp:Label>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <div class="dv_containerPrimCol">
                                                            <div class="dv_titulo">
                                                                <asp:Label ID="Llb_Verifica_CreditosSemestres" runat="server" Text="Label" class="titleCampos"></asp:Label>
                                                            </div>
                                                            <div>
                                                                <asp:Label ID="Verifica_CreditosAplicarLE" runat="server" Text="" CssClass="montoTotal01"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <p class="p_NotaPrecios">
                                                            * Los precios arrojados por el simulador de costos son estimaciones y no necesariamente representan el precio final.
                                                        </p>
                                                        <p class="p_NotaPrecios">
                                                            * Información sujeta a cambios sin previo aviso.
                                                        </p>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <p class="detalleDeCostos">
                                                            Detalle de costo
                                                        </p>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="background-color: #f5f5f5; margin-bottom: 2%; padding: 2%;">
                                                        <div class="costos">
                                                            <div>
                                                                Pago inicial
                                                            </div>
                                                            <div>
                                                                <asp:Label ID="Verifica_lbl_Total02" runat="server" Text=""></asp:Label>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="background-color: #403b33; color: white; padding: 1%; font-weight: 600;">
                                                        <div class="costos">
                                                            <div>
                                                                PAGO TOTAL DEL SEMESTRE
                                                            </div>
                                                            <div>
                                                                <asp:Label ID="Verifica_lbl_Total03" runat="server" Text=""></asp:Label>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <p class="p_NotaPrecios">
                                                            * Los precios arrojados por el simulador de costos son estimaciones y no necesariamente representan el precio final. Información sujeta a cambios sin previo aviso.
                                                        </p>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style="display: flex;">
                                    <div style="width: 50%; padding: 0% 10%;">
                                        <asp:Button ID="Btn_boolTrueCompra" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_boolTrueCompra_Click" OnClientClick="showLoadingEnviaSolicitud().then(() => Btn_boolTrueCompra_Click())" />
                                    </div>
                                    <div style="width: 50%; padding: 0% 10%;">
                                        <asp:Button ID="Btn_boolFalseCompra" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn_boolFalseCompra_Click" />
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnl_BoolCotizacionExtra" runat="server" Visible="false">
        <div class="div_PantallaEmergente">
            <div class="container01_PantallaEmergente">
                <div class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div>
                                    <asp:Label CssClass="secciones" ID="lbl_CotizacionExtra" runat="server" Text="Cotización adicional"></asp:Label><br />
                                    <br />
                                </div>
                                <div class="txtInicio">
                                    <p style="text-align: justify;">
                                        ¿Te gustaria agregar una cotización adicional a este certificado?
                                    </p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div>
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn__Bool_trueCotizacionExtra" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn__Bool_trueCotizacionExtra_Click" />
                                                </td>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn__Bool_falseCotizacionExtra" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn__Bool_falseCotizacionExtra_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_BoolReciboFiscal" runat="server" Visible="false">
        <div id="div_pnl_BoolReciboFiscal" class="div_PantallaEmergente">
            <div id="container01_BoolReciboFiscal" class="container01_PantallaEmergente">
                <div id="container02_BoolReciboFiscal" class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div>
                                    <asp:Label CssClass="secciones" ID="lbl_ReciboFiscal" runat="server" Text="Recibo Fiscal"></asp:Label><br />
                                    <br />
                                </div>
                                <div class="txtInicio">
                                    <p style="text-align: justify;">
                                        En caso de requerir recibo fiscal marcalo en la opción y llenar los datos de recibo. El comprobante esta exento de IVA e ISR y solo puede ser solicitado al momento de la compra.
                                    </p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div>
                                    <p class="titleCampos">¿Requiere recibo fiscal?</p>
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn_Bool_TrueReciboFiscal" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_Bool_TrueReciboFiscal_Click" />
                                                </td>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn_Bool_FalseReciboFiscal" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn_Bool_FalseReciboFiscal_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_BoolBeneficiarioExtra" runat="server" Visible="false">
        <div id="div_pnl_BoolBeneficiarioExtra" class="div_PantallaEmergente">
            <div id="container01_BoolBeneficiarioExtra" class="container01_PantallaEmergente">
                <div id="container02_BoolBeneficiarioExtra" class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div>
                                    <asp:Label CssClass="secciones" ID="lbl_BeneficiarioExtra" runat="server" Text="Beneficiario adicional"></asp:Label><br />
                                    <br />
                                </div>
                                <div class="txtInicio">
                                    <p style="text-align: justify;">
                                        ¿Te gustaria agregar un beneficiario adicional a este certificado?
                                    </p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div>
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn__Bool_trueBeneficiarioExtra" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn__Bool_trueBeneficiarioExtra_Click" />
                                                </td>
                                                <td style="width: 50%; padding: 0% 15%;">
                                                    <asp:Button ID="Btn__Bool_falseBeneficiarioExtra" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn__Bool_falseBeneficiarioExtra_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
    <!--------------------->

    <!--Paneles de verificación-->
    <asp:Panel ID="Pnl_BoolVerificaTitular" runat="server" Visible="false">
        <div id="div_pnl_BoolVerificaTitular" class="div_PantallaEmergente">
            <div id="container01_BoolVerificaTitular" class="container01_PantallaEmergente">
                <div id="container02_BoolVerificaTitular" class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="secciones">
                                    <p style="text-align: justify;">
                                        ¿Los datos del titular son correctos?
                                    </p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div>
                                    <div>
                                        <table class="formulario_table">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Primer nombre del titular</p>
                                                    <asp:TextBox ID="txtB_PrimNomVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Segundo nombre del titular</p>
                                                    <asp:TextBox ID="txtB_SegunNomVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Apellido paterno del titular</p>
                                                    <asp:TextBox ID="txtB_AperPaterVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Apellido materno del titular</p>
                                                    <asp:TextBox ID="txtB_AperMaterVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Fecha de nacimiento del titular</p>
                                                    <asp:TextBox ID="txtB_FechaNacVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Celular del titular</p>
                                                    <asp:TextBox ID="txtB_MovilVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Teléfono de casa del titular</p>
                                                    <asp:TextBox ID="txtB_TelCasaVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Correo electrónico del titular</p>
                                                    <asp:TextBox ID="txtB_CorreoElecVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">¿El titular es ExaUDEM?</p>
                                                    <asp:RadioButtonList ID="RadioBL_VerificaTitularExaudem" CssClass="radioBL" runat="server" RepeatDirection="Horizontal" Enabled="false" Style="width: inherit;">
                                                        <asp:ListItem Value="True">Sí</asp:ListItem>
                                                        <asp:ListItem Value="False">No</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="height: auto;">
                                                    <div>
                                                        <asp:Label CssClass="secciones" ID="lbl_DirVerificaTitular" runat="server" Text="Dirección" Enabled="false"></asp:Label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Calle</p>
                                                    <asp:TextBox ID="txtB_CalleVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Número</p>
                                                    <asp:TextBox ID="txtB_NumeroVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Codigo postal</p>
                                                    <asp:TextBox ID="txtB_CodigoPostalVerificaTitular" runat="server" CssClass="form_campo" OnTextChanged="TxtB_CP_TextChanged" AutoPostBack="True" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Estado</p>
                                                    <asp:TextBox ID="txtB_EstadoVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Colonia</p>
                                                    <asp:DropDownList ID="ddl_coloniaVerificaTitular" runat="server" CssClass="form_DropDownList" Enabled="false" Style="height: 72%"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Municipio</p>
                                                    <asp:TextBox ID="txtB_MunicipioVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">País</p>
                                                    <asp:TextBox ID="txtB_PaisVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="padding-top: 5%;">
                                                    <div style="display: flex;">
                                                        <div id="dv_btn_VerificaTitular" style="width: 50%; padding: 0% 15%;">
                                                            <asp:Button ID="Btn_BoolTrueVerificaTitular" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_EnviarTitular_Click" OnClientClick="showLoadingSoliPantallaEnviaTitular().then(() => Btn_EnviarTitular_Click())" />
                                                        </div>
                                                        <div id="dv_btn_VerificaTitularFalse" style="width: 50%; padding: 0% 15%;">
                                                            <asp:Button ID="Btn_BoolfalseVerificaTitular" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn_BoolfalseVerificaTitular_Click" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_BoolVerificaInfoFiscal" runat="server" Visible="false">
        <div id="div_pnl_BoolVerificaInfoFiscal" class="div_PantallaEmergente">
            <div id="container01_BoolVerificaInfoFiscal" class="container01_PantallaEmergente">
                <div id="container02_BoolVerificaInfoFiscal" class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="secciones">
                                    <p style="text-align: justify;">
                                        ¿Los datos fiscales son correctos?
                                    </p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div>
                                    <div>
                                        <table class="formulario_table">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nombre comercial</p>
                                                    <asp:TextBox ID="txtB_NomComerVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Razón social</p>
                                                    <asp:TextBox ID="txtB_RazonSociVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">R.F.C:</p>
                                                    <asp:TextBox ID="txtB_RFCVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Calle y Número</p>
                                                    <asp:TextBox ID="txtB_CalleNumeroVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Codigo postal</p>
                                                    <asp:TextBox ID="txtB_CodigoPostalVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Colonia</p>
                                                    <asp:DropDownList ID="ddl_ColoniaVerificaDatFisc" runat="server" CssClass="form_DropDownList" Enabled="false" Style="height: 72%"></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Estado</p>
                                                    <asp:TextBox ID="txtB_EstadoVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Municipio</p>
                                                    <asp:TextBox ID="txtB_MunicipioVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">País</p>
                                                    <asp:TextBox ID="txtB_PaisVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="padding-top: 5%;">
                                                    <div style="display: flex;">
                                                        <div id="dv_btn_VerificaInfoFiscTrue" style="width: 50%; padding-right: 10px; display: block;">
                                                            <asp:Button ID="btn_VerificaInfoFiscTrue" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_EnviarDatosFiscales_Click" OnClientClick="showLoadingSoliPantallaEnviaInfoFisc().then(() => Btn_EnviarDatosFiscales_Click())" />
                                                        </div>
                                                        <div id="dv_btn_VerificaInfoFiscFalse" style="width: 50%; padding-left: 10px; display: block;">
                                                            <asp:Button ID="btn_VerificaInfoFiscFalse" CssClass="pager_btn" runat="server" Text="No" OnClick="btn_VerificaInfoFiscFalse_Click" />
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
    <!--------------------->

    <div id="AnimacionCargandoPantalla" style="display: none;">
        <div class="div_Pnl_PantallaCargando">
            <div class="container01_PantallaCargando">
                <div class="container02_PantallaCargando">
                    <div class="General_loaderContainer">
                        <div class="loader_container">
                            <div class="loader"></div>
                            <div class="loader2"></div>
                        </div>
                        <div class="loadertxt_container">
                            <span class="txt_Cargando">Cargando información</span>
                            <div class="loader_text">
                                <span>.</span>
                                <span>.</span>
                                <span>.</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!----------Solicitud de Compra----------->
    <div style="padding: 5%">
        <div style="margin-bottom: 2%;">
            <div style="display: flex; justify-content: center; align-items: center">
                <table class="table_phase">
                    <tr style="display: flex; align-items: flex-end; justify-content: center;">
                        <td>
                            <div>
                                <h4 class="text_check">Titular
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1Titu" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2Titu" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckTitu" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckTitu_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_Titu" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div>
                                <h4 class="text_check">Datos fiscales
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1DatosFisc" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2DatosFisc" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckDatosFiscales" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckDatosFiscales_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_DatosFis" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div>
                                <h4 class="text_check">Titular designado
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1TituDesi" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2TituDesi" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckTituDesi" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckTituDesi_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_TituDesi" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div>
                                <h4 class="text_check">Cotización
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1Cotizacion" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2Cotizacion" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckCotizacion" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckCotizacion_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_Cotizacion" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div>
                                <h4 class="text_check">Beneficiario
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1Benefi" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2Benefi" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckBenefi" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckBenefi_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_Benefi" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div>
                                <h4 class="text_check">Adjuntar documentos y confirmación de compra
                                </h4>
                            </div>
                            <div class="container_dv_phase">
                                <div id="dv_phase_1Confirmacion" class="dv_phase_1" runat="server">
                                    <div id="dv_phase_2Confirmacion" class="dv_phase_2" runat="server">
                                        <asp:Button ID="Btn_CheckConfirmacion" runat="server" Text="✔" CssClass="check" OnClick="Btn_CheckConfirmacion_Click" />
                                    </div>
                                </div>
                                <div id="indicador_phase_Confirmacion" class="indicador_phase" runat="server">
                                </div>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="form">
            <table id="formulario" style="width: 100%">
                <tr>
                    <td colspan="2">

                        <!--Titular-->
                        <div>
                            <asp:Panel ID="pnl_Titular" runat="server" Visible="false">
                                <table class="formulario_table">
                                    <tr>
                                        <td colspan="2">
                                            <div>
                                                <asp:Label CssClass="secciones" ID="Lbl_MasInfo" runat="server" Text="Titular"></asp:Label>
                                            </div>
                                            <div>
                                                <p class="subtitle">
                                                    Se refiere a la persona física o moral, cuyos datos generales de identificación se especifican en el documento en el aparato del titular. Y que tiene los derechos de uso y goce.
                                                </p>
                                                <br />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Primer nombre del titular</p>
                                            <asp:TextBox ID="txtB_NombrePilaTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombrePilaTitular" runat="server" ControlToValidate="txtB_NombrePilaTitular" ErrorMessage="Primer Nombre Requerido" ForeColor="Red" ValidationGroup="VGTitular">Primer Nombre Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Segundo nombre del titular</p>
                                            <asp:TextBox ID="txtB_SeguNomTitular" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Apellido paterno del titular</p>
                                            <asp:TextBox ID="txtB_ApePaterTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaApePaterTitular" runat="server" ControlToValidate="txtB_ApePaterTitular" ErrorMessage="Apellido paterno Requerido" ForeColor="Red" ValidationGroup="VGTitular">Apellido paterno Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Apellido materno del titular</p>
                                            <asp:TextBox ID="txtB_ApeMaterTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaApeMaterTitular" runat="server" ControlToValidate="txtB_ApeMaterTitular" ErrorMessage="Apellido materno Requerido" ForeColor="Red" ValidationGroup="VGTitular">Apellido materno Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div style="display: flex; align-items: center; padding: .4% 0%;">
                                                <div style="width: 35%;">
                                                    <p class="titleCampos">Fecha de nacimiento del titular</p>
                                                </div>
                                                <div style="display: flex;">
                                                    <asp:RegularExpressionValidator ID="Valida_txtB_FechaNacTitular" runat="server" ControlToValidate="txtB_FechaNacTitular" CssClass="requeridos"
                                                        ErrorMessage="Por favor, introduzca una fecha válida en formato dd/mm/yyyy"
                                                        ValidationExpression="^((0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4}))|((\d{4})[-\/](0?[1-9]|1[0-2])[-\/](0?[1-9]|[12][0-9]|3[01]))$"
                                                        ValidationGroup="VGTitular"></asp:RegularExpressionValidator>
                                                </div>
                                            </div>
                                            <asp:TextBox ID="txtB_FechaNacTitular" runat="server" CssClass="form_campo" TextMode="Date"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacTitular" runat="server" ControlToValidate="txtB_FechaNacTitular" ErrorMessage="Fecha de nacimiento Requerido" ForeColor="Red" ValidationGroup="VGTitular">Fecha de Nacimiento Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>

                                            <div style="display: flex; width: 100%">
                                                <p class="titleCampos">Celular del titular</p>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_movilTitular" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VGTitular"></asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="txtB_movilTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilTitular" runat="server" ControlToValidate="txtB_movilTitular" ErrorMessage="Numero de celular Requerido" ForeColor="Red" ValidationGroup="VGTitular">Numero de celular Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div style="display: flex; width: 100%">
                                                <p class="titleCampos">Teléfono de casa del titular</p>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_TelCasaTitular" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VGTitular"></asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="txtB_TelCasaTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTelCasaTitular" runat="server" ControlToValidate="txtB_TelCasaTitular" ErrorMessage="Teléfono de casa Requerido" ForeColor="Red" ValidationGroup="VGTitular">Teléfono de casa Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <div style="display: flex; align-items: center; padding: 0.3% 0%;">
                                                <div style="width: 33%;">
                                                    <p class="titleCampos">Correo electrónico del titular</p>
                                                </div>
                                                <div style="display: flex; align-items: center;">
                                                    <asp:RegularExpressionValidator ID="Valida_txtB_CorreoElecTitular" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoElecTitular"
                                                        ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                                        ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                                        ValidationGroup="VGTitular"></asp:RegularExpressionValidator>
                                                </div>
                                            </div>
                                            <asp:TextBox ID="txtB_CorreoElecTitular" runat="server" CssClass="form_campo" TextMode="Email"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecTitular" runat="server" ControlToValidate="txtB_CorreoElecTitular" ErrorMessage="Correo Electronico Requerido" ForeColor="Red" ValidationGroup="VGTitular"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">¿El titular es ExaUDEM?</p>
                                            <asp:RadioButtonList ID="RadioBL_TitularExaudem" CssClass="radioBL" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" OnTextChanged="RadioBL_TitularExaudem_TextChanged">
                                                <asp:ListItem Value="True">Sí</asp:ListItem>
                                                <asp:ListItem Value="False">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTitularExaudem" runat="server" ControlToValidate="RadioBL_TitularExaudem" ErrorMessage="Titular ExaUDEM Requerido" ForeColor="Red" ValidationGroup="VGTitular"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td id="td_Matricula_titular" runat="server" visible="false">
                                            <p class="titleCampos">Matricula del titular</p>
                                            <asp:TextBox ID="TxtB_Matricula_Titular" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_Matricula_MasInfo" runat="server" ControlToValidate="TxtB_Matricula_Titular" ErrorMessage="Matricula titular requerida" ForeColor="Red" ValidationGroup="VGTitular"></asp:RequiredFieldValidator>
                                        </td>
                                        <td id="td_NivelEgreso_titular" runat="server" visible="false">
                                            <p class="titleCampos">Nivel de egreso del titular</p>
                                            <asp:DropDownList ID="Ddl_NivelEgreso_Titular" runat="server" CssClass="form_DropDownList">
                                                <asp:ListItem Value="0">--- Selecionar Nivel ---</asp:ListItem>
                                                <asp:ListItem Value="1">Bachillerato</asp:ListItem>
                                                <asp:ListItem Value="2">Profesional</asp:ListItem>
                                                <asp:ListItem Value="3">Posgrado</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_Ddl_NivelEgresoTitular" runat="server" ControlToValidate="Ddl_NivelEgreso_Titular" ErrorMessage="Nivel egreso Requerido" ForeColor="Red" ValidationGroup="VGTitular" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <div>
                                                <asp:Label CssClass="secciones" ID="lbl_Direccion" runat="server" Text="Dirección"></asp:Label>
                                            </div>
                                            <div>
                                                <p class="subtitle">
                                                    Recuerda que debe coincidir con el comprobante de domicilio
                                                </p>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Calle</p>
                                            <asp:TextBox ID="txtB_Calle" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCalleTitular" runat="server" ControlToValidate="txtB_Calle" ErrorMessage="Calle Requerido" ForeColor="Red" ValidationGroup="VGTitular">Calle Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Número</p>
                                            <asp:TextBox ID="txtB_Numero" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNumero" runat="server" ControlToValidate="txtB_Numero" ErrorMessage="Número Requerido" ForeColor="Red" ValidationGroup="VGTitular">Número Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Codigo postal</p>
                                            <asp:TextBox ID="txtB_CodigoPostal" runat="server" CssClass="form_campo" OnTextChanged="TxtB_CP_TextChanged" AutoPostBack="True"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCodigoPostal" runat="server" ControlToValidate="txtB_CodigoPostal" ErrorMessage="Codigo Postal Requerido" ForeColor="Red" ValidationGroup="VGTitular">Codigo Postal Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Estado</p>
                                            <asp:TextBox ID="txtB_Estado" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaEstado" runat="server" ControlToValidate="txtB_Estado" ErrorMessage="Estado Requerido" ForeColor="Red" ValidationGroup="VGTitular">Estado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Colonia</p>
                                            <asp:DropDownList ID="ddl_colonia" runat="server" CssClass="form_DropDownList" AutoPostBack="True"></asp:DropDownList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaColonia" runat="server" ControlToValidate="ddl_colonia" ErrorMessage="Colonia Requerido" ForeColor="Red" ValidationGroup="VGTitular" InitialValue="0">Colonia Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Municipio</p>
                                            <asp:TextBox ID="txtB_Municipio" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMunicipio" runat="server" ControlToValidate="txtB_Municipio" ErrorMessage="Municipio Requerido" ForeColor="Red" ValidationGroup="VGTitular">Municipio Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">País</p>
                                            <asp:TextBox ID="txtB_Pais" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPais" runat="server" ControlToValidate="txtB_Pais" ErrorMessage="País Requerido" ForeColor="Red" ValidationGroup="VGTitular">País Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                                <div id="dv_Btn_EnviarTitular" style="display: block; padding: 0% 40%; width: 20%;" runat="server">
                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviarTitular" runat="server" Text="Enviar" OnClick="Btn_EnviarTitularPrevi_Click" ValidationGroup="VGTitular" />
                                </div>
                            </asp:Panel>
                            <div id="dv_Btn_EditarTitular" style="padding: 0% 40%; width: 20%;" runat="server" visible="false">
                                <asp:Button CssClass="pager_btn" ID="Btn_EditarTitular" runat="server" Text="Editar" OnClick="Btn_EditarTitular_Click" ToolTip="EDITAR TITULAR" />
                            </div>
                        </div>

                        <!--Recibo Fiscal-->
                        <div>
                            <asp:Panel ID="Pnl_ReciboFiscal" runat="server" Visible="false">
                                <table class="formulario_table">
                                    <tr>
                                        <td colspan="2">
                                            <p class="secciones">Información fiscal</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Nombre comercial</p>
                                            <asp:TextBox ID="txtB_NombreComercial" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombreComercial" runat="server" ControlToValidate="txtB_NombreComercial" ErrorMessage="Nombre Comercial Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Razón social</p>
                                            <asp:TextBox ID="txtB_RazonSocial" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaRazonSocial" runat="server" ControlToValidate="txtB_RazonSocial" ErrorMessage="Razon Social Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">R.F.C:</p>
                                            <asp:TextBox ID="txtB_RFCReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaRFCReciboFiscal" runat="server" ControlToValidate="txtB_RFCReciboFiscal" ErrorMessage="RFC Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Calle y Numero</p>
                                            <asp:TextBox ID="txtB_CalleNumeroReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCalleNumeroReciboFiscal" runat="server" ControlToValidate="txtB_CalleNumeroReciboFiscal" ErrorMessage="Calle y numero Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Codigo postal</p>
                                            <asp:TextBox ID="txtB_CodigoPostalReciboFiscal" runat="server" CssClass="form_campo" AutoPostBack="True" OnTextChanged="TxtB_CodigoPostalReciboFiscal_TextChanged"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCodigoPostalReciboFiscal" runat="server" ControlToValidate="txtB_CodigoPostalReciboFiscal" ErrorMessage="Codigo Postal Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Colonia</p>
                                            <asp:DropDownList ID="Ddl_ColoniaReciboFiscal" runat="server" CssClass="form_DropDownList" AutoPostBack="True"></asp:DropDownList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaColoniaReciboFiscal" runat="server" ControlToValidate="Ddl_ColoniaReciboFiscal" ErrorMessage="Colonia Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Estado</p>
                                            <asp:TextBox ID="txtB_EstadoReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaEstadoReciboFiscal" runat="server" ControlToValidate="txtB_EstadoReciboFiscal" ErrorMessage="Estado Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Municipio</p>
                                            <asp:TextBox ID="txtB_MunicipioReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMunicipioReciboFiscal" runat="server" ControlToValidate="txtB_MunicipioReciboFiscal" ErrorMessage="Municipio Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">País</p>
                                            <asp:TextBox ID="txtB_PaisReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPaisReciboFiscal" runat="server" ControlToValidate="txtB_PaisReciboFiscal" ErrorMessage="País Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                                <div id="dv_Btn_EnviarDatosFisc" style="display: block; padding: 0% 40%; width: 20%;" runat="server">
                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviarDatosFiscales" runat="server" Text="Enviar" OnClick="Btn_VeriDatosFiscales_Click" ValidationGroup="VGReciboFiscal" />
                                </div>
                            </asp:Panel>
                            <div id="dv_Btn_EditarDatosFisc" style="padding: 0% 40%; width: 20%;" runat="server" visible="false">
                                <asp:Button CssClass="pager_btn" ID="Btn_EditarDatosFisc" runat="server" Text="Editar" OnClick="Btn_EditarDatosFisc_Click" ToolTip="EDITAR DATOS FISCALES" />
                            </div>
                        </div>

                        <!--Titular Designado-->
                        <div>
                            <asp:Panel ID="Pnl_TitularDesignado" runat="server" Visible="false">
                                <table class="formulario_table">
                                    <tr>
                                        <td colspan="2">
                                            <div>
                                                <asp:Label CssClass="secciones" ID="lblTitularDesignado" runat="server" Text="Titular designado"></asp:Label>
                                            </div>
                                            <div>
                                                <p class="subtitle">
                                                    Se refiere a la persona física o moral, que en ausencia del titular, podrá autorizar el uso de los créditos para el beneficiario y designar a nuevos beneficiarios, adquiere las mismas facultades del titular al fallecimiento de éste <b>(Es quien toma decisiones en ausencia del titular)</b>.
                                                </p>
                                                <br />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Primer nombre del titular designado</p>
                                            <asp:TextBox ID="txtB_PrimNomTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPrimNomTituDesi" runat="server" ControlToValidate="txtB_PrimNomTituDesi" ErrorMessage="Primer Nombre del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Primer Nombre del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Segundo nombre del titular designado</p>
                                            <asp:TextBox ID="txtB_SegunNomTituDesi" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Apellido paterno del titular designado</p>
                                            <asp:TextBox ID="txtB_ApePaterTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaApePaterTituDesi" runat="server" ControlToValidate="txtB_ApePaterTituDesi" ErrorMessage="Apellido paterno del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Apellido paterno del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Apellido materno del titular designado</p>
                                            <asp:TextBox ID="txtB_ApeMaterTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaApeMaterTituDesi" runat="server" ControlToValidate="txtB_ApeMaterTituDesi" ErrorMessage="Apellido materno del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Apellido materno del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <div style="display: flex; align-items: center; padding: .5% 0%;">
                                                <div style="width: 50%;">
                                                    <p class="titleCampos">Fecha de nacimiento del titular designado</p>
                                                </div>
                                                <div style="display: flex;">
                                                    <asp:RegularExpressionValidator ID="Valida_txtB_FechaNacTituDesi" runat="server" ControlToValidate="txtB_FechaNacTituDesi" CssClass="requeridos"
                                                        ErrorMessage="Por favor, introduzca una fecha válida en formato dd/mm/yyyy"
                                                        ValidationExpression="^((0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4}))|((\d{4})[-\/](0?[1-9]|1[0-2])[-\/](0?[1-9]|[12][0-9]|3[01]))$"
                                                        ValidationGroup="VGTituDesi"></asp:RegularExpressionValidator>
                                                </div>
                                            </div>
                                            <asp:TextBox ID="txtB_FechaNacTituDesi" runat="server" CssClass="form_campo" TextMode="Date"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacTituDesi" runat="server" ControlToValidate="txtB_FechaNacTituDesi" ErrorMessage="Fecha de Nacimiento del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Fecha de Nacimiento del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <div style="display: flex; width: 100%; padding: .75%;">
                                                <p class="titleCampos">Celular del titular designado</p>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_MovilTituDesi" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VGTituDesi"></asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="txtB_MovilTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilTituDesi" runat="server" ControlToValidate="txtB_MovilTituDesi" ErrorMessage="Celular del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Celular del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div style="display: flex; width: 100%">
                                                <p class="titleCampos">Teléfono de casa del titular designado</p>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_TelCasaTituDesi" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VGTituDesi"></asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="txtB_TelCasaTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTelCasaTituDesi" runat="server" ControlToValidate="txtB_TelCasaTituDesi" ErrorMessage="Telefono de casa del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Telefono de casa del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <div style="display: flex; align-items: center; padding: .60% 0%;">
                                                <div style="width: 44%;">
                                                    <p class="titleCampos">Correo electrónico del titular designado</p>
                                                </div>
                                                <div style="display: flex; align-items: center;">
                                                    <asp:RegularExpressionValidator ID="Valida_txtB_CorreoElecTituDesi" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoElecTituDesi"
                                                        ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                                        ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                                        ValidationGroup="VGTituDesi"></asp:RegularExpressionValidator>

                                                </div>
                                            </div>
                                            <asp:TextBox ID="txtB_CorreoElecTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecTituDesi" runat="server" ControlToValidate="txtB_CorreoElecTituDesi" ErrorMessage="Correo electrónico del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Correo electrónico del titular designado Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Parentesco con el titular</p>
                                            <asp:DropDownList ID="ddl_ParentescoTituDesi" runat="server" CssClass="form_DropDownList" TabIndex="1">
                                                <asp:ListItem Value="0">--- Seleccionar --</asp:ListItem>
                                                <asp:ListItem Value="1">Tutor</asp:ListItem>
                                                <asp:ListItem Value="2">Nieto(a)</asp:ListItem>
                                                <asp:ListItem Value="3">Padres</asp:ListItem>
                                                <asp:ListItem Value="4">Esposo (a)</asp:ListItem>
                                                <asp:ListItem Value="5">Hijo (a)</asp:ListItem>
                                                <asp:ListItem Value="6">Hermano (a)</asp:ListItem>
                                                <asp:ListItem Value="7">Sobrino (a)</asp:ListItem>
                                                <asp:ListItem Value="8">Primo (a)</asp:ListItem>
                                                <asp:ListItem Value="9">Tio (a)</asp:ListItem>
                                                <asp:ListItem Value="10">Abuelo (a)</asp:ListItem>
                                                <asp:ListItem Value="11">Amigo (a)</asp:ListItem>
                                                <asp:ListItem Value="12">Asistente</asp:ListItem>
                                                <asp:ListItem Value="13">Difunto (a)</asp:ListItem>
                                                <asp:ListItem Value="14">Empleado</asp:ListItem>
                                                <asp:ListItem Value="15">Empleador</asp:ListItem>
                                                <asp:ListItem Value="16">Empresa Filial</asp:ListItem>
                                                <asp:ListItem Value="17">Exempleado (a)</asp:ListItem>
                                                <asp:ListItem Value="18">Exempleador</asp:ListItem>
                                                <asp:ListItem Value="19">Exesposo (a)</asp:ListItem>
                                                <asp:ListItem Value="20">Familiar</asp:ListItem>
                                                <asp:ListItem Value="21">Fundación</asp:ListItem>
                                                <asp:ListItem Value="22">Grupo Empresarial</asp:ListItem>
                                                <asp:ListItem Value="23">Jefe (a) - Director (a)</asp:ListItem>
                                                <asp:ListItem Value="24">Miembro de la Fundación</asp:ListItem>
                                                <asp:ListItem Value="25">Nieto (a)</asp:ListItem>
                                                <asp:ListItem Value="26">Socio (a)</asp:ListItem>
                                                <asp:ListItem Value="27">Subsidiaria</asp:ListItem>
                                                <asp:ListItem Value="28">Viudo (a)</asp:ListItem>
                                                <asp:ListItem Value="29">Cuñado (a)</asp:ListItem>
                                                <asp:ListItem Value="30">Padre</asp:ListItem>
                                                <asp:ListItem Value="31">Madre</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaParentescoTituDesi" runat="server" ControlToValidate="ddl_ParentescoTituDesi" ErrorMessage="Parentesco con el titular Requerido" ForeColor="Red" ValidationGroup="VGTituDesi" InitialValue="0">Parentesco con el titular Requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                                <div id="dv_Btn_EnviarTituDesi" style="display: block; padding: 0% 40%; width: 20%;" runat="server">
                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviaTituDesi" runat="server" ValidationGroup="VGTituDesi" Text="Enviar" OnClick="Btn_EnviaTituDesi_Click" OnClientClick="showLoadingSoliPantallaEnviaTituDesi().then(() => Btn_EnviaTituDesi());" />
                                </div>
                            </asp:Panel>
                            <div id="dv_Btn_EditarTituDesi" style="padding: 0% 40%; width: 20%;" runat="server" visible="false">
                                <asp:Button CssClass="pager_btn" ID="Btn_EditarTituDesi" runat="server" Text="Editar" OnClick="Btn_EditarTituDesi_Click" ToolTip="EDITAR TITULAR DESIGNADO" />
                            </div>
                        </div>

                        <!--Cotización-->
                        <div>
                            <asp:Panel ID="pnl_Cotizacion" runat="server" Visible="false">
                                <div>
                                    <div>
                                        <div>
                                            <p class="secciones">Cotización Legado Educativo</p>
                                        </div>
                                        <div style="padding: 0% 1%; border-bottom: .2vw solid #fff500;">
                                            <p class="subtitle">
                                                Completa los siguientes campos para obtener el costo aproximado por semestre y conocer las opciones de pago que ofrecemos.
                                            </p>
                                        </div>
                                    </div>
                                    <table class="formulario_table">
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Nivel *</p>
                                                <asp:DropDownList ID="Ddl_NivelAplicarLE" runat="server" CssClass="form_DropDownList" AutoPostBack="True" OnSelectedIndexChanged="Ddl_NivelAplicarLE_SelectedIndexChanged"></asp:DropDownList>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_Ddl_NivelAplicarLE" runat="server" ControlToValidate="Ddl_NivelAplicarLE" ErrorMessage="Nivel requerido" ForeColor="Red" InitialValue="0" ValidationGroup="VGCompra"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <asp:Panel ID="Pnl_UniDiviProgAplicarLE" runat="server" Visible="false" Style="height: 100%;">
                                                    <asp:Label ID="Lbl_UniDiviProgAplicarLE" runat="server" Text="" class="titleCampos"></asp:Label>
                                                    <asp:DropDownList ID="Ddl_UniDiviProgAplicarLE" runat="server" CssClass="form_DropDownList" AutoPostBack="True" OnSelectedIndexChanged="Ddl_UniDiviProgAplicarLE_SelectedIndexChanged"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_Ddl_UniDiviProgAplicarLE" runat="server" ControlToValidate="Ddl_UniDiviProgAplicarLE" ErrorMessage="Campo requerido" ForeColor="Red" InitialValue="0" ValidationGroup="VGCompra"></asp:RequiredFieldValidator>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <asp:Panel ID="Pnl_TipoBachProgProf" runat="server" Visible="false" Style="height: 100%;">
                                                <td>
                                                    <asp:Label ID="Lbl_TipoBachProgProfAplicarLE" runat="server" Text="" class="titleCampos"></asp:Label>
                                                    <asp:DropDownList ID="Ddl_TipoBachProgProf" runat="server" CssClass="form_DropDownList" OnSelectedIndexChanged="Ddl_TipoBachProgProf_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_Ddl_TipoBachProgProf" runat="server" ControlToValidate="Ddl_TipoBachProgProf" ErrorMessage="Campo requerido" ForeColor="Red" InitialValue="0" ValidationGroup="VGCompra"></asp:RequiredFieldValidator>
                                                </td>
                                            </asp:Panel>
                                            <asp:Panel ID="Pnl_Creditos" runat="server" Visible="false" Style="height: 100%;">
                                                <td>
                                                    <asp:Label ID="Lbl_CreditosPeriodos" runat="server" Text="" class="titleCampos"></asp:Label>
                                                    <asp:DropDownList ID="Ddl_CreditosAplicarLE" runat="server" CssClass="form_DropDownList"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_Ddl_CreditosAplicarLE" runat="server" ControlToValidate="Ddl_CreditosAplicarLE" ErrorMessage="Créditos requeridos" ForeColor="Red" InitialValue="0" ValidationGroup="VGCompra"></asp:RequiredFieldValidator>

                                                </td>
                                            </asp:Panel>
                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="p_NotaPrecios" style="margin: 0%;">
                                                    (*) Campos obligatorios.
                                                </p>
                                                <p class="p_NotaPrecios">
                                                    - Los precios arrojados por el simulador de costos son estimaciones y no necesariamente representan el precio final.
                                                </p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div>
                                                    <div class="div_AceptoAvisoPrivacidad_txt">
                                                        <asp:CheckBox ID="ChBox_AvisoDePrivacidad" runat="server" Text="He leído y acepto las" CssClass="ChBox_AvisoDePrivacidad" />&nbsp;
                                                <asp:Button ID="Btn_LeerAvisoDePrivacidad" runat="server" Text="políticas de privacidad" CssClass="btn_AvisoDePrivacidad" OnClick="Btn_LeerAvisoDePrivacidad_Click" />
                                                    </div>
                                                    <asp:Label ID="Lbl_AvisoDePrivacidad" runat="server" Text="" CssClass="requeridos"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <div id="dv_Btn_EnviarCotizacion" style="padding: 0% 40%; width: 20%;" runat="server">
                                        <asp:Button CssClass="pager_btn" ID="Btn_CrearCotizacion" runat="server" Text="Confirmar" OnClick="Btn_CrearCotizacion_Click" ValidationGroup="VGCompra" />
                                    </div>
                                </div>
                            </asp:Panel>
                            <div id="Container_GridV_Cotizacion" runat="server" class="Container_GridView" visible="false">
                                <asp:GridView ID="GridV_Cotizacion" CssClass="GridView_Table" runat="server" AutoGenerateColumns="False" OnRowCommand="GridV_Cotizacion_RowCommand">
                                    <Columns>
                                        <asp:BoundField DataField="Nivel" HeaderText="Nivel" HtmlEncode="false" />
                                        <asp:BoundField DataField="DiviUnidad" HeaderText="Division/Unidad" HtmlEncode="false" />
                                        <asp:BoundField DataField="ProgTipBach" HeaderText="Programa/Tipo de bachillerato" HtmlEncode="false" />
                                        <asp:BoundField DataField="Créditos" HeaderText="Créditos" HtmlEncode="false" />
                                        <asp:BoundField DataField="Monto" HeaderText="Monto" HtmlEncode="false" />
                                        <asp:ButtonField ButtonType="Button" Text="Editar 📝" CommandName="Edit_Cotizacion" ControlStyle-CssClass="BtnGridView" ItemStyle-CssClass="CenteredButton" />
                                    </Columns>
                                </asp:GridView>
                                <div id="dv_Btn_NuevaCotizacion" style="padding: 2% 40% 0%;">
                                    <asp:Button CssClass="pager_btn" ID="Btn_NuevaCotizacion" runat="server" Text="Nuevo cotización" OnClick="Btn_NuevaCotizacion_Click" />
                                </div>
                            </div>
                        </div>

                        <!--Beneficiario-->
                        <div>
                            <asp:Panel ID="Pnl_Beneficiario" runat="server" Visible="false">
                                <div>
                                    <table class="formulario_table">
                                        <tr>
                                            <td colspan="2">
                                                <div>
                                                    <asp:Label CssClass="secciones" ID="lbl_Benefi" runat="server" Text="Beneficiario"></asp:Label>
                                                </div>
                                                <div>
                                                    <p class="subtitle">
                                                        Lo constituyen la(s) persona(s) que el titular o el designado nombra para aprovechar la aplicación de lo depositado en el número de créditos. <b>(Es el alumno o futuro alumno UDEM)</b>.
                                                    </p>
                                                    <br />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Primer nombre del beneficiario</p>
                                                <asp:TextBox ID="txtB_PrimNomBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPrimNomBenefi" runat="server" ControlToValidate="txtB_PrimNomBenefi" ErrorMessage="Primer Nombre del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Primer Nombre del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <p class="titleCampos">Segundo nombre del beneficiario</p>
                                                <asp:TextBox ID="txtB_SegunNomBenefi" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Apellido paterno del beneficiario</p>
                                                <asp:TextBox ID="txtB_AperPaterBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaAperPaterBenefi" runat="server" ControlToValidate="txtB_AperPaterBenefi" ErrorMessage="Apellido paterno del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Apellido paterno del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <p class="titleCampos">Apellido materno del beneficiario</p>
                                                <asp:TextBox ID="txtB_AperMaterBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaAperMaterBenefi" runat="server" ControlToValidate="txtB_AperMaterBenefi" ErrorMessage="Apellido materno del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Apellido materno del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>

                                                <div style="display: flex; align-items: center; padding: .5% 0%;">
                                                    <div style="width: 40%;">
                                                        <p class="titleCampos">Fecha de nacimiento del beneficiario</p>
                                                    </div>
                                                    <div style="display: flex;">
                                                        <asp:RegularExpressionValidator ID="Valida_txtB_FechaNacBenefi" runat="server" ControlToValidate="txtB_FechaNacBenefi" CssClass="requeridos"
                                                            ErrorMessage="Por favor, introduzca una fecha válida en formato dd/mm/yyyy"
                                                            ValidationExpression="^((0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4}))|((\d{4})[-\/](0?[1-9]|1[0-2])[-\/](0?[1-9]|[12][0-9]|3[01]))$"
                                                            ValidationGroup="VGBeneficiario"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>

                                                <asp:TextBox ID="txtB_FechaNacBenefi" runat="server" CssClass="form_campo" TextMode="Date"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacBenefi" runat="server" ControlToValidate="txtB_FechaNacBenefi" ErrorMessage="Fecha de Nacimiento del Beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Fecha de nacimiento del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <div style="display: flex; width: 100%">
                                                    <p class="titleCampos">Celular del beneficiario</p>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_MovilBenefi" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VGBeneficiario"></asp:RegularExpressionValidator>
                                                </div>
                                                <asp:TextBox ID="txtB_MovilBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilBenefi" runat="server" ControlToValidate="txtB_MovilBenefi" ErrorMessage="Celular del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Celular del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div style="display: flex; align-items: center;">
                                                    <div style="width: 38%;">
                                                        <p class="titleCampos">Correo electrónico del beneficiario</p>
                                                    </div>
                                                    <div style="display: flex; align-items: center;">
                                                        <asp:RegularExpressionValidator ID="Valida_txtB_CorreoElecBenefi" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoElecBenefi"
                                                            ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                                            ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                                            ValidationGroup="VGBeneficiario"></asp:RegularExpressionValidator>

                                                    </div>
                                                </div>
                                                <asp:TextBox ID="txtB_CorreoElecBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecBenefi" runat="server" ControlToValidate="txtB_CorreoElecBenefi" ErrorMessage="Correo electrónico del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Correo electrónico del beneficiario Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <p class="titleCampos">Parentesco con el titular</p>
                                                <asp:DropDownList ID="ddl_ParentescoBenefi" runat="server" CssClass="form_DropDownList">
                                                    <asp:ListItem Value="0">--- Seleccionar --</asp:ListItem>
                                                    <asp:ListItem Value="1">Tutor</asp:ListItem>
                                                    <asp:ListItem Value="2">Nieto(a)</asp:ListItem>
                                                    <asp:ListItem Value="3">Padres</asp:ListItem>
                                                    <asp:ListItem Value="4">Esposo (a)</asp:ListItem>
                                                    <asp:ListItem Value="5">Hijo (a)</asp:ListItem>
                                                    <asp:ListItem Value="6">Hermano (a)</asp:ListItem>
                                                    <asp:ListItem Value="7">Sobrino (a)</asp:ListItem>
                                                    <asp:ListItem Value="8">Primo (a)</asp:ListItem>
                                                    <asp:ListItem Value="9">Tio (a)</asp:ListItem>
                                                    <asp:ListItem Value="10">Abuelo (a)</asp:ListItem>
                                                    <asp:ListItem Value="11">Amigo (a)</asp:ListItem>
                                                    <asp:ListItem Value="12">Asistente</asp:ListItem>
                                                    <asp:ListItem Value="13">Difunto (a)</asp:ListItem>
                                                    <asp:ListItem Value="14">Empleado</asp:ListItem>
                                                    <asp:ListItem Value="15">Empleador</asp:ListItem>
                                                    <asp:ListItem Value="16">Empresa Filial</asp:ListItem>
                                                    <asp:ListItem Value="17">Exempleado (a)</asp:ListItem>
                                                    <asp:ListItem Value="18">Exempleador</asp:ListItem>
                                                    <asp:ListItem Value="19">Exesposo (a)</asp:ListItem>
                                                    <asp:ListItem Value="20">Familiar</asp:ListItem>
                                                    <asp:ListItem Value="21">Fundación</asp:ListItem>
                                                    <asp:ListItem Value="22">Grupo Empresarial</asp:ListItem>
                                                    <asp:ListItem Value="23">Jefe (a) - Director (a)</asp:ListItem>
                                                    <asp:ListItem Value="24">Miembro de la Fundación</asp:ListItem>
                                                    <asp:ListItem Value="25">Nieto (a)</asp:ListItem>
                                                    <asp:ListItem Value="26">Socio (a)</asp:ListItem>
                                                    <asp:ListItem Value="27">Subsidiaria</asp:ListItem>
                                                    <asp:ListItem Value="28">Viudo (a)</asp:ListItem>
                                                    <asp:ListItem Value="29">Cuñado (a)</asp:ListItem>
                                                    <asp:ListItem Value="30">Padre</asp:ListItem>
                                                    <asp:ListItem Value="31">Madre</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaParentescoBenefi" runat="server" ControlToValidate="ddl_ParentescoBenefi" ErrorMessage="Parentesco con el titular Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" InitialValue="0">Parentesco con el titular Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div>
                                                    <br />
                                                    <asp:Label CssClass="secciones" ID="lbl_IntiProce" runat="server" Text="Insitución de procedencia"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Nos gustaria conocer, ¿Tiene beca?</p>
                                                <asp:RadioButtonList ID="rbl_BecaBenefi" runat="server" CssClass="radioBL" Font-Bold="False" RepeatDirection="Horizontal" OnSelectedIndexChanged="rbl_BecaBenefi_SelectedIndexChanged" AutoPostBack="True">
                                                    <asp:ListItem>Sí</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaBecaBenefi" runat="server" ControlToValidate="rbl_BecaBenefi" ErrorMessage="Tienes beca Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Tienes beca Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <asp:Panel ID="Pnl_PorcentBecaBenefi" runat="server" Visible="false" Enabled="false">
                                                <td>
                                                    <p class="titleCampos">Porcentaje de beca</p>
                                                    <asp:TextBox ID="txtB_PorcentBecaBenefi" runat="server" CssClass="form_campo" AutoCompleteType="None" TextMode="Number"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmatxtB_PorcentBecaBenefi" runat="server" ControlToValidate="txtB_PorcentBecaBenefi" ErrorMessage="Porcentaje de beca Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" Enabled="false"></asp:RequiredFieldValidator>
                                                </td>
                                            </asp:Panel>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div style="display: flex; width: 100%; align-items: flex-end">
                                                    <div style="width: 17%;">
                                                        <p class="titleCampos">Nivel de estudio</p>
                                                    </div>
                                                    <div id="dv_cargandoNivelProcedencia" style="display: none;">
                                                        <div class="loader_text">
                                                            <span>.</span>
                                                            <span>.</span>
                                                            <span>.</span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <asp:DropDownList ID="ddl_NivelProcede" runat="server" CssClass="form_DropDownList" OnSelectedIndexChanged="Ddl_NivelProcede_SelectedIndexChanged" AutoPostBack="True">
                                                    <asp:ListItem Value="0">---Seleccione Nivel---</asp:ListItem>
                                                    <asp:ListItem Value="1">Primaria</asp:ListItem>
                                                    <asp:ListItem Value="2">Secundaria</asp:ListItem>
                                                    <asp:ListItem Value="3">Bachillerato</asp:ListItem>
                                                    <asp:ListItem Value="4">Profesional</asp:ListItem>
                                                    <asp:ListItem Value="5">Posgrado </asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNivelProcede" runat="server" ControlToValidate="ddl_NivelProcede" ErrorMessage="Nivel de estudio Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" InitialValue="0">Nivel de estudio Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <div style="display: flex; width: 100%; align-items: flex-end;">
                                                    <div style="width: 25%;">
                                                        <p class="titleCampos">Nombre de la institución</p>
                                                    </div>
                                                    <div id="dv_cargandoNombreProcedencia" style="display: none;">
                                                        <div class="loader_text">
                                                            <span>.</span>
                                                            <span>.</span>
                                                            <span>.</span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <asp:DropDownList ID="ddl_NombreInstiProce" runat="server" CssClass="form_DropDownList" OnSelectedIndexChanged="Ddl_NombreInstiProce_SelectedIndexChanged"></asp:DropDownList>
                                                <asp:TextBox ID="txtB_NombreInstiProce" runat="server" CssClass="form_campo" Visible="false"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombreInstiProce" runat="server" ControlToValidate="ddl_NombreInstiProce" ErrorMessage="Nombre de la institución Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" InitialValue="0">Nombre de la institución Requerido *</asp:RequiredFieldValidator>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmatxtBNombreInstiProce" runat="server" ControlToValidate="txtB_NombreInstiProce" ErrorMessage="Nombre de la institución Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" Enabled="false" Visible="false">Nombre de la institución Requerido *</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr runat="server" visible="false">
                                            <td>
                                                <div style="display: flex; width: 100%; align-items: flex-end;">
                                                    <div style="width: 8%;">
                                                        <p class="titleCampos">Estado</p>
                                                    </div>
                                                    <div id="dv_cargandoEstadoProcedencia" style="display: none;">
                                                        <div class="loader_text">
                                                            <span>.</span>
                                                            <span>.</span>
                                                            <span>.</span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <asp:DropDownList ID="ddl_EstadoInstiProce" runat="server" CssClass="form_DropDownList" Enabled="false"></asp:DropDownList>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaEstadoInstiProce" runat="server" ControlToValidate="ddl_EstadoInstiProce" ErrorMessage="Estado Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario" Enabled="false"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <div id="dv_Btn_EnviaBeneficiario" style="padding: 0% 40%">
                                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviaBeneficiario" runat="server" Text="Enviar" OnClick="Btn_EnviaBeneficiario_Click" ValidationGroup="VGBeneficiario" OnClientClick="showLoadingSoliPantallaEnviaBenefi().then(() => Btn_EnviaBeneficiario_Click())" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </asp:Panel>
                            <div id="Container_GridV_Beneficiario" runat="server" class="Container_GridView" visible="false">
                                <asp:GridView ID="GridV_Beneficiario" CssClass="GridView_Table" runat="server" AutoGenerateColumns="False" OnRowCommand="GridV_Beneficiario_RowCommand">
                                    <Columns>
                                        <asp:BoundField DataField="Beneficiario" HeaderText="Beneficiario" HtmlEncode="false" />
                                        <asp:ButtonField ButtonType="Button" Text="Editar 📝" CommandName="Edit_Beneficiario" ControlStyle-CssClass="BtnGridView" ItemStyle-CssClass="CenteredButton" />
                                    </Columns>
                                </asp:GridView>
                                <div id="dv_Btn_NuevoBeneficiario" style="padding: 2% 40% 0%;">
                                    <asp:Button CssClass="pager_btn" ID="Btn_NuevoBeneficiario" runat="server" Text="Nuevo beneficiario" OnClick="Btn_NuevoBeneficiario_Click" />
                                </div>
                            </div>
                        </div>

                        <!--Confirmacion Solicitud de compra-->
                        <asp:Panel ID="pnl_Confirmacion" runat="server" Visible="false">
                            <div>
                                <table class="formulario_table">
                                    <tr>
                                        <td colspan="2" style="height: auto;">
                                            <div>
                                                <h1 style="text-align: center; font-size: 2vw;">A continuación, podrás adjuntar los documentos que necesitamos para tu proceso de compra, asi como confirmar tus datos finales </h1>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: auto;">
                                            <div class="Container_GridView">
                                                <asp:GridView ID="GridV_Documentos" CssClass="GridView_Table" runat="server" AutoGenerateColumns="False" OnRowCommand="GridV_Documentos_RowCommand">
                                                    <Columns>
                                                        <asp:BoundField DataField="Quien" HeaderText="General" HtmlEncode="false" />
                                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" HtmlEncode="false" />
                                                        <asp:TemplateField HeaderText="">
                                                            <ItemTemplate>
                                                                <asp:RadioButtonList ID="RadioBL_TipoArchivo" runat="server" CssClass="radioBL_Grids" RepeatDirection="Horizontal" RepeatLayout="Table">
                                                                    <asp:ListItem Value="0">Ine</asp:ListItem>
                                                                    <asp:ListItem Value="1">Pasaporte</asp:ListItem>
                                                                    <asp:ListItem Value="2">Acta de nacimiento</asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="">
                                                            <ItemTemplate>
                                                                <asp:FileUpload ID="file_upload" runat="server" onchange='cambiar()' CssClass="subir" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Button runat="server" ID="BtnEnviarArchivo" Text="Enviar" CommandName="Enviar" OnClientClick="showLoadingSoliPantallaEnviaTituDesi();" CssClass="pager_btn" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: auto;">
                                            <p class="secciones">Monto total</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lbl_MontoConfirmacion" runat="server" Text="" class="titleCampos"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Comprobante de Domicilio (No mayor a 3 meses)</p>
                                            <asp:FileUpload ID="FileU_ComprobanteDomicilio" runat="server" CssClass="subir" />
                                        </td>
                                        <td>
                                            <asp:Button CssClass="pager_btn" ID="Btn_SubirComprobante" runat="server" Text="Enviar" OnClientClick="showLoadingSoliPantallaEnviaTituDesi();" OnClick="Btn_SubirComprobante_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Forma de pago</p>
                                            <asp:DropDownList ID="Ddl_FormaPagoSoli" runat="server" CssClass="form_DropDownList">
                                                <asp:ListItem Value="0">---Seleccione una opcion---</asp:ListItem>
                                                <asp:ListItem Value="1">Tarjeta de débito o crédito</asp:ListItem>
                                                <asp:ListItem Value="2">Ficha de pago</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator1" runat="server" ControlToValidate="Ddl_FormaPagoSoli" ErrorMessage="Forma de pago Requerido" ForeColor="Red" ValidationGroup="VGConfirmaSolicitud" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">¿Requiere recibo fiscal?</p>
                                            <asp:RadioButtonList ID="RBtnl_ReciboFiscalSoli" runat="server" CssClass="radioBL" RepeatDirection="Horizontal" Enabled="false">
                                                <asp:ListItem Value="1">Sí</asp:ListItem>
                                                <asp:ListItem Value="0">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div>
                                                <div class="div_AceptoAvisoPrivacidad_txt">
                                                    <asp:CheckBox ID="chb_UsoDeDatos" runat="server" Text="He leído y acepto el" class="ChBox_AvisoDePrivacidad" />&nbsp;
                                                <asp:Button ID="Btn_LeerUsoDeDatos" runat="server" Text="acuerdo de adquisición de compra" CssClass="btn_AvisoDePrivacidad" OnClick="Btn_LeerUsoDeDatos_Click" />
                                                </div>
                                                <asp:Label ID="Lbl_AcepteUsoDeDatos" runat="server" Text="" CssClass="requeridos"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <div id="dv_Btn_EnviarSoliCompra" style="padding: 0% 40%">
                                                <asp:Button CssClass="pager_btn" ID="Btn_EnviarSoliCompra" runat="server" Text="Enviar" OnClick="Btn_EnviarSoliCompra_Click" OnClientClick="showLoadingEnviaSolicitud().then(() => Btn_EnviarSoliCompra_Click())" ValidationGroup="VGConfirmaSolicitud" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>





                        <!--Mensaje Solicitud de compra-->
                        <asp:Panel ID="Pnl_CreacionSolicitud" runat="server" Visible="false">
                            <div id="container01_CreacionSolicitud" class="container01_booleano" style="height: auto; width: 100%">
                                <div id="container02_CreacionSolicitud" class="container02_booleano">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td>
                                                <div>
                                                    <div style="display: flex; justify-content: center; align-items: center;">
                                                        <asp:Label ID="lbl_CreacioSolicitud" runat="server" Text="" ForeColor="Black" CssClass="secciones"></asp:Label><br />
                                                        <br />
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </asp:Panel>

                        <!--Ficha de pago-->
                        <asp:Panel ID="Pnl_FichaDePago" runat="server" Visible="false">
                            <div style="padding: 0%; display: block;">
                                <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_GenerarFicha" runat="server" Text="Generar ficha" OnClick="Btn_GenerarFicha_Click" />
                                <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_DescargarFicha" runat="server" Text="Descargar" OnClick="Btn_DescargarFicha_Click" Visible="false" />
                            </div>
                        </asp:Panel>

                        <!--Metodo de pago-->
                        <asp:Panel ID="Pnl_MetodoDePago" runat="server" Visible="false">
                            <div>
                                <div>
                                    <p class="secciones">Datos de pago</p>
                                </div>
                                <table class="formulario_table">
                                    <tr>
                                        <td colspan="2">
                                            <div style="display: flex;">
                                                <div style="display: flex; width: 100%;">
                                                    <div style="width: 10%; display: flex; align-items: center;">
                                                        <p class="titleCampos">Numero de la tarjeta</p>
                                                    </div>
                                                    <div style="display: flex;">
                                                        <img id="img_Amex" src="Resources/AMEX.png" style="display: none;" />
                                                        <img id="img_MasterCard" src="Resources/MASTERCARD.png" style="display: none;" />
                                                        <img id="img_Visa" src="Resources/VISA.png" style="display: none;" />
                                                        <img id="img_OtraTarjetaLocal" src="Resources/MEXICOLOCAL.png" style="display: none;" />
                                                    </div>
                                                </div>
                                            </div>
                                            <asp:TextBox ID="TxtB_NumeroTarjeta" runat="server" CssClass="form_campo" Style="height: 1vw;"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_NumeroTarjeta" runat="server" ControlToValidate="TxtB_NumeroTarjeta" ErrorMessage="Numero de tarjeta requerido" ForeColor="Red" ValidationGroup="VGFormaDePago"></asp:RequiredFieldValidator>
                                            <script>
                                                function determinarTipoTarjeta() {
                                                    var numeroTarjeta = document.getElementById('<%= TxtB_NumeroTarjeta.ClientID %>').value;

                                                    // Eliminar espacios en blanco y guiones del número de tarjeta
                                                    numeroTarjeta = numeroTarjeta.replace(/\s/g, '').replace(/-/g, '');

                                                    // Comprobar el tipo de tarjeta en función del patrón del número
                                                    if (/^4[0-9]{12}(?:[0-9]{3})?$/.test(numeroTarjeta)) {
                                                        return "Visa";
                                                    } else if (/^5[1-5][0-9]{14}$/.test(numeroTarjeta)) {
                                                        return "Mastercard";
                                                    } else if (/^3[47][0-9]{13}$/.test(numeroTarjeta)) {
                                                        return "American Express";
                                                    } else {
                                                        return "Desconocida";
                                                    }
                                                }

                                                function OcultaImagenes() {
                                                    document.getElementById('img_Amex').style.display = "none";
                                                    document.getElementById('img_MasterCard').style.display = "none";
                                                    document.getElementById('img_Visa').style.display = "none";
                                                    document.getElementById('img_OtraTarjetaLocal').style.display = "none";
                                                }

                                                document.getElementById('<%= TxtB_NumeroTarjeta.ClientID %>').addEventListener('input', function () {
                                                    var numeroTarjeta = document.getElementById('<%= TxtB_NumeroTarjeta.ClientID %>').value;
                                                    var tipoTarjeta = determinarTipoTarjeta();

                                                    // Eliminar cualquier carácter que no sea un número
                                                    numeroTarjeta = numeroTarjeta.replace(/[^0-9]/g, '');
                                                    document.getElementById('<%= TxtB_NumeroTarjeta.ClientID %>').value = numeroTarjeta;

                                                    switch (tipoTarjeta) {
                                                        case "American Express":
                                                            OcultaImagenes();
                                                            document.getElementById('img_Amex').style.display = "block";
                                                            break;
                                                        case "Mastercard":
                                                            OcultaImagenes();
                                                            document.getElementById('img_MasterCard').style.display = "block";
                                                            break;
                                                        case "Visa":
                                                            OcultaImagenes();
                                                            document.getElementById('img_Visa').style.display = "block";
                                                            break;
                                                        case "Desconocida":
                                                            OcultaImagenes();
                                                            document.getElementById('img_OtraTarjetaLocal').style.display = "block";
                                                            break;
                                                    }

                                                    if (numeroTarjeta.length === 0) {
                                                        OcultaImagenes();
                                                    }
                                                });
                                            </script>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <p class="titleCampos">Titular de la tarjeta</p>
                                            <asp:TextBox ID="TxtB_TitularTarjeta" runat="server" CssClass="form_campo" Style="height: 1vw;"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_TitularTarjeta" runat="server" ControlToValidate="TxtB_TitularTarjeta" ErrorMessage="Titular de tarjeta requerido" ForeColor="Red" ValidationGroup="VGFormaDePago"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Fecha de vencimiento de la tarjeta</p>
                                            <asp:TextBox ID="TxtB_FechaTarjeta" runat="server" CssClass="form_campo" MaxLength="7"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_FechaTarjeta" runat="server" ControlToValidate="TxtB_FechaTarjeta" ErrorMessage="Fecha de vencimiento requerida" ForeColor="Red" ValidationGroup="VGFormaDePago"></asp:RequiredFieldValidator>
                                            <script>
                                                function insertarBarra() {
                                                    var input = document.getElementById('<%= TxtB_FechaTarjeta.ClientID %>');
                                                    var numeroTarjeta = input.value.replace(/\s/g, '').replace(/\//g, '');

                                                    // Validar solo números y la barra "/"
                                                    var soloNumeros = /^[0-9]*$/;
                                                    var soloNumerosYBarra = /^[0-9\/]*$/;

                                                    // Verificar si el número tiene 2 dígitos y no se ha ingresado la barra "/"
                                                    if (numeroTarjeta.length === 2 && input.value.indexOf('/') === -1) {
                                                        var primerosDosDigitos = parseInt(numeroTarjeta, 10);
                                                        if (primerosDosDigitos >= 1 && primerosDosDigitos <= 12) {
                                                            input.value = numeroTarjeta + '/';
                                                        } else {
                                                            // Si los primeros dos dígitos no están en el rango válido, borrar el contenido del campo
                                                            input.value = '';
                                                        }
                                                    }

                                                    // Validar que solo se ingresen números y la barra "/"
                                                    if (!soloNumerosYBarra.test(numeroTarjeta)) {
                                                        input.value = '';
                                                        input.style.borderColor = "red";
                                                    }
                                                    else {
                                                        input.style.borderColor = "#d1d3e2";
                                                    }
                                                }

                                                document.getElementById('<%= TxtB_FechaTarjeta.ClientID %>').addEventListener('input', insertarBarra);
                                            </script>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Código de seguridad de la tarjeta</p>
                                            <asp:TextBox ID="TxtB_CodigoSeguridadTarjeta" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_CodigoSeguridadTarjeta" runat="server" ControlToValidate="TxtB_CodigoSeguridadTarjeta" ErrorMessage="Código de seguridad requerida" ForeColor="Red" ValidationGroup="VGFormaDePago"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>

                        <!--Boton home-->
                        <asp:Panel ID="Pnl_btn_Home" runat="server" Visible="false">
                            <table class="formulario_table">
                                <tr>
                                    <td style="padding: 0% 40%;">
                                        <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_Home" runat="server" Text="Inicio" OnClick="Btn_Home_Click" Visible="false" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </div>


    <script>
        var dv_alerta = document.getElementById('alertaPersonalizada');

        dv_alerta.addEventListener('click', function () {
            if (dv_alerta.style.display == "block") {
                console.log("Oculto alerta por dar click")
                dv_alerta.style.display = "none";
            }
        });
    </script>
</asp:Content>
