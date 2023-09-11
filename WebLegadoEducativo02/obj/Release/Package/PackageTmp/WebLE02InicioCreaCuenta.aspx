<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebLE02InicioCreaCuenta.aspx.cs" Inherits="WebLegadoEducativo02.WebLE02InicioCreaCuenta" Async="True" MaintainScrollPositionOnPostback="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/InicioCreaStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JavaScripts.js" />
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

    <div id="Container_IniciaCrea">
        <div id="IniciaCrea">
            <div class="img"></div>
            <div class="info">
                <div>
                    <div class="txtInicio">
                        <h1>Ingresa a tu cuenta</h1>
                        <p>
                            Si aún no tienes una cuenta <a id="hrefIniciaLE" href="CrearCuenta.aspx">inicia tu Legado aquí</a>
                        </p>
                    </div>
                    <div>
                        <table class="formulario_table">
                            <tr>
                                <td>
                                    <p class="titleCampos">Correo electrónico</p>
                                    <asp:TextBox ID="txtB_IniciaCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="IniciaCorreo" runat="server" ErrorMessage="Correo electrónico requerido" ControlToValidate="txtB_IniciaCorreoElec" ForeColor="Red" ValidationGroup="VGIniciaSesion"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="titleCampos">Contraseña</p>
                                    <asp:TextBox ID="txtB_Contraseña" runat="server" CssClass="form_campo" TextMode="Password" ToolTip='"Reglas de seguridad"'></asp:TextBox>
                                    <div>
                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="IniciaContra" runat="server" ErrorMessage="Contraseña requerida" ControlToValidate="txtB_Contraseña" ForeColor="Red" ValidationGroup="VGIniciaSesion"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">
                                    <asp:Label ID="lbl_VerificaCorreoContra" runat="server" Text="" CssClass="requeridos" Visible="false" Style="align-items: center; justify-content: center; margin-bottom: 2%;"></asp:Label>
                                    <div style="display: flex; justify-content: center;">
                                        <div style="width: 100%">
                                            <div id="dv_BtnIniciarSesion" style="padding: 0%; display: block;">
                                                <asp:Button CssClass="pager_btn" ID="BtnIniciarSesion" runat="server" Text="Iniciar sesión" ValidationGroup="VGIniciaSesion" OnClientClick="showLoadingIniciaSesion().then(() => BtnIniciarSesion_Click());" OnClick="BtnIniciarSesion_Click" />
                                            </div>
                                        </div>
                                    </div>

                                    <div id="AnimacionIniciarSesion" style="display: none">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: end; padding: 0px;">
                                    <asp:Button ID="btn_RecuContra" CssClass="btn_RecuContra" runat="server" Text="Olvidé mi contraseña" OnClick="Btn_RecuContra_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:Panel ID="Pnl_RecuContra" CssClass="Pnl_RecuContra" runat="server">
        <div class="div_PantallaEmergente">
            <div class="container01_PantallaEmergente">
                <div class="Container_Btn_close">
                    <asp:Button ID="Btn_CloseRecuContra" runat="server" Text="X" class="Btn_close" OnClick="Btn_CloseRecuContra_Click" />
                </div>
                <div class="container02_PantallaEmergente">
                    <div class="txtInicio">
                        <h1>Recupera tu contraseña</h1>
                        <asp:Label ID="Llb_txtRecuContra" runat="server" Text="Ingresa tu correo electrónico"></asp:Label>
                    </div>
                    <div>
                        <asp:Panel ID="Pnl_IngresaCorreo" runat="server">
                            <table class="formulario_table">
                                <tr>
                                    <td colspan="2">
                                        <div style="display: flex;">
                                            <div style="width: 22%;">
                                                <p class="titleCampos">Correo electrónico</p>
                                            </div>
                                            <div style="display: flex; align-items: center;">
                                                <asp:RegularExpressionValidator ID="Valida_txtB_CorreoRecuContra" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoRecuContra"
                                                    ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                                    ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                                    ValidationGroup="VGRC"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtB_CorreoRecuContra" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                        <br />
                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="CorreoRecuContra" runat="server" ErrorMessage="Correo Electrónico Requerido *" ControlToValidate="txtB_CorreoRecuContra" ForeColor="Red" ValidationGroup="VGRC"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="text-align: center; height: auto; padding-bottom: 2%;">
                                        <asp:Label CssClass="txtInicio" ID="Lbl_CorreoIncorrecto" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding: 0% 25%">
                                        <asp:Button CssClass="pager_btn" ID="Btn_ConfirmaCorreo" runat="server" Text="Confirmar correo" ValidationGroup="VGRC" OnClick="Btn_ConfirmaCorreo_Click" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="Pnl_CodigoRecuContra" runat="server">
                            <table class="formulario_table">
                                <tr>
                                    <td style="height: auto;">
                                        <div class="txtInicio">
                                            <asp:Label ID="Lbl_MensajeCodiCorr" runat="server" Text=""></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <p class="titleCampos">Código</p>
                                        <asp:TextBox ID="TxtB_CodigoRecuContra" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                        <br />
                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RFV_CodiRC" runat="server" ErrorMessage="Código requerido" ControlToValidate="TxtB_CodigoRecuContra" ForeColor="Red" ValidationGroup="VGCodiRC"></asp:RequiredFieldValidator>
                                        <asp:Label CssClass="txtInicio" ID="Lbl_CodigoRecuContra" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div id="dv_Btn_ConfirmCodiCorr">
                                            <asp:Button CssClass="pager_btn" ID="Btn_ConfirmCodiCorr" runat="server" Text="Confirmar código" ValidationGroup="VGCodiRC" OnClick="Btn_ConfirmCodiCorr_Click" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="Pnl_FormRecuContra" runat="server">
                            <div>
                                <div>
                                    <table class="formulario_table">
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Correo electrónico</p>
                                                <asp:TextBox ID="txtB_RecuCotraCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Correo electrónico requerido" ControlToValidate="txtB_RecuCotraCorreoElec" ForeColor="Red" ValidationGroup="VG01">Correo electrónico requerido *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <p class="titleCampos">Confirma tu correo electrónico</p>
                                                <asp:TextBox ID="txtB_RecuContraConfirmaCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox>
                                                <div style="display: flex; justify-content: space-between">
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Correo electrónico requerido" ControlToValidate="txtB_RecuContraConfirmaCorreoElec" ForeColor="Red" ValidationGroup="VG01">Confirma correo electrónico requerido *</asp:RequiredFieldValidator>
                                                    <asp:CompareValidator CssClass="requeridos" ID="CompareValidator1" runat="server" ErrorMessage="Correo Electrónico no coincide" ControlToCompare="txtB_RecuCotraCorreoElec" ControlToValidate="txtB_RecuContraConfirmaCorreoElec" ValidationGroup="VG01"></asp:CompareValidator>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <p class="titleCampos">Nueva contraseña</p>
                                                <asp:TextBox ID="txtB_RecuContraNContra" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Ingresa tu nueva contraseña" ControlToValidate="txtB_RecuContraNContra" ForeColor="Red" ValidationGroup="VG01">Ingresa tu nueva contraseña *</asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <p class="titleCampos">Confirma tu nueva contraseña</p>
                                                <asp:TextBox ID="txtB_RecuContraConfirmaNContra" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox>
                                                <div style="display: flex; justify-content: space-between">
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingresa tu nueva contraseña" ControlToValidate="txtB_RecuContraConfirmaNContra" ForeColor="Red" ValidationGroup="VG01">Ingresa tu nueva contraseña *</asp:RequiredFieldValidator>
                                                    <asp:CompareValidator CssClass="requeridos" ID="CompareValidator2" runat="server" ErrorMessage="Contraseña nueva no coincide" ControlToCompare="txtB_RecuContraNContra" ControlToValidate="txtB_RecuContraConfirmaNContra" ValidationGroup="VG01"></asp:CompareValidator>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <div id="dv_Btn_EnviarRecuContra">
                                                    <asp:Button CssClass="pager_btn" ID="Btn_EnviarRecuContra" Width="100%" runat="server" Text="Enviar" ValidationGroup="VG01" OnClick="Btn_EnviarRecuContra_Click" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </asp:Panel>
                        <asp:Panel ID="Pnl_CambioContra" runat="server">
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <div>
                                            <div style="display: flex; justify-content: center; align-items: center; padding: 5%;">
                                                <asp:Label ID="lbl_CambioContra" runat="server" Text="" Style="font-size: 1.5vw;" ForeColor="Black" CssClass="secciones"></asp:Label><br />
                                                <br />
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div style="display: flex; align-items: center; justify-content: center;">
                                            <asp:Button Width="20%" CssClass="pager_btn" ID="Btn_RedireIniciaSesion" runat="server" Text="Iniciar sesión" OnClick="Btn_RedireIniciaSesion_Click" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>

</asp:Content>
