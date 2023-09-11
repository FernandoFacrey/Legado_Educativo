<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="HomePerfil.aspx.cs" Inherits="WebLegadoEducativo02.HomePerfil" MaintainScrollPositionOnPostback="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/HomePerfilStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="SM" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/JavaScripts.js" />
        </Scripts>
    </asp:ScriptManager>
    <div id="AnimacionCargandoSolicitud" style="display: none;">
        <div class="div_Pnl_PantallaCargando">
            <div class="container01_PantallaCargando">
                <div class="container02_PantallaCargando">
                    <div class="General_loaderContainer">
                        <div class="loader_container">
                            <div class="loader"></div>
                            <div class="loader2"></div>
                        </div>
                        <div class="loadertxt_container">
                            <span class="txt_Cargando">Creando tu solicitud</span>
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
    <div class="container_encabezado">
        <div class="encabezado">
            <div class="filterImg"></div>
            <div class="filter2"></div>
            <div class="container_txt" style="width: auto;">
                <div class="txtEncabezadoPerfil">
                    <asp:Label ID="Lbl_mensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="container_img">
                <img src="Resources/SoliLE.jpg" />
            </div>
        </div>
    </div>


    <div id="dv_containerMenuPerfil">
        <div id="containerMenuPerfil">
            <div id="containerOptions">
                <table id="tableOptions">
                    <tr>
                        <td>
                            <asp:Button ID="Btn_Perfil" CssClass="BtnsOptionsPerfil" runat="server" Text="Perfil" OnClientClick="showLoadingHomePerfil().then(() => Btn_Perfil_Click());" OnClick="Btn_Perfil_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn_Solicitudes" CssClass="BtnsOptionsPerfil" runat="server" Text="Solicitudes" OnClientClick="showLoadingHomePerfil().then(() => Btn_Solicitudes_Click());" OnClick="Btn_Solicitudes_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn_Familiares" CssClass="BtnsOptionsPerfil" runat="server" Text="Familiares" OnClientClick="showLoadingHomePerfil().then(() => Btn_Familiares_Click());" OnClick="Btn_Familiares_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn_Compras" CssClass="BtnsOptionsPerfil" runat="server" Text="Compras" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn_Certificados" CssClass="BtnsOptionsPerfil" runat="server" Text="Certificados" />
                        </td>
                    </tr>
                </table>
            </div>
            <div id="containerContent">
                <div id="animacionOptions" style="display: none;">
                    <div class="loadertxt_container" style="justify-content: center;">
                        <span class="txt_Cargando">Un momento, estamos cargando tu información</span>
                        <div class="loader_text">
                            <span>.</span>
                            <span>.</span>
                            <span>.</span>
                        </div>
                    </div>
                </div>
                <div id="panel_Options" style="display: block;">
                    <div id="containterContentOptions">
                        <div class="dv_Lbl_Perfil">
                            <asp:Label ID="Lbl_Perfil" class="secciones" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <asp:Panel ID="Pnl_DetallesSolicitud" runat="server" Visible="false">
                        <div>
                            <asp:Label ID="Lbl_DetallesSoliName" runat="server" Text="Nombre de la Solicitud:" CssClass="lbl_name_soli"></asp:Label>
                        </div>
                        <div class="dv_pnl_detalles">
                            <div class="container_dv_detalles">
                                <div style="width: 100%">
                                    <div id="lineaPunteada" class="Linea_Punteada" runat="server">
                                    </div>
                                    <div style="position: relative; z-index: 2;">
                                        <div class="dv_detalles" id="container_phase_Titu" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1Titu" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2Titu" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckTitu" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    Titular
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dv_detalles" id="container_phase_DatosFisc" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1DatosFisc" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2DatosFisc" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckDatosFiscales" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    <asp:Label ID="Lbl_Detalles01" runat="server" Text="Datos Fiscales"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dv_detalles" id="container_phase_TituDesi" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1TituDesi" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2TituDesi" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckTituDesi" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    <asp:Label ID="Lbl_Detalles02" runat="server" Text="Titular designado"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dv_detalles" id="container_phase_Cotizacion" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1Cotizacion" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2Cotizacion" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckCotizacion" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    <asp:Label ID="Lbl_Detalles03" runat="server" Text="Cotización"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dv_detalles" id="container_phase_Benefi" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1Benefi" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2Benefi" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckBenefi" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    <asp:Label ID="Lbl_Detalles04" runat="server" Text="Beneficiario"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="dv_detalles" id="container_phase_Confirmacion" runat="server">
                                            <div class="container_detalles">
                                                <div id="dv_phase_1Confirmacion" class="dv_detalles_1" runat="server">
                                                    <div id="dv_phase_2Confirmacion" class="dv_detalles_2" runat="server">
                                                        <asp:Button ID="Btn_CheckConfirmacion" runat="server" Text="✔" CssClass="check_Detalles" />
                                                    </div>
                                                </div>
                                                <div class="txt_detalles">
                                                    <asp:Label ID="Lbl_Detalles05" runat="server" Text="Documentos y confirmación"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="container_dv_InfoDetSolis">
                                <div>
                                    <div>
                                        <div style="display: flex; padding: 5% 15%; width: max-content">
                                            <b>Titular:&nbsp;</b>
                                            <asp:Label ID="Label1" runat="server" Text="" CssClass="lbl_detalles_soli"></asp:Label>
                                        </div>

                                        <div style="display: flex; padding: 5% 15%; width: max-content">
                                            <b>Titular designado:&nbsp;</b>
                                            <asp:Label ID="Label2" runat="server" Text="" CssClass="lbl_detalles_soli"></asp:Label>
                                        </div>

                                        <div style="display: flex; padding: 5% 15%; width: max-content">
                                            <b>Beneficiarios:&nbsp;</b>
                                            <asp:Label ID="Label3" runat="server" Text="" CssClass="lbl_detalles_soli"></asp:Label>
                                        </div>

