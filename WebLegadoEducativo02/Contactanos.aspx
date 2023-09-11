<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Contactanos.aspx.cs" Inherits="WebLegadoEducativo02.Contactanos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/ContactanosStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

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

    <div class="Principal_Container_Contactanos">
        <div class="Container_Contactanos">
            <div class="Container_Form">
                <div class="Form">
                    <h1>Solicita información</h1>
                    <table class="formulario_Contactanos">
                        <tr>
                            <td>
                                <div>
                                    <p class="titleCamposContactanos">Primer nombre</p>
                                    <asp:TextBox ID="txtB_PrimNomConocenos" runat="server" CssClass="form_campo_contactanos"></asp:TextBox><br />
                                    <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtB_PrimNomConocenos" ErrorMessage="Primer nombre requerido" ForeColor="Red" ValidationGroup="VG_Conocenos"></asp:RequiredFieldValidator>
                                </div>
                            </td>
                            <td>
                                <div>
                                    <p class="titleCamposContactanos">Segundo nombre</p>
                                    <asp:TextBox ID="txtB_SegunNomMasConocenos" runat="server" CssClass="form_campo_contactanos"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p class="titleCamposContactanos">Apellido paterno</p>

                                <asp:TextBox ID="txtB_AperPaterConocenos" runat="server" CssClass="form_campo_contactanos"></asp:TextBox><br />
                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtB_AperPaterConocenos" ErrorMessage="Apellido paterno requerido" ForeColor="Red" ValidationGroup="VG_Conocenos"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                                <p class="titleCamposContactanos">Apellido materno</p>
                                <asp:TextBox ID="txtB_AperMaterConocenos" runat="server" CssClass="form_campo_contactanos"></asp:TextBox><br />
                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtB_AperMaterConocenos" ErrorMessage="Apellido materno requerido" ForeColor="Red" ValidationGroup="VG_Conocenos"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p class="titleCamposContactanos">¿Contacto principal es Exalumno?</p>
                                <asp:RadioButtonList CssClass="radioBL_Contactanos" ID="RBL_ContactExUdemConocenos" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" OnTextChanged="RBL_ContactExUdemConocenos_TextChanged">
                                    <asp:ListItem Value="True">Sí</asp:ListItem>
                                    <asp:ListItem Value="False">No</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <asp:Panel ID="Pnl_MatriculaContactanos" runat="server" Visible="false">
                                <td>
                                    <p class="titleCamposContactanos">Matricula</p>
                                    <asp:TextBox ID="TxtB_MatriculaContactanos" runat="server" CssClass="form_campo_contactanos"></asp:TextBox><br />
                                </td>
                            </asp:Panel>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="display: flex; align-items: center; padding: 1% 0%;">
                                    <div style="width: 29%;">
                                        <p class="titleCamposContactanos">Correo electrónico</p>
                                    </div>
                                    <div style="display: flex; align-items: center;">
                                        <asp:RegularExpressionValidator ID="Valida_txtB_CorreoElecConocenos" CssClass="requeridos" runat="server" ControlToValidate="txtB_CorreoElecConocenos"
                                            ErrorMessage="Por favor, introduzca un correo electrónico válido"
                                            ValidationExpression="\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b"
                                            ValidationGroup="VG_Conocenos"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="txtB_CorreoElecConocenos" runat="server" CssClass="form_campo_contactanos" Style="width: 97.5%;"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtB_CorreoElecConocenos" ErrorMessage="Correo electrónico requerido" ForeColor="Red" ValidationGroup="VG_Conocenos"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="display: flex; align-items: center; padding: 1% 0%;">
                                    <div style="width: 36%;">
                                        <p class="titleCamposContactanos">Fecha de nacimiento</p>
                                    </div>
                                    <div style="display: flex;">
                                        <asp:RegularExpressionValidator ID="Valida_txtB_FechaNacConocenos" runat="server" ControlToValidate="txtB_FechaNacConocenos" CssClass="requeridos"
                                            ErrorMessage="Por favor, introduzca una fecha válida en formato dd/mm/yyyy"
                                            ValidationExpression="^((0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4}))|((\d{4})[-\/](0?[1-9]|1[0-2])[-\/](0?[1-9]|[12][0-9]|3[01]))$"
                                            ValidationGroup="VG_Conocenos"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="txtB_FechaNacConocenos" runat="server" CssClass="form_campo_contactanos" TextMode="Date" Style="width: 97.5%;"></asp:TextBox><br />
                                <asp:RequiredFieldValidator CssClass="requeridos" ID="RequiredFieldValidator11" runat="server" ErrorMessage="Fecha de nacimiento requerida" ControlToValidate="txtB_FechaNacConocenos" ForeColor="Red" ValidationGroup="VG_Conocenos"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div class="div_AceptoAvisoPrivacidad_txt" style="background-color: #e1dfe0; width: 98%;">
                                    <asp:CheckBox ID="ChBox_AvisoDePrivacidad" runat="server" Text="He leído y acepto las " />
                                    <asp:Button ID="Btn_LeerAvisoDePrivacidad" runat="server" Text=" políticas de privacidad" CssClass="btn_AvisoDePrivacidad" OnClick="Btn_LeerAvisoDePrivacidad_Click" />
                                </div>
                                <asp:Label ID="Lbl_AvisoDePrivacidad" runat="server" Text="" CssClass="requeridos"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="dv_Btn_EnviarConocenos" style="display: block">
                                    <asp:Button CssClass="BtnEnviarConocenos" ID="Btn_EnviarConocenos" runat="server" Text="Enviar" ValidationGroup="VG_Conocenos" OnClientClick="showLoadingContactanos().then(() => Btn_EnviarConocenos_Click())" OnClick="Btn_EnviarConocenos_Click" />
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class="Container_InfoContact">
                <div class="InfoContact">
                    <div class="Container_Img_Txt">
                        <div class="Container_Img">
                            <img src="https://www.udem.edu.mx/themes/custom/udm/svg/general/icono-locacion.svg" />
                        </div>
                        <div class="Container_Txt">
                            <h1>Dirección</h1>
                            <p>
                                Av. Ignacio Morones Prieto 4500 poniente
                                <br />
                                Col. Jesús M. Garza
                                <br />
                                San Pedro Garza García
                                <br />
                                Nuevo León, México
                                <br />
                                C. P. 6623
                            </p>
                        </div>
                    </div>
                    <div class="Container_Img_Txt">
                        <div class="Container_Img">
                            <img src="	https://www.udem.edu.mx/themes/custom/udm/svg/general/icono-reloj-sol.svg" />
                        </div>
                        <div class="Container_Txt">
                            <h1>Horario</h1>
                            <p>
                                Lunes a viernes<br />
                                8:00 a 17:30 horas<br />
                            </p>
                        </div>
                    </div>
                    <div class="Container_Img_Txt">
                        <div class="Container_Img">
                            <img src="https://www.udem.edu.mx/themes/custom/udm/svg/general/icono-telefono.svg" />
                        </div>
                        <div class="Container_Txt">
                            <h1>Teléfono</h1>
                            <p>
                                81-8215-1030
                                <br />
                            </p>
                        </div>
                    </div>
                    <div class="Container_Img_Txt">
                        <div class="Container_Img">
                            <img src="https://www.udem.edu.mx/themes/custom/udm/svg/general/icono-sobre-sombra.svg" />
                        </div>
                        <div class="Container_Txt">
                            <h1>Correo</h1>
                            <a>legadoeducativo@udem.edu.mx</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="Container_Pag_Asesoras">
        <div class="Pag_Asesoras">
            <h1>Agenda una cita con nuestras asesoras</h1>
            <div class="Container_Asesoras">
                <div class="Asesoras">
                    <div class="Container_img_ase">
                        <img src="Resources/Jessica.png" />
                    </div>
                    <div style="padding: 0% 3%;">
                        <h1>Jessica P. Garza Mata</h1>
                        <a>Asesora Legado Educativo UDEM</a>
                        <p class="a_corre">jessica.garza@udem.edu.mx</p>
                        <p>(81) 2039 3435</p>
                    </div>
                    <div class="Container_btn_Ase">
                        <asp:Button CssClass="pager_btn" ID="Btn_Jessica" runat="server" Text="Programa tu cita" Style="width: 80%;" />
                    </div>
                </div>
                <div class="Asesoras">
                    <div class="Container_img_ase">
                        <img src="Resources/Lilia.png" />
                    </div>
                    <div style="padding: 0% 3%;">
                        <h1>Lilia Ivete Leal Mendoza</h1>
                        <a>Asesora Legado Educativo UDEM</a>
                        <p class="a_corre">liliai.leal@udem.edu.mx</p>
                        <p>(81) 2622 6703</p>
                    </div>
                    <div class="Container_btn_Ase">
                        <asp:Button CssClass="pager_btn" ID="Btn_Lilia" runat="server" Text="Programa tu cita" Style="width: 80%;" />
                    </div>
                </div>
                <div class="Asesoras">
                    <div class="Container_img_ase">
                        <img src="Resources/Gabriela-Zedan.png" />
                    </div>
                    <div style="padding: 0% 3%;">
                        <h1>Gabriela Zedán García</h1>
                        <a>Asesora Legado Educativo UDEM</a>
                        <p class="a_corre">gabriela.zedan@udem.edu.mx</p>
                        <p>(81) 81 1599 2081</p>
                    </div>
                    <div class="Container_btn_Ase">
                        <asp:Button CssClass="pager_btn" ID="Btn_Gabriela" runat="server" Text="Programa tu cita" Style="width: 80%;" />
                    </div>
                </div>
                <div class="Asesoras">
                    <div class="Container_img_ase">
                        <img src="Resources/Rocio-Alanis-28.jpg" style="object-position: center 30%;" />
                    </div>
                    <div style="padding: 0% 3%;">
                        <h1>Rocío Alanís Fuentes</h1>
                        <a>Asesora Legado Educativo UDEM</a>
                        <p class="a_corre">rocio.alanisf@udem.edu.mx</p>
                        <p>(81) 2039 3434</p>
                    </div>
                    <div class="Container_btn_Ase">
                        <asp:Button CssClass="pager_btn" ID="Btn_Rocio" runat="server" Text="Programa tu cita" Style="width: 80%;" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function showLoadingContactanos() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_Btn_EnviarConocenos').style.display = "none";
        }
    </script>
</asp:Content>
