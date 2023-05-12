<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ConoceMasMDOC.aspx.cs" Inherits="WebClientesPotencialesLEProp.ConoceMasMDOC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_ConoceMasLE">
        <div id="ConoceMasLE">
            <div id="Container_txt_ConoceMasLE">
                <div
                    class="Right"
                    style="background-image: url(Resources/2018-negocios-programas-maestria-en-desarrollo-organizacional-y-cambio-en-linea-hero_0.jpg)">
                </div>
                <div class="Left">
                    <div class="txt_ConoceMas">
                        <h1>Maestría en Desarrollo Organizacional y Cambio<br />
                            (en línea)</h1>
                        <p>Contribuye a mejorar el clima laboral, la cultura, los procesos humanos, administrativos y estructurales de las organizaciones.</p>
                        <div id="Container_BtnBlanco">
                            <asp:Button ID="Btn_ConoceMasMDOC" runat="server" Text="Conoce más aqui" class="BtnBlanco" OnClick="Btn_ConoceMasMDOC_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
