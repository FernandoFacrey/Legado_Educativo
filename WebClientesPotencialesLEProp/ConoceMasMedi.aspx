<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasMedi.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasMedi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/31714822306_6150d065c7_o.jpg)"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Médico Cirujano y Partero</h1>
                        <p>Te ofrecemos experiencias nacionales e internacionales en el más amplio campo clínico.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasMedicina" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasMedicina_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
