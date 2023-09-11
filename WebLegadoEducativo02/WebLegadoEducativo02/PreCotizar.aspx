<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="PreCotizar.aspx.cs" Inherits="WebLegadoEducativo02.PreCotizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <asp:Panel ID="Pnl_NivelInteres" runat="server">
        <div id="slider">
            <ul class="slider">
                <li id="slide1">
                    <asp:Panel ID="Pnl_ImgBach" runat="server" OnLoad="Page_Load">
                        <div id="divInfo">
                            <div class="backImg">
                                <img class="img" src="Resources/Bachillerato01.jpg" />
                            </div>
                            <div class="froImg">
                                <table>
                                    <tr>
                                        <td>
                                            <img src="Resources/Bachillerato01.jpg" />
                                        </td>
                                        <td style="width: 900px; padding: 25px; vertical-align: middle;">
                                            <p class="txtinfopanel">
                                                Adquiere desde un semestre hasta el grado completo.
                                            </p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </asp:Panel>
                </li>
                <li id="slide2">
                    <asp:Panel ID="Pnl_ImgProf" runat="server" OnLoad="Page_Load">
                        <div>
                            <div class="backImg">
                                <img class="img" src="Resources/Profesional01.jpg" />
                            </div>
                            <div class="froImg">
                                <table>
                                    <tr>
                                        <td>
                                            <img src="Resources/Profesional01.jpg" />
                                        </td>
                                        <td style="width: 900px; padding: 25px; vertical-align: middle;">
                                            <p class="txtinfopanel">
                                                Adquiere desde una materia hasta la carrera completa, eligiendo el área de preferencia (una materia equivale a 6 créditos).
                                            </p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </asp:Panel>
                </li>
                <li id="slide3">
                    <asp:Panel ID="Pnl_ImgPos" runat="server" OnLoad="Page_Load">
                        <div>
                            <div class="backImg">
                                <img class="img" src="Resources/Posgrado01.jpg" />
                            </div>
                            <div class="froImg">
                                <table>
                                    <tr>
                                        <td>
                                            <img src="Resources/Posgrado01.jpg" />
                                        </td>
                                        <td style="width: 900px; padding: 25px; vertical-align: middle;">
                                            <p class="txtinfopanel">
                                                Adquiere desde un cuatrimestre hasta el programa completo, eligiendo el área de preferencia.
                                            </p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </asp:Panel>
                </li>
            </ul>
        </div>
        <div style="width: 100%;">
            <asp:Panel ID="pnl_nivelLE" CssClass="pnl_nivelLE" runat="server" HorizontalAlign="Center" Width="100%">
                <div id="container_nivelLE">
                    <ul class="menu">
                        <li>
                            <asp:Button CssClass="menu_Button" ID="Btn_Bachillerato" runat="server" Text="Bachillerato" OnClick="Btn_Bachillerato_Click" />
                        </li>
                        <li>
                            <asp:Button CssClass="menu_Button" ID="Btn_Profesional" runat="server" Text="Profesional" OnClick="Btn_Profesional_Click" />
                        </li>
                        <li>
                            <asp:Button CssClass="menu_Button" ID="Btn_Posgrado" runat="server" Text="Posgrado" OnClick="Btn_Posgrado_Click" />
                        </li>
                    </ul>
                    <asp:Button CssClass="menu_Button" ID="BtnCotizador" runat="server" Text="Consulta los Costos" OnClick="BtnCotizador_Click" />
                </div>
            </asp:Panel>
        </div>
    </asp:Panel>
    <asp:Panel ID="PnlMasInfo" runat="server">

        <div id="div_Pnl_MasInfo">
            <div class="container_Cerrar" id="container_Cerrar">
                <asp:Button ID="Btn_Cerrar" CssClass="Btn_Cerrar" runat="server" Text="X" OnClick="Btn_Cerrar_Click" />
            </div>
            <div id="container01_MasInfo">
                <div id="container02_MasInfo">
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <div>
                                    <div id="container-lbls-masInfo">
                                        <div>
                                            <asp:Label CssClass="secciones" ID="Lbl_MasInfo" runat="server" Text="Más Información">Más Información &nbsp;</asp:Label>
                                        </div>
                                        <div>
                                            <asp:Label CssClass="secciones" ID="Lbl_Nivel" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Pnl_Correo" runat="server">
                                    <p class="txtInicio">Ingresa tu correo electronico</p>
                                    <br />
                                    <br />
                                    <div>
                                        <table style="width: 100%;">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nombre de Pila</p>
                                                    <asp:TextBox ID="txtB_PrimNomMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtB_PrimNomMasInfo" ErrorMessage="Primer Nombre requerido" ForeColor="Red" ValidationGroup="VG01">Primer Nombre Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Segundo Nombre</p>
                                                    <asp:TextBox ID="txtB_SegunNomMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Apellido Paterno</p>
                                                    <asp:TextBox ID="txtB_AperPaterMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtB_AperPaterMasInfo" ErrorMessage="Apellido Paterno requerido" ForeColor="Red" ValidationGroup="VG01">Apellido Paterno Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Apellido Materno</p>
                                                    <asp:TextBox ID="txtB_AperMaterMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtB_AperMaterMasInfo" ErrorMessage="Apellido Materno requerido" ForeColor="Red" ValidationGroup="VG01">Apellido Materno Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Correo Electronico</p>
                                                    <asp:TextBox ID="txtB_CorreoMasInfo" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtB_CorreoMasInfo" ErrorMessage="Correo electronico requerido" ForeColor="Red" ValidationGroup="VG01">Correo Electronico Requerido *</asp:RequiredFieldValidator>
                                                    <br />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <div id="dv_BtnEnviarCorreo" style="display: block">
                                                        <asp:Button Width="100%" CssClass="pager_btn" Style="display: block" ID="BtnEnviarCorreo" runat="server" Text="Enviar" ValidationGroup="VG01" OnClientClick="showLoadingPreCotiPantallaEnviaCorreo().then(() => BtnEnviarCorreo_Click())" OnClick="BtnEnviarCorreo_Click" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="Pnl_InfoExta" runat="server">
                                    <div>
                                        <div class="txtInicio">
                                            <h3>¿Desea información adicional?</h3>
                                        </div>
                                        <div>
                                            <table style="width: 100%;">
                                                <tr>
                                                    <td style="text-align: center;">
                                                        <asp:Button ID="Btn_InfoExtraSI" CssClass="menu_Button" Width="80%" runat="server" Text="Si" OnClick="Btn_InfoExtraSI_Click" />
                                                    </td>
                                                    <td style="text-align: center;">
                                                        <asp:Button ID="Btn_InfoExtraNO" CssClass="menu_Button" Width="80%" runat="server" Text="No" OnClick="Btn_InfoExtraNO_Click" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="Pnl_FormInfoExtra" runat="server">
                                    <div>
                                        <table id="formulario" style="width: 100%">
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Nombre de Pila</p>
                                                    <asp:TextBox ID="txtB_NombrePila" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtB_NombrePila" ErrorMessage="Nombre de Pila Requerido" ForeColor="Red" ValidationGroup="VG02">Nombre de Pila Requerido *</asp:RequiredFieldValidator>
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
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Apellido Paterno Requerido" ControlToValidate="txtB_ApePater" ForeColor="Red" ValidationGroup="VG02">Apellido Paterno Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                                <td>
                                                    <p class="titleCampos">Apellido Materno</p>
                                                    <asp:TextBox ID="txtB_ApeMater" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Apellido Materno Requerido" ControlToValidate="txtB_ApeMater" ForeColor="Red" ValidationGroup="VG02">Apellido Materno Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">Teléfono Movil</p>
                                                    <asp:TextBox ID="txtB_TelMovil" runat="server" CssClass="form_campo"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Teléfono movil requerido" ControlToValidate="txtB_TelMovil" ForeColor="Red" ValidationGroup="VG02">Teléfono movil requerido *</asp:RequiredFieldValidator>
                                                </td>

                                                <td>
                                                    <p class="titleCampos">Correo Electronico</p>
                                                    <asp:TextBox ID="txtB_CorreoElec" runat="server" CssClass="form_campo" AutoPostBack="True"></asp:TextBox><br />
                                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Correo Electronico Requerido" ControlToValidate="txtB_CorreoElec" ForeColor="Red" ValidationGroup="VG02">Correo Electronico Requerido *</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <p class="titleCampos">¿Contacto principal es Exalumno?</p>
                                                    <asp:RadioButtonList CssClass="radioBL" ID="RBL_ContactExUdem" runat="server" RepeatDirection="Horizontal">
                                                        <asp:ListItem Value="True">Sí</asp:ListItem>
                                                        <asp:ListItem Value="False">No</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <div id="dv_BtnEnviarForm" style="display: block">
                                                        <asp:Button Width="100%" CssClass="pager_btn" ID="BtnEnviarForm" runat="server" Text="Enviar" ValidationGroup="VG02" OnClientClick="showLoadingPreCotiPantallaEnviaForm().then(() => BtnEnviarForm_Click())" OnClick="BtnEnviarForm_Click" />
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
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
