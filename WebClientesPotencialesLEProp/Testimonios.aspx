<%@ Page Title="Testimonios" MaintainScrollPositionOnPostback="True" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Testimonios.aspx.cs" Inherits="WebClientesPotencialesLEProp.Testimonios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Testimonios_Styles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

    <div id="Container_testimoniosLE">
        <div id="testimoniosLE">
            <div class="title_Testimonios">
                <h1>Testimonios Legado Educativo</h1>
            </div>

            <div id="Container_Slider_Testimonios">
                <div id="Slider_Testimonios">
                    <div class="Container_Btn_Testimonios">
                        <asp:Button ID="Btn_AnteriorTesti" runat="server" Text="<" CssClass="Btn_Testimonios" OnClick="Btn_AnteriorTesti_Click" />
                    </div>
                    <div id="Container_card_Testimonios">
                        <div id="card_Testimonios">
                            <div class="Comilla">
                                <h1>“</h1>
                            </div>
                            <div class="container_Txt_Testimonios">
                                <asp:Label ID="Lbl_Testimonio" runat="server" Text="" CssClass="Txt_Testimonios"></asp:Label>
                                <div class="container_cliente">
                                    <asp:Label ID="Lbl_Cliente" runat="server" Text="Label" CssClass="cliente_Testimonios"></asp:Label>
                                </div>
                            </div>
                            <div class="Esquina"></div>
                        </div>
                    </div>
                    <div class="Container_Btn_Testimonios">
                        <asp:Button ID="Btn_SiguienteTesti" runat="server" Text=">" CssClass="Btn_Testimonios" OnClick="Btn_SiguienteTesti_Click" />
                    </div>
                </div>
            </div>

            <div id="container_VideoTesti">
                <div class="video">
                    <video src="Resources/Vídeo_LE_Testimonio_abuelo.mp4" controls></video>
                </div>
            </div>
            <div id="container_VideoTesti02">
                <video src="Resources/Copia de Testimonio Luis Meneses.mp4" controls></video>
            </div>
        </div>
    </div>

</asp:Content>
