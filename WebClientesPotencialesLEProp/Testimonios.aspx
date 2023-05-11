<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Testimonios.aspx.cs" Inherits="WebClientesPotencialesLEProp.Testimonios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div id="Container_testimoniosLE">
        <div id="testimoniosLE">
            <div class="title_Testimonios">
                <h1>Testimonios Legado Educativo</h1>
            </div>
            <div id="container_VideoTesti">
                <div class="video">
                    <video autoplay src="Resources/Vídeo_LE_Testimonio_abuelo.mp4" controls></video>
                </div>
                <div class="text">
                    <div id="card_Testimonios">
                        <div class="Esquina"></div>
                        <div class="Comilla">
                            <h1>“</h1>
                        </div>
                        <h1>"Legado Educativo es la clave para brindarle una educación de excelencia a nuestros hijos, con un plan de
                inversión que lo hace realidad."
                        </h1>
                    </div>
                </div>
            </div>
            <div id="container_ImagenesTesti">
                <div class="img">
                    <img src="Resources/Copia de Testimonios_1-01.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_2-02.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_3-03.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_4-07.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_5-08.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_6-10.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_7-12.jpg" />
                </div>
                <div class="img">
                    <img src="Resources/Copia de Testimonios_8-13.jpg" />
                </div>
            </div>
            <div id="container_VideoTesti02">
                <video src="Resources/Copia de Testimonio Luis Meneses.mp4" controls></video>
            </div>
        </div>
    </div>
</asp:Content>
