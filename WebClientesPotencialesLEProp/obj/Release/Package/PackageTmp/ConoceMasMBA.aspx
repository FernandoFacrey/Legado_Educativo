<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasMBA.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasMBA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right">
                    <div class="txt_ConoceMas">
                        <h1>Maestria en Administración</h1>
                        <p>
                            Desarrolla competencias y habilidades para la dirección y administración de empresas con una perspectiva global, competitiva y
								transformadora.
                        </p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasMBA" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasMBA_Click" />
                        </div>
                    </div>
                </div>
                <div class="Left" style="background-image: url(Resources/51388874611_74a0764b6c_k.jpg)"></div>
            </div>
        </div>
    </div>
</asp:Content>
