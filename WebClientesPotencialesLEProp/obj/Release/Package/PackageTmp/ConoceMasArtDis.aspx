<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasArtDis.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasArtDis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/51402728656_88e544dcc9_k.jpg)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Arte y Diseño</h1>
                        <p>Desarrolla tus habilidades creativas y artísticas para diseñar las mejores propuestas de comunicación visual.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasArtDis" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasArtDis_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
