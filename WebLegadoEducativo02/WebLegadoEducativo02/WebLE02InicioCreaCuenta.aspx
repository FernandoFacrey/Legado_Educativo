<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebLE02InicioCreaCuenta.aspx.cs" Inherits="WebLegadoEducativo02.WebLE02InicioCreaCuenta" Async="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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

    <table id="tableInicioCrea">
        <tr>
            <td id="imgIniciaCrea" style="width: 50%;"></td>
            <td style="width: 50%;">
                <div class="txtInicio">
                    <h1>Ingresa a tu cuenta
                    </h1>
                    <p>
                        Si aún no tienes una cuenta <a id="hrefIniciaLE" href="CrearCuenta.aspx">Inicia Tu legado Aquí</a>
                    </p>
                </div>
                <div style="width: 100%; vertical-align: middle;">
                    <table id="formInicio">
                        <tr>
                            <td>
                                <p class="titleCampos">Correo Electrónico</p>
                                <asp:TextBox ID="txtB_IniciaCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                <asp:RequiredFieldValidator CssClass="requeridos" ID="IniciaCorreo" runat="server" ErrorMessage="Correo Electronico Requerido" ControlToValidate="txtB_IniciaCorreoElec" ForeColor="Red" ValidationGroup="VG02">Correo Electronico Requerido *</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-bottom: 0px; margin-bottom: 0px;">
                                <p class="titleCampos">Contraseña</p>
                                <asp:TextBox ID="txtB_Contraseña" runat="server" CssClass="form_campo" TextMode="Password" ToolTip='"Reglas de seguridad"'></asp:TextBox><br />
                                <div style="width: 100%">
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="width: 50%">
                                                <asp:Label ID="lbl_VerificaCorreoContra" runat="server" Text="Correo o Contraseña Incorrecto" CssClass="requeridos" Visible="false"></asp:Label>
                                                <asp:RequiredFieldValidator CssClass="requeridos" ID="IniciaContra" runat="server" ErrorMessage="Contraseña Requerida" ControlToValidate="txtB_Contraseña" ForeColor="Red" ValidationGroup="VG02">Contraseña Requerida *</asp:RequiredFieldValidator>
                                            </td>
                                            <td style="text-align: end; padding: 0px;">
                                                <asp:Button ID="btn_RecuContra" CssClass="btn_RecuContra" runat="server" Text="Olvidé mi contraseña" OnClick="Btn_RecuContra_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center;">
                                <div style="display: flex; justify-content: center;">
                                    <div class="containerBtnInicioSesion">
                                        <div id="dv_BtnIniciarSesion">
                                            <asp:Button CssClass="btnInicioSesion" ID="BtnIniciarSesion" runat="server" Text="Iniciar Sesión" ValidationGroup="VG02" OnClientClick="showLoadingIniciaSesion().then(() => BtnIniciarSesion_Click());" OnClick="BtnIniciarSesion_Click" />
                                        </div>

                                        <div id="bloqueaBtnInicioSesion" class="bloqueabtnInicioSesion" style="display: none;">
                                            <div class="dots" style="color: white; height: 50px; width: 150px;">
                                                <div class="dot1">.</div>
                                                <div class="dot2">.</div>
                                                <div class="dot3">.</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div id="AnimacionIniciarSesion" style="display: none;">
                                    <div style="display: flex; justify-content: center;">
                                        <div style="display: flex;">
                                            <div class="loader-container">
                                                <div class="loader"></div>
                                                <div class="loader2"></div>
                                            </div>
                                            <div class="loadertxt-container">
                                                <p class="loader-text">
                                                    Cargando Información
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>

    <asp:Panel ID="Pnl_RecuContra" CssClass="Pnl_RecuContra" runat="server">
        <div id="div_Pnl_RecuContra">
            <div class="container_Cerrar" id="container_Cerrar">
                <asp:Button ID="Btn_Cerrar" CssClass="Btn_Cerrar" runat="server" Text="X" OnClick="Btn_Cerrar_Click" />
            </div>
            <div id="container01_RecuContra">
                <div id="container02_RecuContra">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="txtInicio">
                                    <h1>Recupera tu contraseña</h1>
                                    <p>Ingresa tu correo electronico</p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Pnl_IngresaCorreo" runat="server">
                                    <div>
                                        <table>
                                            <tr>
                                                <td colspan="2">
                                                    <p class="titleCampos">Correo Electronico</p>
                                                    <asp:TextBox ID="txtB_CorreoRecuContra" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="CorreoRecuContra" runat="server" ErrorMessage="Correo Electronico Requerido" ControlToValidate="txtB_CorreoRecuContra" ForeColor="Red" ValidationGroup="VGRC">Correo Electronico Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="text-align: center;">
                                                    <asp:Label CssClass="txtInicio" ID="Lbl_CorreoIncorrecto" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">
                                                    <asp:Button CssClass="btnsRecuContra" ID="Btn_ConfirmaCorreo" runat="server" Text="Confirmar Correo" ValidationGroup="VGRC" OnClick="Btn_ConfirmaCorreo_Click" />
                                                    <asp:Panel ID="PnlCargando" runat="server">
                                                        <div style="display: flex; justify-content: center;">
                                                            <div style="display: flex;">
                                                                <div class="loader-container">
                                                                    <div class="loader"></div>
                                                                    <div class="loader2"></div>
                                                                </div>
                                                                <div class="loadertxt-container">
                                                                    <p class="loader-text">
                                                                        Cargando Información
                                                                    </p>
                                                                    <div class="dots">
                                                                        <div class="dot1">.</div>
                                                                        <div class="dot2">.</div>
                                                                        <div class="dot3">.</div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Pnl_FormRecuContra" runat="server">
                                    <div>
                                        <div>
                                            <table style="width: 100%">
                                                <tr>
                                                    <td>
                                                        <p class="titleCampos">Correo Electrónico</p>
                                                        <asp:TextBox ID="txtB_RecuCotraCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Correo Electrónico Requerido" ControlToValidate="txtB_RecuCotraCorreoElec" ForeColor="Red" ValidationGroup="VG01">Correo Electrónico Requerido *</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <p class="titleCampos">Confirma tu Correo Electrónico</p>
                                                        <asp:TextBox ID="txtB_RecuContraConfirmaCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                        <asp:CompareValidator CssClass="requeridos" ID="CompareValidator1" runat="server" ErrorMessage="Correo Electrónico no coincide" ControlToCompare="txtB_RecuCotraCorreoElec" ControlToValidate="txtB_RecuContraConfirmaCorreoElec" ValidationGroup="VG01"></asp:CompareValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <p class="titleCampos">Nueva Contraseña</p>
                                                        <asp:TextBox ID="txtB_RecuContraNContra" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                                                        <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Ingresa tu nueva Contraseña" ControlToValidate="txtB_RecuContraNContra" ForeColor="Red" ValidationGroup="VG01">Ingresa tu nueva Contraseña *</asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        <p class="titleCampos">Confirma Tu Nueva Contraseña</p>
                                                        <asp:TextBox ID="txtB_RecuContraConfirmaNContra" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                                                        <asp:CompareValidator CssClass="requeridos" ID="CompareValidator2" runat="server" ErrorMessage="Contraseña nueva no coincide" ControlToCompare="txtB_RecuContraNContra" ControlToValidate="txtB_RecuContraConfirmaNContra" ValidationGroup="VG01"></asp:CompareValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="text-align: center;">
                                                        <asp:Button CssClass="btnInicioSesion" ID="Btn_EnviarRecuContra" runat="server" Text="Enviar" ValidationGroup="VG01" OnClick="Btn_EnviarRecuContra_Click" />
                                                    </td>
                                                </tr>

                                                <tr>
                                                    <td colspan="2" style="text-align: center;">
                                                        <asp:Label CssClass="txtInicio" ID="Lbl_CorreoCorrecto" runat="server" Text=""></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
