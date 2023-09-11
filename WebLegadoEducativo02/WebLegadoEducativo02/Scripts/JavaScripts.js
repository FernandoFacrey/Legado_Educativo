


//---------IniciaCreaCuenta----------\\
function showLoadingIniciaSesion() {
    document.getElementById('AnimacionIniciarSesion').style.display = "block";
    document.getElementById('bloqueaBtnInicioSesion').style.display = "block";
    document.getElementById('dv_BtnIniciarSesion').style.display = "none";
}


//---------PreCotiza----------\\
function showLoadingPreCotiPantallaEnviaCorreo() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_BtnEnviarCorreo').style.display = "none";
}

//---------SolicitudCompra----------\\
function showLoadingSoliPantallaEnviaTitular() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_btn_VerificaTitular').style.display = "none";
    document.getElementById('dv_btn_VerificaTitularFalse').style.display = "none";
}

function showLoadingSoliPantallaEnviaInfoFisc() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_btn_VerificaInfoFiscTrue').style.display = "none";
    document.getElementById('dv_btn_VerificaInfoFiscFalse').style.display = "none";
}

function showLoadingSoliPantallaEnviaTituDesi() {
    document.getElementById('dv_Btn_EnviaTituDesi').style.display = "none";
}

function showLoadingSoliPantallaEnviaBenefi() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_Btn_EnviaBeneficiario').style.display = "none";
}


function showLoadingPreCotiPantallaEnviaForm() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_BtnEnviarForm').style.display = "none";
}






//---------Extras----------\\

//function showLoadingPantalla() {
//    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
//}

//function hideLoading() {
//    document.getElementById('AnimacionIniciarSesion').style.display = "none";
//} 