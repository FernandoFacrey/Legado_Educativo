<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MasInfoMDO.aspx.cs" Inherits="WebClientesPotencialesLEProp.MasInfoMDO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/51389823635_f8a30160f3_k.jpg)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Maestría en Desarrollo Organizacional</h1>
                        <p>Analiza y diagnostica los diferentes procesos humanos y organizacionales para proponer e implementar mejoras en estos.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasMDO" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasMDO_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
