<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UnexpectedError.aspx.cs" Inherits="WebLegadoEducativo02.UnexpectedError" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/UnexpectedErrorStyles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="container">
        <div class="Container_Error">
            <div class="txt_Error">
                <div class="UDEM">
                    <span class="adim01">¡</span>
                    <span>O</span>
                    <span>O</span>
                    <span>P</span>
                    <span>S</span>
                    <span>.</span>
                    <span>.</span>
                    <span class="adim02">!</span>
                </div>
                <h1>Algo no salio bien</h1>
                <h1>Regresa al inicio y vuelve a intentarlo</h1>
                <div style="padding:0% 35%">
                    <asp:Button ID="Btn_RedireccionaHome" runat="server" Text="Inicio" CssClass="pager_btn" OnClick="Btn_RedireccionaHome_Click" />
                </div>
            </div>
        </div>
        <div class="Container_Exception">
            <div class="txt_Exception">
                <asp:Label ID="Lbl_Exception" runat="server" Text="" CssClass="requeridos"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
