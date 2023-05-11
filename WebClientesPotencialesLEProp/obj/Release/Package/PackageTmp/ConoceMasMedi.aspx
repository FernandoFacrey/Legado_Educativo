<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasMedi.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasMedi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/2018-ciencias-de-la-salud-talleres-y-laboratorios.jpg)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Medicina</h1>
                        <p>Ciencias de la Salud</p>
                        <div id="Container_BtnBlanco_ConoceMas">
                            <asp:Button ID="Btn_ConoceMasMedicina" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasMedicina_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
