<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebSolicitudCompraLE.aspx.cs" Inherits="WebLegadoEducativo02.WebSolicitudCompraLE" MaintainScrollPositionOnPostback="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JavaScripts.js" />
        </Scripts>
    </asp:ScriptManager>

    <!--Paneles Booleanos-->
    <asp:Panel ID="Pnl_boolTitular" runat="server">
        <div id="div_Pnl_boolTitular" class="div_Pnl_booleano">
            <div id="container01_boolTitular" class="container01_booleano">
                <div id="container02_boolTitular" class="container02_booleano">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="txtInicio">
                                    <h1 style="text-align: center;">La información del correo
                                    <asp:Label ID="lbl_CorreoBoolTitular" runat="server" Text=""></asp:Label>
                                        pertenece al titular
                                    </h1>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style="display: flex;">
                                    <div style="width: 50%; padding-right: 10px">
                                        <asp:Button ID="Btn_CorreoBoolTrueTitular" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_CorreoBoolTrueTitular_Click" />
                                    </div>
                                    <div style="width: 50%; padding-left: 10px;">
                                        <asp:Button ID="Btn_CorreoBoolFalseTitular" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn_CorreoBoolFalseTitular_Click" />
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Pnl_BoolDireccionFiscal" runat="server">
        <div id="div_Pnl_BoolDireccionFiscal" class="div_Pnl_booleano">
            <div id="container01_BoolDireccionFiscal" class="container01_booleano">
                <div id="container02_BoolDireccionFiscal" class="container02_booleano">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="txtInicio">
                                    <h1 style="text-align: center;">La dirección Fiscal es la misma que la dirección del titular
                                    </h1>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style="display: flex;">
                                    <div style="width: 50%; padding-right: 10px">
                                        <asp:Button ID="Btn_BoolTrueDireccionFiscal" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_BoolTrueDireccionFiscal_Click" />
                                    </div>
                                    <div style="width: 50%; padding-left: 10px;">
                                        <asp:Button ID="Btn_BoolFalseDireccionFiscal" CssClass="pager_btn" runat="server" Text="No" OnClick="Btn_BoolFalseDireccionFiscal_Click" />
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnl_BoolReciboFiscal" runat="server">
        <div id="div_pnl_BoolReciboFiscal" class="div_Pnl_booleano">
            <div id="container01_BoolReciboFiscal" class="container01_booleano">
                <div id="container02_BoolReciboFiscal" class="container02_booleano">
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
                                                <td style="padding: 0px 25px 0px 25px">
                                                    <asp:Button ID="Btn_Bool_TrueReciboFiscal" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_Bool_TrueReciboFiscal_Click" />
                                                </td>
                                                <td style="padding: 0px 25px 0px 25px">
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
    <asp:Panel ID="pnl_BoolBeneficiarioExtra" runat="server">
        <div id="div_pnl_BoolBeneficiarioExtra" class="div_Pnl_booleano">
            <div id="container01_BoolBeneficiarioExtra" class="container01_booleano">
                <div id="container02_BoolBeneficiarioExtra" class="container02_booleano">
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
                                                <td style="padding: 0px 25px 0px 25px">
                                                    <asp:Button ID="Btn__Bool_trueBeneficiarioExtra" CssClass="pager_btn" runat="server" Text="Si" OnClick="Btn__Bool_trueBeneficiarioExtra_Click" />
                                                </td>
                                                <td style="padding: 0px 25px 0px 25px">
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
    <asp:Panel ID="Pnl_BoolVerificaTitular" runat="server">
        <div id="div_pnl_BoolVerificaTitular" class="div_Pnl_booleano">
            <div id="container01_BoolVerificaTitular" class="container01_booleano">
                <div id="container02_BoolVerificaTitular" class="container02_booleano" style="overflow-y: scroll; height: 90%">
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
                                        <table style="width: 100%">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Primer Nombre del titular</p>
                                                    <asp:TextBox ID="txtB_PrimNomVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Segundo Nombre del titular</p>
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
                                                    <p class="titleCampos">Fecha de Nacimiento del titular</p>
                                                    <asp:TextBox ID="txtB_FechaNacVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Celular del titular</p>
                                                    <asp:TextBox ID="txtB_MovilVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Telefono de casa del titular</p>
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
                                                    <asp:RadioButtonList ID="RadioBL_VerificaTitularExaudem" runat="server" Font-Names="Arial Rounded MT" RepeatDirection="Horizontal" Enabled="false">
                                                        <asp:ListItem Value="True">Sí</asp:ListItem>
                                                        <asp:ListItem Value="False">No</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
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
                                                    <p class="titleCampos">Codigo Postal</p>
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
                                                    <asp:DropDownList ID="ddl_coloniaVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:DropDownList>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Municipio</p>
                                                    <asp:TextBox ID="txtB_MunicipioVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Pais</p>
                                                    <asp:TextBox ID="txtB_PaisVerificaTitular" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <div style="display: flex;">
                                                        <div id="dv_btn_VerificaTitular" style="width: 50%; padding-right: 10px; display: block">
                                                            <asp:Button ID="Btn_BoolTrueVerificaTitular" CssClass="pager_btn" runat="server" Text="Sí" OnClick="Btn_EnviarTitular_Click" OnClientClick="showLoadingSoliPantallaEnviaTitular().then(() => Btn_EnviarTitular_Click())" />
                                                        </div>
                                                        <div id="dv_btn_VerificaTitularFalse" style="width: 50%; padding-left: 10px; display: block;">
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
    <asp:Panel ID="pnl_BoolVerificaInfoFiscal" runat="server">
        <div id="div_pnl_BoolVerificaInfoFiscal" class="div_Pnl_booleano">
            <div id="container01_BoolVerificaInfoFiscal" class="container01_booleano">
                <div id="container02_BoolVerificaInfoFiscal" class="container02_booleano" style="overflow-y: scroll; height: 90%">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="secciones">
                                    <p style="text-align: justify;">
                                        ¿Los datos del fiscales son correctos?
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
                                                <td>
                                                    <p class="titleCampos">Nombre Comercial *</p>
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
                                                    <p class="titleCampos">Calle</p>
                                                    <asp:TextBox ID="txtB_CalleVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Número</p>
                                                    <asp:TextBox ID="txtB_NumeroVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Codigo Postal</p>
                                                    <asp:TextBox ID="txtB_CodigoPostalVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Colonia</p>
                                                    <asp:DropDownList ID="ddl_ColoniaVerificaDatFisc" runat="server" CssClass="form_campo" Enabled="false"></asp:DropDownList>
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
                                                <td colspan="2">
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
    <div id="AnimacionCargandoPantalla" style="display: none;">
        <div class="div_Pnl_PantallaCargando">
            <div class="container01_PantallaCargando">
                <div class="container02_PantallaCargando">
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <div style="display: flex;">
                                    <div class="loader-container">
                                        <div class="loader"></div>
                                        <div class="loader2"></div>
                                    </div>
                                    <div class="loadertxt-container">
                                        <h1 class="loader-text">Cargando Información</h1>
                                        <div class="dots">
                                            <div class="dot1">.</div>
                                            <div class="dot2">.</div>
                                            <div class="dot3">.</div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!--------------------->

    <!----------Aviso de privacidad---------->
    <div>
        <asp:Panel ID="pnl_AvisoPrivacidad" runat="server">
            <div id="div_pnl_AvisoPrivacidad" class="div_Pnl_AvisoPrivacidad">
                <div id="container01_AvisoPrivacidad" class="container01_AvisoPrivacidad">
                    <div id="container02_AvisoPrivacidad" class="container02_AvisoPrivacidad" style="width: 75%">
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
                            <tr>
                                <td>
                                    <div>
                                        <asp:RadioButton ID="RBtn_AceptaAvisoPrivacidad" runat="server" Text="Acepto el aviso de privacidad" OnCheckedChanged="RBtn_AceptaAvisoPrivacidad_CheckedChanged" Font-Names="Arial Rounded MT" />
                                    </div>
                                    <div>
                                        <asp:Label ID="lbl_AceptaAvisoPrivacidad" runat="server" Text="" CssClass="requeridos"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_ContiAvisoPriva" runat="server" Text="Continuar" OnClick="Btn_ContiAvisoPriva_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </div>

    <!----------Solicitud de Compra----------->
    <div style="padding: 5%">
        <div class="container-form">
            <div class="form">
                <div>
                    <div style="display: flex; justify-content: center; align-items: center">
                        <table id="table_phase">
                            <tr>
                                <td>
                                    <div class="container_dv_phase">
                                        <div id="dv_phase_1Titu" class="dv_phase_1" runat="server">
                                            <div id="dv_phase_2Titu" class="dv_phase_2" runat="server">
                                                <div id="checkTitu" class="check">
                                                    ✔
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <div class="container_dv_phase">
                                        <div id="dv_phase_1DatosFisc" class="dv_phase_1" runat="server">
                                            <div id="dv_phase_2DatosFisc" class="dv_phase_2" runat="server">
                                                <div class="check">
                                                    ✔
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <div class="container_dv_phase">
                                        <div id="dv_phase_1TituDesi" class="dv_phase_1" runat="server">
                                            <div id="dv_phase_2TituDesi" class="dv_phase_2" runat="server">
                                                <div class="check">
                                                    ✔
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <div class="container_dv_phase">
                                        <div id="dv_phase_1Benefi" class="dv_phase_1" runat="server">
                                            <div id="dv_phase_2Benefi" class="dv_phase_2" runat="server">
                                                <div class="check">
                                                    ✔
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <div class="container_dv_phase">
                                        <div id="dv_phase_1Confirmacion" class="dv_phase_1" runat="server">
                                            <div id="dv_phase_2Confirmacion" class="dv_phase_2" runat="server">
                                                <div class="check">
                                                    ✔
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div>
                                        <h4 class="text_check">Titular
                                        </h4>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <h4 class="text_check">Datos Fiscales
                                        </h4>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <h4 class="text_check">Titular Designado
                                        </h4>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <h4 class="text_check">Beneficiario
                                        </h4>
                                    </div>
                                </td>
                                <td>
                                    <div>
                                        <h4 class="text_check">Confirmación
                                        </h4>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <table id="formulario" style="width: 100%">
                    <tr>
                        <td colspan="2">
                            <!--Titular-->
                            <div>
                                <asp:Panel ID="pnl_Titular" runat="server">
                                    <div>
                                        <div>
                                            <table style="width: 100%;">
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
                                                        <p class="titleCampos">Primer Nombre del titular</p>
                                                        <asp:TextBox ID="txtB_NombrePilaTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombrePilaTitular" runat="server" ControlToValidate="txtB_NombrePilaTitular" ErrorMessage="Primer Nombre Requerido" ForeColor="Red" ValidationGroup="VGTitular">Primer Nombre Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <p class="titleCampos">Segundo Nombre del titular</p>
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
                                                        <p class="titleCampos">Fecha de Nacimiento del titular</p>
                                                        <asp:TextBox ID="txtB_FechaNacTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacTitular" runat="server" ControlToValidate="txtB_FechaNacTitular" ErrorMessage="Fecha de nacimiento Requerido" ForeColor="Red" ValidationGroup="VGTitular">Fecha de Nacimiento Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <p class="titleCampos">Celular del titular</p>
                                                        <asp:TextBox ID="txtB_movilTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilTitular" runat="server" ControlToValidate="txtB_movilTitular" ErrorMessage="Numero de celular Requerido" ForeColor="Red" ValidationGroup="VGTitular">Numero de celular Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <p class="titleCampos">Teléfono de casa del titular</p>
                                                        <asp:TextBox ID="txtB_TelCasaTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTelCasaTitular" runat="server" ControlToValidate="txtB_TelCasaTitular" ErrorMessage="Teléfono de casa Requerido" ForeColor="Red" ValidationGroup="VGTitular">Teléfono de casa Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <p class="titleCampos">Correo electrónico del titular</p>
                                                        <asp:TextBox ID="txtB_CorreoElecTitular" runat="server" CssClass="form_campo"></asp:TextBox>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecTitular" runat="server" ControlToValidate="txtB_CorreoElecTitular" ErrorMessage="Correo Electronico Requerido" ForeColor="Red" ValidationGroup="VGTitular">Correo electronico Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <p class="titleCampos">¿El titular es ExaUDEM?</p>
                                                        <asp:RadioButtonList ID="RadioBL_TitularExaudem" runat="server" Font-Names="Arial Rounded MT" RepeatDirection="Horizontal">
                                                            <asp:ListItem Value="True">Sí</asp:ListItem>
                                                            <asp:ListItem Value="False">No</asp:ListItem>
                                                        </asp:RadioButtonList>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTitularExaudem" runat="server" ControlToValidate="RadioBL_TitularExaudem" ErrorMessage="Titular ExaUDEM Requerido" ForeColor="Red" ValidationGroup="VGTitular">Titular ExaUDEM Requerido *</asp:RequiredFieldValidator>
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
                                                        <p class="titleCampos">Codigo Postal</p>
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
                                                        <asp:DropDownList ID="ddl_colonia" runat="server" CssClass="form_campo" AutoPostBack="True"></asp:DropDownList>
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaColonia" runat="server" ControlToValidate="ddl_colonia" ErrorMessage="Colonia Requerido" ForeColor="Red" ValidationGroup="VGTitular">Colonia Requerido *</asp:RequiredFieldValidator>
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
                                        </div>
                                    </div>
                                    <div id="dv_Btn_EnviarTitular" style="display: block">
                                        <asp:Button CssClass="pager_btn" ID="Btn_EnviarTitular" runat="server" Text="Enviar" OnClick="Btn_EnviarTitularPrevi_Click" ValidationGroup="VGTitular" />
                                    </div>
                                </asp:Panel>
                            </div>

                            <!--Recibo Fiscal-->
                            <div>
                                <asp:Panel ID="Pnl_ReciboFiscal" runat="server">
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td colspan="2">
                                                    <p class="secciones">Informacion Fiscal</p>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nombre Comercial *</p>
                                                    <asp:TextBox ID="txtB_NombreComercial" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombreComercial" runat="server" ControlToValidate="txtB_NombreComercial" ErrorMessage="Nombre Comercial Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Nombre Comercial Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Razón social</p>
                                                    <asp:TextBox ID="txtB_RazonSocial" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaRazonSocial" runat="server" ControlToValidate="txtB_RazonSocial" ErrorMessage="Razon Social Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Razón Social Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">R.F.C:</p>
                                                    <asp:TextBox ID="txtB_RFCReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaRFCReciboFiscal" runat="server" ControlToValidate="txtB_RFCReciboFiscal" ErrorMessage="RFC Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">RFC Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Calle</p>
                                                    <asp:TextBox ID="txtB_CalleReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCalleReciboFiscal" runat="server" ControlToValidate="txtB_CalleReciboFiscal" ErrorMessage="Calle Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Calle Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Número</p>
                                                    <asp:TextBox ID="txtB_NumeroReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNumeroReciboFiscal" runat="server" ControlToValidate="txtB_NumeroReciboFiscal" ErrorMessage="Número Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Número Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Codigo Postal</p>
                                                    <asp:TextBox ID="txtB_CodigoPostalReciboFiscal" runat="server" CssClass="form_campo" AutoPostBack="True" OnTextChanged="TxtB_CodigoPostalReciboFiscal_TextChanged"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCodigoPostalReciboFiscal" runat="server" ControlToValidate="txtB_CodigoPostalReciboFiscal" ErrorMessage="Codigo Postal Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Codigo Postal Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Colonia</p>
                                                    <asp:DropDownList ID="Ddl_ColoniaReciboFiscal" runat="server" CssClass="form_campo" AutoPostBack="True"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaColoniaReciboFiscal" runat="server" ControlToValidate="Ddl_ColoniaReciboFiscal" ErrorMessage="Colonia Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Colonia Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Estado</p>
                                                    <asp:TextBox ID="txtB_EstadoReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaEstadoReciboFiscal" runat="server" ControlToValidate="txtB_EstadoReciboFiscal" ErrorMessage="Estado Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Estado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Municipio</p>
                                                    <asp:TextBox ID="txtB_MunicipioReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMunicipioReciboFiscal" runat="server" ControlToValidate="txtB_MunicipioReciboFiscal" ErrorMessage="Municipio Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">Municipio Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">País</p>
                                                    <asp:TextBox ID="txtB_PaisReciboFiscal" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPaisReciboFiscal" runat="server" ControlToValidate="txtB_PaisReciboFiscal" ErrorMessage="País Requerido" ForeColor="Red" ValidationGroup="VGReciboFiscal">País Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviarDatosFiscales" runat="server" Text="Enviar" OnClick="Btn_VeriDatosFiscales_Click" ValidationGroup="VGReciboFiscal" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                            </div>

                            <!--Titular Designado-->
                            <div>
                                <asp:Panel ID="Pnl_TitularDesignado" runat="server">
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td colspan="2">
                                                    <div>
                                                        <asp:Label CssClass="secciones" ID="lblTitularDesignado" runat="server" Text="Titular Designado"></asp:Label>
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
                                                    <p class="titleCampos">Primer Nombre del titular designado</p>
                                                    <asp:TextBox ID="txtB_PrimNomTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPrimNomTituDesi" runat="server" ControlToValidate="txtB_PrimNomTituDesi" ErrorMessage="Primer Nombre del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Primer Nombre del titular designado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Segundo Nombre del titular designado</p>
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
                                                    <p class="titleCampos">Fecha de Nacimiento del titular designado</p>
                                                    <asp:TextBox ID="txtB_FechaNacTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacTituDesi" runat="server" ControlToValidate="txtB_FechaNacTituDesi" ErrorMessage="Fecha de Nacimiento del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Fecha de Nacimiento del titular designado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Celular del titular designado</p>
                                                    <asp:TextBox ID="txtB_MovilTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilTituDesi" runat="server" ControlToValidate="txtB_MovilTituDesi" ErrorMessage="Celular del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Celular del titular designado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Telefono de casa del titular designado</p>
                                                    <asp:TextBox ID="txtB_TelCasaTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaTelCasaTituDesi" runat="server" ControlToValidate="txtB_TelCasaTituDesi" ErrorMessage="Telefono de casa del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Telefono de casa del titular designado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Correo electrónico del titular designado</p>
                                                    <asp:TextBox ID="txtB_CorreoElecTituDesi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecTituDesi" runat="server" ControlToValidate="txtB_CorreoElecTituDesi" ErrorMessage="Correo electrónico del titular designado Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Correo electrónico del titular designado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Parentesco con el titular</p>
                                                    <asp:DropDownList ID="ddl_ParentescoTituDesi" runat="server" CssClass="form_campo" TabIndex="1">
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
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaParentescoTituDesi" runat="server" ControlToValidate="ddl_ParentescoTituDesi" ErrorMessage="Parentesco con el titular Requerido" ForeColor="Red" ValidationGroup="VGTituDesi">Parentesco con el titular Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <div id="dv_Btn_EnviaTituDesi" style="display: block;">
                                                        <asp:Button CssClass="pager_btn" ID="Btn_EnviaTituDesi" runat="server" ValidationGroup="VGTituDesi" Text="Enviar" OnClick="Btn_EnviaTituDesi_Click" OnClientClick="showLoadingIniciaSesion().then(() => Btn_EnviaTituDesi());" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                            </div>

                            <!--Beneficiario-->
                            <div>
                                <asp:Panel ID="Pnl_Beneficiario" runat="server">
                                    <div>
                                        <table style="width: 100%">
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
                                                    <p class="titleCampos">Primer Nombre del beneficiario</p>
                                                    <asp:TextBox ID="txtB_PrimNomBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaPrimNomBenefi" runat="server" ControlToValidate="txtB_PrimNomBenefi" ErrorMessage="Primer Nombre del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Primer Nombre del beneficiario Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Segundo Nombre del beneficiario</p>
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
                                                    <p class="titleCampos">Fecha de Nacimiento del Beneficiario</p>
                                                    <asp:TextBox ID="txtB_FechaNacBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaFechaNacBenefi" runat="server" ControlToValidate="txtB_FechaNacBenefi" ErrorMessage="Fecha de Nacimiento del Beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Fecha de Nacimiento del Beneficiario Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Celular del beneficiario</p>
                                                    <asp:TextBox ID="txtB_MovilBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaMovilBenefi" runat="server" ControlToValidate="txtB_MovilBenefi" ErrorMessage="Celular del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Celular del beneficiario Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Correo electrónico del beneficiario</p>
                                                    <asp:TextBox ID="txtB_CorreoElecBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecBenefi" runat="server" ControlToValidate="txtB_CorreoElecBenefi" ErrorMessage="Correo electrónico del beneficiario Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Correo electrónico del beneficiario Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Parentesco con el titular</p>
                                                    <asp:DropDownList ID="ddl_ParentescoBenefi" runat="server" CssClass="form_campo">
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
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaParentescoBenefi" runat="server" ControlToValidate="ddl_ParentescoBenefi" ErrorMessage="Parentesco con el titular Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Parentesco con el titular Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div>
                                                        <asp:Label CssClass="secciones" ID="lbl_IntiProce" runat="server" Text="Insitución de procedencia"></asp:Label>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Menciona (en caso de aplicar) la carrera que está cursando el beneficiario</p>
                                                    <asp:TextBox ID="txtB_carreraBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">también, (en caso de aplicar) menciona el semestre que está cursando el beneficiario</p>
                                                    <asp:TextBox ID="txtB_SemestreBenefi" runat="server" CssClass="form_campo"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nos gustaria conocer, ¿Tienes beca?</p>
                                                    <asp:RadioButtonList ID="rbl_BecaBenefi" runat="server" CssClass="radioBL" Font-Bold="False" Font-Names="Arial Rounded MT" RepeatDirection="Horizontal">
                                                        <asp:ListItem>Sí</asp:ListItem>
                                                        <asp:ListItem>No</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaBecaBenefi" runat="server" ControlToValidate="rbl_BecaBenefi" ErrorMessage="Tienes beca Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Tienes beca Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nivel de estudio</p>
                                                    <asp:DropDownList ID="ddl_NivelProcede" runat="server" CssClass="form_campo" OnSelectedIndexChanged="Ddl_NivelProcede_SelectedIndexChanged" AutoPostBack="True">
                                                        <asp:ListItem Value="0">---Seleccione Nivel---</asp:ListItem>
                                                        <asp:ListItem Value="1">Primaria</asp:ListItem>
                                                        <asp:ListItem Value="2">Secundaria</asp:ListItem>
                                                        <asp:ListItem Value="3">Bachillerato</asp:ListItem>
                                                        <asp:ListItem Value="4">Profesional</asp:ListItem>
                                                        <asp:ListItem Value="5">Posgrado </asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNivelProcede" runat="server" ControlToValidate="ddl_NivelProcede" ErrorMessage="Nivel de estudio Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Nivel de estudio Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Nombre de la institución</p>
                                                    <asp:DropDownList ID="ddl_NombreInstiProce" runat="server" CssClass="form_campo" AutoPostBack="True" OnSelectedIndexChanged="Ddl_NombreInstiProce_SelectedIndexChanged"></asp:DropDownList>
                                                    <asp:TextBox ID="txtB_NombreInstiProce" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaNombreInstiProce" runat="server" ControlToValidate="ddl_NombreInstiProce" ErrorMessage="Nombre de la institución Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Nombre de la institución Requerido *</asp:RequiredFieldValidator>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmatxtBNombreInstiProce" runat="server" ControlToValidate="txtB_NombreInstiProce" ErrorMessage="Nombre de la institución Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Nombre de la institución Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Estado</p>
                                                    <asp:DropDownList ID="ddl_EstadoInstiProce" runat="server" CssClass="form_campo"></asp:DropDownList>
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaEstadoInstiProce" runat="server" ControlToValidate="ddl_EstadoInstiProce" ErrorMessage="Estado Requerido" ForeColor="Red" ValidationGroup="VGBeneficiario">Estado Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <div id="dv_Btn_EnviaBeneficiario" style="display: block;">
                                                        <asp:Button CssClass="pager_btn" ID="Btn_EnviaBeneficiario" runat="server" Text="Enviar" OnClick="Btn_EnviaBeneficiario_Click" ValidationGroup="VGBeneficiario" OnClientClick="showLoadingSoliPantallaEnviaBenefi().then(() => Btn_EnviaBeneficiario_Click())" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                                <!--<asp:Panel ID="pnl_FuenteLead" runat="server">
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nos gustaría conocer cómo se enteró de Legado Educativo UDEM</p>
                                                    <asp:DropDownList ID="ddl_ComoSeEntero" runat="server" CssClass="form_campo">
                                                        <asp:ListItem Value="0">---Seleccione Opción---</asp:ListItem>
                                                        <asp:ListItem Value="1">Boletin EXAUDEM o redes sociales</asp:ListItem>
                                                        <asp:ListItem Value="2">Sitio Web</asp:ListItem>
                                                        <asp:ListItem Value="3">Me enteré en eun evento(conferencia, webinar)</asp:ListItem>
                                                        <asp:ListItem Value="4">Visita al campus UDEM</asp:ListItem>
                                                        <asp:ListItem Value="5">Me lo recomendaron en la UDEM (en mi proceso de admisiones, un colaborador, en el CIAA)</asp:ListItem>
                                                        <asp:ListItem Value="7">Me lo recomendó un familiar, amigo, alumno o cliente</asp:ListItem>
                                                        <asp:ListItem Value="8">En el colegio de mis hijos (por una conferencia o por Troyanos Kids)</asp:ListItem>
                                                        <asp:ListItem Value="9">En mi empresa</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Me acompaño en mi proceso de compra</p>
                                                    <asp:DropDownList ID="ddl_CompañiaCompra" runat="server" CssClass="form_campo">
                                                        <asp:ListItem Value="0">---Seleccione Opción---</asp:ListItem>
                                                        <asp:ListItem Value="1">Georgina Brocker</asp:ListItem>
                                                        <asp:ListItem Value="2">Jessica Garza</asp:ListItem>
                                                        <asp:ListItem Value="3">Lilia Leal</asp:ListItem>
                                                        <asp:ListItem Value="4">Alguien más</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>-->
                                <asp:Panel ID="pnl_Solicitud" runat="server">
                                    <div>
                                        <table style="width: 100%">
                                            <tr>
                                                <td colspan="2">
                                                    <div>
                                                        <h1 style="text-align: center; font: 'Arial Rounded MT';">A continuación, podrás adjuntar los documentos que necesitamos para tu proceso de compra, asi como confirmar tus datos finales </h1>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div>
                                                        <p class="secciones">Titular</p>
                                                        <br />
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div>
                                                        <p class="titleCampos">Titular</p>
                                                        <asp:TextBox ID="txtB_NombreTituSoli" runat="server" CssClass="form_campo"></asp:TextBox>
                                                    </div>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">INE o pasaporte vigente</p>
                                                    <asp:FileUpload ID="FileU_InePasaporte" runat="server" />
                                                    <p class="titleCampos">Captura el número de "Clave de Elector" o "Numero de Pasaporte" según aplique. (Observa las imágenes de apoyo)</p>
                                                    <asp:TextBox ID="txtB_ClaveElectorNumPasa" runat="server" CssClass="form_campo"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div>
                                                        <p class="secciones">Titular Designado</p>
                                                        <br />
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Titular Designado</p>
                                                    <asp:TextBox ID="txtB_NombreTituDesiSoli" runat="server" CssClass="form_campo"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">INE, Pasaporte o acta de nacimiento</p>
                                                    <asp:FileUpload ID="FileU_INEPasapoTituDesi" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="secciones">Beneficiario</p>
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Beneficiario</p>
                                                    <asp:TextBox ID="txtB_NombreBenefiSoli" runat="server" CssClass="form_campo" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">INE o pasaporte vigente</p>
                                                    <asp:FileUpload ID="FileU_INEPasapoBenefi" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Comprobante de Domicilio (No mayor a 3 meses)</p>
                                                    <asp:FileUpload ID="FileU_ComprobanteDomicilio" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">¿Requiere Recibo Fiscal?</p>
                                                    <asp:RadioButtonList ID="RBtnl_ReciboFiscalSoli" runat="server" Font-Names="Arial Rounded MT" RepeatDirection="Horizontal" Enabled="false">
                                                        <asp:ListItem Value="True">Sí</asp:ListItem>
                                                        <asp:ListItem Value="False">No</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>

                                                <td>
                                                    <p class="titleCampos">Forma de pago</p>
                                                    <asp:DropDownList ID="Ddl_FormaPagoSoli" runat="server" CssClass="form_campo">
                                                        <asp:ListItem Value="01">---Seleccione una opcion---</asp:ListItem>
                                                        <asp:ListItem Value="02">Deposito</asp:ListItem>
                                                        <asp:ListItem Value="03">Transferencia</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div>
                                                        <asp:Button CssClass="pager_btn" ID="Btn_EnviarSoliCompra" runat="server" Text="Enviar" OnClick="Btn_EnviarSoliCompra_Click" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
