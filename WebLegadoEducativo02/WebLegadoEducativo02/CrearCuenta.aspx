<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="WebLegadoEducativo02.CrearCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

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
                                    <asp:RadioButton ID="RBtn_AceptaAvisoPrivacidad" runat="server" Text="Acepto el aviso de privacidad"  OnCheckedChanged="RBtn_AceptaAvisoPrivacidad_CheckedChanged" Font-Names="Arial Rounded MT" />
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

    <asp:Panel ID="pnl_CorreoCrearCuenta" CssClass="Pnl_boolTitular" runat="server">
        <div id="div_Pnl_CorreoCrearCuenta">
            <div id="container01_CorreoCrearCuenta">
                <div id="container02_CorreoCrearCuentar">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                <div class="txtInicio">
                                    <p>Ingresa tu correo electronico</p>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p class="titleCampos">Correo Electronico</p>
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
                                <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_ConfirmaCorreoCreaCuenta" runat="server" Text="Confirmar Correo" OnClick="Btn_ConfirmaCorreoCreaCuenta_Click" ValidationGroup="VG02" />
                                <asp:Button Width="100%" CssClass="pager_btn" ID="Btn_RedireIniciaSesion" runat="server" Text="Iniciar Sesión" OnClick="Btn_RedireIniciaSesion_Click"/>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </asp:Panel>

    <div style="padding: 5%">
        <div class="container-form">
            <div class="form">
                <table id="formulario" style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label CssClass="secciones" ID="Lbl_MasInfo" runat="server" Text="Inicia Tu Legado"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">Nombre de Pila</p>
                            <asp:TextBox ID="txtB_NombrePila" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtB_NombrePila" ErrorMessage="Nombre de Pila Requerido" ForeColor="Red" ValidationGroup="VG01">Nombre de Pila Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">Segundo Nombre</p>
                            <asp:TextBox ID="txtB_SeguNom" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <br />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <p class="titleCampos">Apellido Paterno</p>
                            <asp:TextBox ID="txtB_ApePater" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Apellido Paterno Requerido" ControlToValidate="txtB_ApePater" ForeColor="Red" ValidationGroup="VG01">Apellido Paterno Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">Apellido Materno</p>
                            <asp:TextBox ID="txtB_ApeMater" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Apellido Materno Requerido" ControlToValidate="txtB_ApeMater" ForeColor="Red" ValidationGroup="VG01">Apellido Materno Requerido *</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">Teléfono Movil</p>
                            <asp:TextBox ID="txtB_TelMovil" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Teléfono movil requerido" ControlToValidate="txtB_TelMovil" ForeColor="Red" ValidationGroup="VG01">Teléfono movil requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">Teléfono Particular</p>
                            <asp:TextBox ID="txtB_TelParti" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Teléfono Particular requerido" ControlToValidate="txtB_TelParti" ForeColor="Red" ValidationGroup="VG01">Teléfono Particular requerido *</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">Correo Electrónico</p>
                            <asp:TextBox ID="txtB_CorreoElec" runat="server" CssClass="form_campo" OnTextChanged="TxtB_CorreoElec_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Correo Electrónico Requerido" ControlToValidate="txtB_CorreoElec" ForeColor="Red" ValidationGroup="VG01">Correo Electrónico Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">Confirma tu Correo Electrónico</p>
                            <asp:TextBox ID="txtB_ConfirmaCorreoElec" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:CompareValidator CssClass="requeridos" ID="CompareValidator1" runat="server" ErrorMessage="Correo Electrónico no coincide" ControlToCompare="txtB_CorreoElec" ControlToValidate="txtB_ConfirmaCorreoElec" ValidationGroup="VG01"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">Contraseña</p>
                            <asp:TextBox ID="txtB_Contraseña" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Correo Electronico Incorrecto" ControlToValidate="txtB_CorreoElec" ForeColor="Red" ValidationGroup="VG01">Correo Electronico Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">Confirma Tu Contraseña</p>
                            <asp:TextBox ID="txtB_ConfirmaContraseña" runat="server" CssClass="form_campo" TextMode="Password"></asp:TextBox><br />
                            <asp:CompareValidator CssClass="requeridos" ID="CompareValidator2" runat="server" ErrorMessage="Contraseña no coincide" ControlToCompare="txtB_Contraseña" ControlToValidate="txtB_ConfirmaContraseña" ValidationGroup="VG01"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">¿Como te esteraste?</p>
                            <asp:DropDownList ID="Ddl_fuenteLeadOri" runat="server" CssClass="form_campo" OnSelectedIndexChanged="Ddl_fuenteLeadOri_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator9" runat="server" ErrorMessage="Como te enteraste Requerido" ControlToValidate="Ddl_fuenteLeadOri" ForeColor="Red" ValidationGroup="VG01">Como te enteraste Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">¿Como te esteraste?</p>
                            <asp:DropDownList ID="Ddl_fuenteLeadSubcat" runat="server" CssClass="form_campo"></asp:DropDownList>
                            <asp:TextBox ID="txtB_fuenteLeadOtro" runat="server" CssClass="form_campo"></asp:TextBox>
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator10" runat="server" ErrorMessage="Como te enteraste Requerido" ControlToValidate="Ddl_fuenteLeadSubcat" ForeColor="Red" ValidationGroup="VG01">Como te enteraste Requerido *</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p class="titleCampos">Fecha de Nacimiento</p>
                            <asp:TextBox ID="txtB_FechaNac" runat="server" CssClass="form_campo"></asp:TextBox><br />
                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator11" runat="server" ErrorMessage="Fecha de nacimiento Requerido" ControlToValidate="txtB_FechaNac" ForeColor="Red" ValidationGroup="VG01">Fecha de nacimiento Requerido *</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <p class="titleCampos">¿Contacto principal es Exalumno?</p>
                            <asp:RadioButtonList CssClass="radioBL" ID="RBL_ContactExUdem" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>Sí</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <!-- -------------------- Boton -------------------- -->
                    <tr>
                        <td colspan="2">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Button Width="100%" CssClass="pager_btn" ID="BtnCrearCuenta" runat="server" Text="Crear Cuenta" ValidationGroup="VG01" OnClick="BtnCrearCuenta_Click" />
                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DynamicLayout="true">
                                        <ProgressTemplate>
                                            <div style="display: flex; justify-content: center; align-items: center; position: relative;">
                                                <div class="loader-container">
                                                    <div class="loader"></div>
                                                    <div class="loader2"></div>
                                                </div>
                                                <div class="loadertxt-container">
                                                    <p class="loader-text">
                                                        Cargando Información<div class="dots">
                                                            <div class="dot1">.</div>
                                                            <div class="dot2">.</div>
                                                            <div class="dot3">.</div>
                                                        </div>
                                                    </p>
                                                </div>
                                            </div>
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
