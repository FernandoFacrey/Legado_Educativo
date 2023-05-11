<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasArtDis.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasArtDis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/CRGS-COVER-1280x800.png)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Arte y Diseño</h1>
                        <p></p>
                        <div id="Container_BtnBlanco_ConoceMas">
                            <asp:Button ID="Btn_ConoceMasArtDis" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasArtDis_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
