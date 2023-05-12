<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasInter.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasInter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right">
                    <div class="txt_ConoceMas">
                        <h1>Bachillerato Internacional</h1>
                        <p>
                            Con un enfoque multicultural y de alta exigencia académica, te ofrecemos un programa que combina las ciencias y las humanidades, y te
								abre las puertas para ingresar a las mejores universidades del mundo.
                        </p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasInter" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasInter_Click" />
                        </div>
                    </div>
                </div>
                <div class="Left" style="background-image: url(Resources/2021_IB_bachillerato.jpg)"></div>
            </div>
        </div>
    </div>
</asp:Content>
