<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasOtrosPos.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasOtrosPos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div class="Right" style="background-image: url(Resources/51388889251_041cf135fc_k.jpg); background-position: right"></div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Admisiones y becas de Posgrado</h1>
                        <p>Conoce el proceso de admisión para ingresar a la Universidad de Monterrey.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasPosgrado" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasPosgrado_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
