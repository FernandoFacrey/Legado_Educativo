<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasArquiHabi.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasArquiHabi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right">
                    <div class="txt_ConoceMas">
                        <h1>Arquitectura y Ciencias del Hábitat</h1>
                        <p></p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasArquiHabi" runat="server" Text="Conoce más aqui"  class="BtnBlanco" OnClick="Btn_ConoceMasArquiHabi_Click"/>
                        </div>
                    </div>
                </div>
                <div class="Left" style="background-image: url(Resources/CRGS-COVER-1280x800.png)"></div>
            </div>
        </div>
    </div>
</asp:Content>
