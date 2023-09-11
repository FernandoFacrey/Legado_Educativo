<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="HomePerfil.aspx.cs" Inherits="WebLegadoEducativo02.HomePerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
      <div>
        <asp:ImageButton ID="ImgBtn_MenuPerfil" runat="server" CssClass="btn_MenuPerfil" ImageAlign="Middle" ImageUrl="~/Resources/perfil.png" BackColor="#FFF700" OnClick="ImgBtn_MenuPerfil_Click" />
    </div>
    <div id="container_OptSesion">
        <asp:Panel ID="Pnl_OptSesion" CssClass="Pnl_OptSesion" runat="server">
            <div>
                <table>
                    <tr>
                        <td style="text-align: center;">
                            <asp:Button ID="BtnCerrarSesion" CssClass="btn_CerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="BtnCerrarSesion_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </div>
    <div class="container_encabezadoPerfil">
        <div id="encabezadoPerfil">
        </div>
        <div style="display: flex; position: relative">
            <table class="table_encabezadoPerfil">
                <tr>
                    <td>
                        <div class="container_txtEncabezadoPerfil">
                            <div class="txtEncabezadoPerfil">
                                <asp:Label ID="Lbl_mensaje" CssClass="Lbl_mensaje" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </td>
                    <td>
                        <div id="imgEncabezadoPerfil">
                            <img src="Resources/SoliLE.jpg" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>


    <div style="padding: 5% 10%;">
        <div id="containerMenuPerfil">
            <div id="containerOptions">
                <table id="tableOptions">
                    <tr>
                        <td style="border-bottom: 1px solid #403b33;">
                            <asp:Button ID="Btn_Perfil" CssClass="BtnsOptionsPerfil" runat="server" Text="Perfil" OnClick="Btn_Perfil_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom: 1px solid #403b33;">
                            <asp:Button ID="Btn_Solicitudes" CssClass="BtnsOptionsPerfil" runat="server" Text="Solicitudes" OnClick="Btn_Solicitudes_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom: 1px solid #403b33;">
                            <asp:Button ID="Btn_Certificados" CssClass="BtnsOptionsPerfil" runat="server" Text="Certificados" />
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom: 1px solid #403b33;">
                            <asp:Button ID="Btn_Compras" CssClass="BtnsOptionsPerfil" runat="server" Text="Compras" />
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom: 1px solid #403b33;">
                            <asp:Button ID="Btn_Beneficiarios" CssClass="BtnsOptionsPerfil" runat="server" Text="Beneficiarios" />
                        </td>
                    </tr>
                </table>
            </div>
            <div id="containerContent">
                <div id="containterContentOptions">
                    <asp:Panel ID="Pnl_infoCuenta" runat="server">
                        <table style="width: 100%; padding: 25px;">
                            <tr>
                                <td style="width: 50%;">
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Nombre
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_nombre" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                                <td style="width: 50%;">
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Segundo Nombre
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_SegunNombre" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Apellido paterno
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_apePater" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Apellido materno
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_apeMater" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Fecha de nacimiento
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_fechaNac" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Correo electrónico
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_correoElec" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Teléfono Móvil
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_TelefonoMovil" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>Teléfono Particular
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_TelefonoParti" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div style="font-family: 'Arial Rounded MT'; color: white;">
                                        <h3>¿Dice ser exalumno?
                                        </h3>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtB_exUdem" CssClass="form_campo" runat="server" Text="" Enabled="false" ForeColor="Black"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_solicitudes" runat="server">
                        <table style="width: 100%">
                            <tr>
                                <td colspan="2">
                                    <h3 style="font-family: 'Arial Rounded MT'; color: white;">Su solicitudes de compra.
                                    </h3>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 50%"></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btn_CrearSoliCompra" CssClass="BtnsOptions" runat="server" Text="Crear solicitud" OnClick="Btn_CrearSoliCompra_Click" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
