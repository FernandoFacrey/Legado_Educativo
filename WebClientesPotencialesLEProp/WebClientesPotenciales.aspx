<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="WebClientesPotenciales.aspx.cs" Inherits="WebClientesPotencialesLEProp.WebClientesPotenciales" MaintainScrollPositionOnPostback="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Home_Styles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


    <div id="slider-container">
        <img decoding="async" src="Resources/Sesion Legado Educativo 2022-239 (3).jpg" />
        <img decoding="async" src="Resources/QueEsLegado.jpg" />
        <img decoding="async" src="Resources/BeneficiosLegadoEducativo.jpg" />
        <div
            style="position: absolute; top: 0; bottom: 0; left: 0; right: 0; background: linear-gradient(180deg, transparent 0%, rgba(0, 0, 0, 0.7) 100%);">
        </div>
        <button id="Btn_Prev">&#8249;</button>
        <button id="Btn_Next">&#8250;</button>
        <div>
            <div class="container_btn_Txt">
                <div>
                    <label id="txt_Home" class="txt_Home">Legado Educativo UDEM</label><br />
                    <label id="sub_txt_Home" class="sub_txt_Home">
                        En la Universidad de Monterrey, sabemos que la mejor inversión que puedes hacer es la educación de tu familia.</label><br />
                    <div style="display: flex; align-content: center; justify-content: center;">
                            <asp:Button ID="btn_IniciarLegado" runat="server" Text="Iniciar Legado" OnClick="Btn_IniciarLegado_Click" class="Btn_Inicial"/>
                            <asp:Button ID="btn_QueEs" runat="server" Text="Conoce" OnClick="Btn_QueEsLEHome_Click" class="Btn_Inicial" />
                            <asp:Button ID="btn_Beneficios" runat="server" Text="Beneficios" OnClick="Btn_BeneficiosHome_Click" class="Btn_Inicial" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="Scripts/JScriptHome.js"></script>
</asp:Content>
