<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="PreCotizar.aspx.cs" Inherits="WebLegadoEducativo02.PreCotizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/PreCotizarStyles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JavaScripts.js" />
        </Scripts>
    </asp:ScriptManager>

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

    <div id="AnimacionCargandoPantalla" style="display: none">
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

    <div class="Container_PreCotizar">
        <div class="PreCotizar">
            <h1>Tipos de certificado</h1>
            <div class="Container_TiposCertificados">
                <div class="TiposCertificados">
                    <div class="Container_img_Certi">
                        <img src="Resources/Sesion-Legado-Educativo-2022-348.jpg" />
                    </div>
                    <div>
                        <h1>Bachillerato</h1>
                        <p>Adquiere desde un semestre hasta el grado completo.</p>
                    </div>
                    <div class="Container_btn_Certi">
                        <asp:Button CssClass="pager_btn" ID="Btn_Bachillerato" runat="server" Text="Consulta los costos" OnClick="Btn_Bachillerato_Click" Style="width: 50%;" />
                    </div>
                </div>
                <div class="TiposCertificados">
                    <div class="Container_img_Certi">
                        <img src="Resources/51389636919_a4b3eeb881_k.jpg" />
                    </div>
                    <div>
                        <h1>Profesional</h1>
                        <p>Adquiere desde una materia hasta la carrera completa, eligiendo el área de preferencia (una materia equivale a 6 créditos).</p>
                    </div>
                    <div class="Container_btn_Certi">
                        <asp:Button CssClass="pager_btn" ID="Btn_Profesional" runat="server" Text="Consulta los costos" OnClick="Btn_Profesional_Click" Style="width: 50%;" />
                    </div>
                </div>
                <div class="TiposCertificados">
                    <div class="Container_img_Certi">
                        <img src="Resources/51388109927_e28eeb3f3d_k.jpg" />
                    </div>
                    <div>
                        <h1>Posgrado</h1>
                        <p>Adquiere desde un cuatrimestre hasta el programa completo, eligiendo el área de preferencia.</p>
                    </div>
                    <div class="Container_btn_Certi">
                        <asp:Button CssClass="pager_btn" ID="Btn_Posgrado" runat="server" Text="Consulta los costos" OnClick="Btn_Posgrado_Click" Style="width: 50%;" />
                    </div>
                </div>
            </div>
        </div>
    </div>


    <asp:Panel ID="PnlMasInfo" runat="server">
        <div class="div_PantallaEmergente">
            <div class="container01_PantallaEmergente" style="width: 55%;">
                <div class="Container_Btn_close">
                    <asp:Button ID="Btn_close_PreCotizar" runat="server" Text="X" class="Btn_close" OnClick="Btn_close_PreCotizar_Click" />
                </div>
                <div class="container02_PantallaEmergente">
                    <div id="container-lbls-masInfo">
                        <asp:Label CssClass="secciones" ID="Lbl_MasInfo" runat="server" Text="Más Información">Más Información&nbsp;</asp:Label>
                        <asp:Label CssClass="secciones" ID="Lbl_Nivel" runat="server" Text=""></asp:Label>
                    </div>
                    <div>
                        <asp:Panel ID="Pnl_Correo" runat="server">
                            <p class="txtInicio">Ingresa tu correo electrónico</p>
                            <div>
                                <table class="formulario_table">
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Primer nombre</p>
                                            <asp:TextBox ID="txtB_PrimNomMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtB_PrimNomMasInfo" ErrorMessage="Primer nombre requerido" ForeColor="Red" ValidationGroup="VG01">Primer nombre requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Segundo nombre</p>
                                            <asp:TextBox ID="txtB_SegunNomMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">Apellido paterno</p>
                                            <asp:TextBox ID="txtB_AperPaterMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtB_AperPaterMasInfo" ErrorMessage="Apellido paterno requerido" ForeColor="Red" ValidationGroup="VG01">Apellido paterno requerido *</asp:RequiredFieldValidator>
                                        </td>
                                        <td>
                                            <p class="titleCampos">Apellido materno</p>
                                            <asp:TextBox ID="txtB_AperMaterMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtB_AperMaterMasInfo" ErrorMessage="Apellido materno requerido" ForeColor="Red" ValidationGroup="VG01">Apellido materno requerido *</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div style="display: flex;">
                                                <div style="width: 30%;">
                                                    <p class="titleCampos">Correo electrónico</p>
                                                </div>
                                                <div style="display: flex; align-items: center;">
                                                    <asp:RegularExpressionValidator ID="Valida_txtB_CorreoMasInfo" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoMasInfo"
                                                        ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                                        ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                                        ValidationGroup="VG01"></asp:RegularExpressionValidator>
                                                </div>
                                            </div>
                                            <asp:TextBox ID="txtB_CorreoMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtB_CorreoMasInfo" ErrorMessage="Correo electrónico requerido" ForeColor="Red" ValidationGroup="VG01"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class="titleCampos">¿Contacto principal es Exalumno?</p>
                                            <asp:RadioButtonList CssClass="radioBL" ID="RBL_ContactExUdem" runat="server" RepeatDirection="Horizontal" OnTextChanged="RBL_ContactExUdem_TextChanged" AutoPostBack="true">
                                                <asp:ListItem Value="True">Sí</asp:ListItem>
                                                <asp:ListItem Value="False">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <td id="td_Matricula_MasInfo" runat="server" visible="false">
                                            <p class="titleCampos">Matricula</p>
                                            <asp:TextBox ID="TxtB_Matricula_MasInfo" runat="server" CssClass="form_campo"></asp:TextBox>
                                            <asp:RequiredFieldValidator CssClass="requeridos" ID="Valida_TxtB_Matricula_MasInfo" runat="server" ControlToValidate="TxtB_Matricula_MasInfo" ErrorMessage="Matricula" ForeColor="Red" ValidationGroup="VG01"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="div_AceptoAvisoPrivacidad_txt">
                                                <asp:CheckBox ID="ChBox_AvisoDePrivacidad" runat="server" Text="He leído y acepto las" />&nbsp;
                                                <asp:Button ID="Btn_LeerAvisoDePrivacidad" runat="server" Text="políticas de privacidad" CssClass="btn_AvisoDePrivacidad" OnClick="Btn_LeerAvisoDePrivacidad_Click" />
                                            </div>
                                            <asp:Label ID="Lbl_AvisoDePrivacidad" runat="server" Text="" CssClass="requeridos"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <div id="dv_BtnEnviarCorreo" style="padding: 0% 40%; display: block">
                                                <asp:Button CssClass="pager_btn" ID="BtnEnviarCorreo" runat="server" Text="Enviar" ValidationGroup="VG01" OnClientClick="showLoadingPreCotiPantallaEnviaCorreo().then(() => BtnEnviarCorreo_Click())" OnClick="BtnEnviarCorreo_Click" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
