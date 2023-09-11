//---------IniciaCreaCuenta----------\\
function showLoadingIniciaSesion() {
    document.getElementById('AnimacionIniciarSesion').style.display = "block";
    document.getElementById('dv_BtnIniciarSesion').style.display = "none";
}


//---------PreCotiza----------\\
function showLoadingPreCotiPantallaEnviaCorreo() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_BtnEnviarCorreo').style.display = "none";
}
function showLoadingPreCotiPantallaEnviaForm() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_BtnEnviarForm').style.display = "none";
}
function showLoadingRedireccionaCoti() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('btns_InfoExtra').style.display = "none";
}


//---------HomePerfil----------\\
function showLoadingHomePerfil() {
    document.getElementById('animacionOptions').style.display = "block";
    document.getElementById('panel_Options').style.display = "none";
}
function showLoadingSolicitud() {
    document.getElementById('AnimacionCargandoSolicitud').style.display = "block";
    document.getElementById('container_btn_CrearSoliCompra').style.display = "none";
}


//---------Extras----------\\

//function showLoadingPantalla() {
//    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
//}

//function hideLoading() {
//    document.getElementById('AnimacionIniciarSesion').style.display = "none";
//} 