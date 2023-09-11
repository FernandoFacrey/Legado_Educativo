<%@ Page MaintainScrollPositionOnPostback="true" Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="True" CodeBehind="CrearCuenta.aspx.cs" Inherits="WebLegadoEducativo02.CrearCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JScriptsCreaCuenta.js" />
            <asp:ScriptReference Path="~/Scripts/JScripts_captcha.js" />
        </Scripts>
    </asp:ScriptManager>


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
                            <span class="txt_Cargando">Creando cuenta</span>
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

    <asp:Panel ID="pnl_AvisoPrivacidad" runat="server">
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

    <asp:Panel ID="pnl_CorreoCrearCuenta" CssClass="Pnl_boolTitular" runat="server">
        <div class="div_PantallaEmergente">
            <div class="container01_PantallaEmergente">
                <div class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="txtInicio">
                                    <h1>Ingresa tu correo electrónico</h1>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style="display: flex; align-items: center; padding: 1% 0%;">
                                    <div style="width: 21%;">
                                        <p class="titleCampos">Correo electrónico</p>
                                    </div>
                                    <div style="display: flex; align-items: center;">
                                        <asp:RegularExpressionValidator ID="Valida_txtB_ConfirmaCorreoElecCrea" CssClass="requeridos" runat="server" ControlToValidate="txtB_ConfirmaCorreoElecCrea"
                                            ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                            ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                            ValidationGroup="VG02"></asp:RegularExpressionValidator>

                                    </div>
                                </div>
                                <asp:TextBox ID="txtB_ConfirmaCorreoElecCrea" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                <div>
                                    <div>
                                        <asp:Label ID="lbl_CuentaExistente" runat="server" Text="¡Ya existe una cuenta vinculada a tu correo!" CssClass="requeridos"></asp:Label>
                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="ConfirmaCorreoElecCrea" runat="server" ControlToValidate="txtB_ConfirmaCorreoElecCrea" ErrorMessage="Correo electrónico requerido" ForeColor="Red" ValidationGroup="VG02">Correo Electrónico Requerido *</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <div id="dv_Btn_ConfirmaCorreoCreaCuenta" style="display: block; padding: 0% 15%;">
                                    <asp:Button CssClass="pager_btn" ID="Btn_ConfirmaCorreoCreaCuenta" runat="server" Text="Confirmar correo" OnClientClick="ShowLoadingConfirmaCorreo().then(() => Btn_ConfirmaCorreoCreaCuenta_Click());" OnClick="Btn_ConfirmaCorreoCreaCuenta_Click" ValidationGroup="VG02" />
                                </div>
                                <div style="display: flex; justify-content: center;">
                                    <div id="AnimacionConfirmaCorreoCreaCuenta" style="display: none; width: 60%;">
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
                                <div style="display: block; padding: 0% 35%;">
                                    <asp:Button CssClass="pager_btn" ID="Btn_RedireIniciaSesion" runat="server" Text="Iniciar Sesión" OnClick="Btn_RedireIniciaSesion_Click" />
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_CreacionCuenta" runat="server">
        <div class="div_PantallaEmergente">
            <div class="container01_PantallaEmergente">
                <div class="container02_PantallaEmergente">
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <div>
                                    <div style="display: flex; justify-content: center; align-items: center; margin: 3%;">
                                        <asp:Label ID="lbl_CreacioCuenta" runat="server" Text="" ForeColor="Black" CssClass="secciones"></asp:Label><br />
                                        <br />
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style="width: 100%; display: flex; align-items: center; justify-content: center;">
                                    <asp:Button Width="30%" CssClass="pager_btn" ID="Btn_RedireIniciaSesion2" runat="server" Text="Iniciar Sesión" OnClick="Btn_RedireIniciaSesion_Click" />
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <div style="padding: 5%">
        <div class="form">
            <table class="formulario_table" style="width: 100%">
                <tr>
                    <td>
                        <asp:Label CssClass="secciones" ID="Lbl_MasInfo" runat="server" Text="Inicia tu legado"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class="titleCampos">Primer nombre</p>
                        <asp:TextBox ID="txtB_NombrePila" runat="server" CssClass="form_campo"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtB_NombrePila" ErrorMessage="Nombre de Pila Requerido" ForeColor="Red" ValidationGroup="VG01">Nombre de Pila Requerido *</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <p class="titleCampos">Segundo nombre</p>
                        <asp:TextBox ID="txtB_SeguNom" runat="server" CssClass="form_campo"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <p class="titleCampos">Apellido paterno</p>
                        <asp:TextBox ID="txtB_ApePater" runat="server" CssClass="form_campo"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Apellido Paterno Requerido" ControlToValidate="txtB_ApePater" ForeColor="Red" ValidationGroup="VG01">Apellido Paterno Requerido *</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <p class="titleCampos">Apellido materno</p>
                        <asp:TextBox ID="txtB_ApeMater" runat="server" CssClass="form_campo"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Apellido Materno Requerido" ControlToValidate="txtB_ApeMater" ForeColor="Red" ValidationGroup="VG01">Apellido Materno Requerido *</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div style="display: flex; align-items: center;">
                            <div style="width: 16%;">
                                <p class="titleCampos">Teléfono móvil</p>
                            </div>
                            <div style="display: flex;">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_TelMovil" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VG01"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <asp:TextBox ID="txtB_TelMovil" runat="server" CssClass="form_campo"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Teléfono movil requerido" ControlToValidate="txtB_TelMovil" ForeColor="Red" ValidationGroup="VG01">Teléfono movil requerido *</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <div style="display: flex; align-items: center;">
                            <div style="width: 21%;">
                                <p class="titleCampos">Teléfono particular</p>
                            </div>
                            <div style="display: flex;">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El teléfono debe contener 10 dígitos " ControlToValidate="txtB_TelParti" CssClass="requeridos" ValidationExpression="\d{10}" ValidationGroup="VG01"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <asp:TextBox ID="txtB_TelParti" runat="server" CssClass="form_campo"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Teléfono Particular requerido" ControlToValidate="txtB_TelParti" ForeColor="Red" ValidationGroup="VG01">Teléfono Particular requerido *</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>

                        <div style="display: flex; width: 100%; align-items: flex-end">
                            <div style="width: 22%;">
                                <p class="titleCampos">¿Como te esteraste?</p>
                            </div>
                            <div id="dv_cargandoFuenteLead01" style="display: none;">
                                <div class="loader_text">
                                    <span>.</span>
                                    <span>.</span>
                                    <span>.</span>
                                </div>
                            </div>
                        </div>

                        <asp:DropDownList ID="Ddl_fuenteLeadOri" runat="server" CssClass="form_DropDownList" OnSelectedIndexChanged="Ddl_fuenteLeadOri_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator9" runat="server" ErrorMessage="Como te enteraste Requerido" ControlToValidate="Ddl_fuenteLeadOri" ForeColor="Red" ValidationGroup="VG01" InitialValue="0">Como te enteraste Requerido *</asp:RequiredFieldValidator>
                    </td>
                    <td>

                        <div style="display: flex; width: 100%; align-items: flex-end">
                            <div style="width: 22%;">
                                <p class="titleCampos">¿Como te esteraste?</p>
                            </div>
                            <div id="dv_cargandoFuenteLead02" style="display: none;">
                                <div class="loader_text">
                                    <span>.</span>
                                    <span>.</span>
                                    <span>.</span>
                                </div>
                            </div>
                        </div>

                        <asp:DropDownList ID="Ddl_fuenteLeadSubcat" runat="server" CssClass="form_DropDownList"></asp:DropDownList>
                        <asp:TextBox ID="txtB_fuenteLeadOtro" runat="server" CssClass="form_DropDownList" Style="height: 40%;"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator10" runat="server" ErrorMessage="Como te enteraste Requerido" ControlToValidate="Ddl_fuenteLeadSubcat" ForeColor="Red" ValidationGroup="VG01" InitialValue="0">Como te enteraste Requerido *</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class="titleCampos">¿Eres Exalumno UDEM?</p>
                        <asp:RadioButtonList CssClass="radioBL" ID="RBL_ContactExUdem" runat="server" RepeatDirection="Horizontal" Style="width: 75%;" OnSelectedIndexChanged="RBL_ContactExUdem_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>Sí</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator13" runat="server" ErrorMessage="Exaudem requerido" ControlToValidate="RBL_ContactExUdem" ForeColor="Red" ValidationGroup="VG01">Exaudem Requerido *</asp:RequiredFieldValidator>
                    </td>
                    <asp:Panel ID="Pnl_Matricula" runat="server" Visible="false">
                        <td>
                            <p class="titleCampos">Matricula</p>
                            <asp:TextBox ID="TxtB_Matricula" runat="server" CssClass="form_campo"></asp:TextBox><br />
                        </td>
                    </asp:Panel>
                </tr>
                <tr>
                    <td>
                        <p class="titleCampos">Correo electrónico</p>
                        <asp:TextBox ID="txtB_CorreoElec" runat="server" CssClass="form_campo" AutoPostBack="True" TextMode="Email"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Correo electrónico requerido" ControlToValidate="txtB_CorreoElec" ForeColor="Red" ValidationGroup="VG01">Correo Electrónico Requerido *</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <div style="display: flex; align-items: center; padding: .69% 0%;">
                            <div style="width: 35%;">
                                <p class="titleCampos">Confirma tu correo electrónico</p>
                            </div>
                            <div style="display: flex;">
                                <asp:CompareValidator CssClass="requeridos" ID="CompareValidator1" runat="server" ErrorMessage="Correo electrónico no coincide" ControlToCompare="txtB_CorreoElec" ControlToValidate="txtB_ConfirmaCorreoElec" ValidationGroup="VG01"></asp:CompareValidator>
                            </div>
                        </div>
                        <asp:TextBox ID="txtB_ConfirmaCorreoElec" runat="server" CssClass="form_campo" TextMode="Email"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Confirmación correo electrónico requerido" ControlToValidate="txtB_ConfirmaCorreoElec" ForeColor="Red" ValidationGroup="VG01">Confirmación correo electrónico requerido *</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class="titleCampos">Contraseña</p>
                        <asp:TextBox ID="txtB_Contraseña" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Contraseña requerida" ControlToValidate="txtB_Contraseña" ForeColor="Red" ValidationGroup="VG01">Contraseña requerida *</asp:RequiredFieldValidator>
                    </td>
                    <td>

                        <div style="display: flex; align-items: center; padding: .69% 0%;">
                            <div style="width: 35%;">
                                <p class="titleCampos">Confirma tu contraseña</p>
                            </div>
                            <div style="display: flex;">
                                <asp:CompareValidator CssClass="requeridos" ID="CompareValidator2" runat="server" ErrorMessage="Contraseña no coincide" ControlToCompare="txtB_Contraseña" ControlToValidate="txtB_ConfirmaContraseña" ValidationGroup="VG01"></asp:CompareValidator>
                            </div>
                        </div>

                        <asp:TextBox ID="txtB_ConfirmaContraseña" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator12" runat="server" ErrorMessage="Confirmación contraseña requerida" ControlToValidate="txtB_ConfirmaContraseña" ForeColor="Red" ValidationGroup="VG01">Confirmación contraseña requerida*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div style="display: flex; align-items: center; padding: 1% 0%;">
                            <div style="width: 22%;">
                                <p class="titleCampos">Fecha de nacimiento</p>
                            </div>
                            <div style="display: flex;">
                                <asp:RegularExpressionValidator ID="Valida_txtB_FechaNac" runat="server" ControlToValidate="txtB_FechaNac" CssClass="requeridos"
                                    ErrorMessage="Por favor, introduzca una fecha válida en formato dd/mm/yyyy"
                                    ValidationExpression="^((0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4}))|((\d{4})[-\/](0?[1-9]|1[0-2])[-\/](0?[1-9]|[12][0-9]|3[01]))$"
                                    ValidationGroup="VG01"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <asp:TextBox ID="txtB_FechaNac" runat="server" CssClass="form_campo" TextMode="Date"></asp:TextBox><br />
                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator11" runat="server" ErrorMessage="Fecha de nacimiento requerido" ControlToValidate="txtB_FechaNac" ForeColor="Red" ValidationGroup="VG01">Fecha de nacimiento Requerido *</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <div class="div_AceptoAvisoPrivacidad_txt">
                            <asp:CheckBox ID="ChBox_AvisoDePrivacidad" CssClass="ChBox_AvisoDePrivacidad" runat="server" Text="He leído y acepto las" />&nbsp;
                                                <asp:Button ID="Btn_LeerAvisoDePrivacidad" runat="server" Text="políticas de privacidad" CssClass="btn_AvisoDePrivacidad" OnClick="Btn_LeerAvisoDePrivacidad_Click" />
                        </div>
                        <asp:Label ID="Lbl_AvisoDePrivacidad" runat="server" Text="" CssClass="requeridos"></asp:Label>
                    </td>
                </tr>
                <!-- -------------------- Boton -------------------- -->
                <tr>
                    <td colspan="1">
                        <div style="display: block; align-items: center; justify-content: center; padding: 2% 0%;">
                            <div class="g-recaptcha" data-sitekey="6LcbpcAmAAAAAJBztTedOPsxLKsO39wQtywQWTfR"></div>

                        </div>
                        <div id="dv_BtnCrearCuenta" style="display: block; justify-content: center; padding: 2% 0%;">
                            <asp:Button Width="100%" CssClass="pager_btn" ID="BtnCrearCuenta" runat="server" Text="Crear Cuenta" ValidationGroup="VG01" OnClientClick="showLoadingCreandoCuenta().then(() => BtnCrearCuenta_Click());" OnClick="BtnCrearCuenta_Click" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <script>
        var currentPage = window.location.pathname;

        var Menu_Options = document.getElementById('dv_MenuOpts_Header');
        var dv_Botones = document.getElementById('container_Btns_Header');

        if (currentPage === "/CrearCuenta.aspx") {
            Menu_Options.style.display = "none";
            dv_Botones.style.display = "none";
        }
        else {
            Menu_Options.style.display = "flex";
            dv_Botones.style.display = "flex";
        }
    </script>
</asp:Content>
