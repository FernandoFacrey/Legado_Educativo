<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasBicult.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasBicult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/Sesion_Legado_Educativo_2022-171.jpg)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Bachillerato Bicultural</h1>
                        <p>Profundiza el conocimiento y vivencia de tu propia cultura e identidad con un enfoque en la mentalidad internacional.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasBachiBicult" runat="server" Text="Conoce más aqui" CssClass="BtnBlanco" OnClick="Btn_ConoceMasBachiBicult_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