<%--                                        <div style="display: flex; padding: 5% 15%; width: max-content">
                                            <b>Monto Total:&nbsp;</b>
                                            <asp:Label ID="Label4" runat="server" Text="$0" CssClass="lbl_detalles_soli"></asp:Label>&nbsp;MXN
                                        </div>--%>

                                    </div>
                                </div>
                                <div style="width: inherit; display: flex; position: absolute; bottom: 0;">
                                    <div runat="server" id="container_btn_Recompra" style="align-self: flex-end; height: fit-content; width: 100%; padding: 0% 10%;">
                                        <asp:Button ID="Btn_Recompra" CssClass="pager_btn" runat="server" Text="Recompra" OnClientClick="showLoadingSolicitud().then(() => Btn_ContiCaptura_Click());" OnClick="Btn_Recompra_Click" />
                                    </div>
                                    <div id="container_btn_ContiCaptura" style="align-self: flex-end; height: fit-content; width: 100%; padding: 0% 10%;" >
                                        <asp:Button ID="Btn_ContiCaptura" CssClass="pager_btn" runat="server" Text="Continuar captura" OnClientClick="showLoadingSolicitud().then(() => Btn_ContiCaptura_Click());" OnClick="Btn_ContiCaptura_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_InfoSolicitudes" runat="server">
                        <div id="dv_GridView_InfoSolicitudes" class="Container_GridView">
                            <asp:GridView ID="GridV_InfoSolicitudes" CssClass="GridView_Table" runat="server" AutoGenerateColumns="False" OnRowCommand="GridV_InfoSolicitudes_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="Nombre de la solicitud" HeaderText="Nombre de la solicitud" HtmlEncode="false" />
                                    <asp:BoundField DataField="Titular" HeaderText="Titular" HtmlEncode="false" />
                                    <asp:BoundField DataField="Beneficiarios" HeaderText="Beneficiarios" HtmlEncode="false" />
                                    <asp:BoundField DataField="Estatus" HeaderText="Estatus" HtmlEncode="false" />
                                    <asp:ButtonField ButtonType="Button" Text="Detalles" CommandName="Detalles_Solis" ControlStyle-CssClass="BtnGridView" ItemStyle-CssClass="CenteredButton" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_infoCuenta" runat="server">
                        <table class="formulario_table">
                            <tr>
                                <td>
                                    <p class="titleCampos">Primer nombre</p>
                                    <asp:TextBox ID="txtB_nombre" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="titleCampos">Segundo nombre</p>
                                    <asp:TextBox ID="txtB_SegunNombre" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="titleCampos">Apellido paterno</p>
                                    <asp:TextBox ID="txtB_apePater" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="titleCampos">Apellido materno</p>
                                    <asp:TextBox ID="txtB_apeMater" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="titleCampos">Fecha de nacimiento</p>
                                    <asp:TextBox ID="txtB_fechaNac" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="titleCampos">Correo electrónico</p>
                                    <asp:TextBox ID="txtB_correoElec" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="titleCampos">Teléfono móvil</p>
                                    <asp:TextBox ID="txtB_TelefonoMovil" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                                <td>
                                    <p class="titleCampos">Teléfono particular</p>
                                    <asp:TextBox ID="txtB_TelefonoParti" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="titleCampos">¿Dice ser exalumno?</p>
                                    <asp:TextBox ID="txtB_exUdem" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_solicitudes" runat="server">
                        <div id="container_btn_CrearSoliCompra">
                            <asp:Button ID="btn_CrearSoliCompra" CssClass="pager_btn" runat="server" Text="Crear solicitud" OnClientClick="showLoadingSolicitud().then(() => Btn_CrearSoliCompra_Click());" OnClick="Btn_CrearSoliCompra_Click" />
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_Familiares" runat="server">
                        <div id="dv_GridView_Familiares" class="Container_GridView">
                            <asp:GridView ID="GridV_Familiares" CssClass="GridView_Table" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" HtmlEncode="false" />
                                    <asp:BoundField DataField="Parentesco" HeaderText="Parentesco" HtmlEncode="false" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_Compras" runat="server">
                        <div class="Container_GridView">
                            <asp:GridView ID="GridV_Compras" CssClass="GridView_Table" runat="server"></asp:GridView>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
