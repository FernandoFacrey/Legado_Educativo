<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="VisionUDEM.aspx.cs" Inherits="WebClientesPotencialesLEProp.VisionUDEM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
		<div id="Container_VisionUDEMLE">
			<div id="VisionUDEMLE">
				<div id="Container_txt_y_Btn_Vision">
					<div class="txt_y_Btn">
						<h2 class="degradado">Visión</h2>
						<p class="txt_VisionUdem">
							En la UDEM, creemos que la visión debe ser un sueño compartido que motive a ser sus embajadores y nos anime a realizarlo como comunidad.
						</p>
						<div>
							<asp:button id="Btn_VisionUDEM" runat="server" Text="Conoce nuestra visión" class="btn_Degradado" OnClick="Btn_VisionUDEM_Click"/>
						</div>
					</div>
				</div>
				<div id="container_ImgVision">
					<div class="container_Visioncirculo1">
						<img src="Resources/Visioncirculo1.png" />
					</div>
					<div class="container_Vision2ciruclo_0">
						<img src="Resources/Vision2ciruclo_0.jpg" class="Vision2ciruclo_0" />
					</div>
					<div class="container_Naranja4">
						<img src="Resources/Naranja4.png" class="Naranja4" />
					</div>
				</div>
			</div>
		</div>
</asp:Content>
