<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebClientesPotenciales.aspx.cs" Inherits="WebClientesPotencialesLEProp.WebClientesPotenciales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container_Home">
        <div class="container_img_HomeFondo">
            <div style="position: absolute; top: 0; bottom: 0; left: 0; right: 0; background: linear-gradient(180deg, transparent 0%, rgba(0, 0, 0, 0.7) 100%);"></div>
            <img src="Resources/LegadoEducativo-hero-2022.jpg" class="img_HomeFondo">
        </div>
        <div class="container_txt_Home">
            <div>
                <div class="txt_Home">
                    <div>
                        <h1>Legado Educativo UDEM</h1>
                        <p>
                            En la Universidad de Monterrey sabemos que la mejor inversión que puedes realizar es la educación de tus hijos.
                        </p>
                    </div>
                </div>
                <div id="Container_BtnBlancoIniciarLE">
                    <asp:Button ID="Btn_IniciarLegadoHome" runat="server" Text="INICIAR LEGADO" CssClass="BtnBlanco" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
