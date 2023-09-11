//---------SolicitudCompra----------\\

var menuPanel = document.getElementById('Pnl_Header');
document.addEventListener("click", function (event) {
    var targetElement = event.target; // Elemento en el que se hizo clic

    // Verificar si el clic fue fuera del panel del menú
    if (menuPanel != null) {
        if (targetElement !== menuPanel && !menuPanel.contains(targetElement)) {
            var element = document.getElementById('dv_Btn_MenuCertificados');
            var element2 = document.getElementById('dv_Btn_MenuConoce');

            element.classList.remove('dv_btn_Menu_selected');
            element.classList.add('dv_btn_Menu');
            element2.classList.remove('dv_btn_Menu_selected');
            element2.classList.add('dv_btn_Menu');
            hideMenuPanel();

            var currentPage = window.location.pathname;
            if (currentPage === "/WebLE02InicioCreaCuenta.aspx") {
                var element3 = document.getElementById('dv_Btn_MenuIniciarLE');
                element3.classList.remove('dv_btn_Menu');
                element3.classList.add('dv_btn_Menu_selected');
            }

            else if (currentPage === "/PreCotizar.aspx") {
                var element3 = document.getElementById('dv_Btn_MenuCotizar');
                element3.classList.remove('dv_btn_Menu');
                element3.classList.add('dv_btn_Menu_selected');
            }

            else if (currentPage === "/Contactanos.aspx") {
                var element3 = document.getElementById('dv_Btn_MenuContactanos');
                element3.classList.remove('dv_btn_Menu');
                element3.classList.add('dv_btn_Menu_selected');
            }
        }
    }
});

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
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_Btn_EnviaTituDesi').style.display = "none";
}

function showLoadingSoliPantallaEnviaBenefi() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_Btn_EnviaBeneficiario').style.display = "none";
}

function showLoadingEnviaSolicitud() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_Btn_EnviarSoliCompra').style.display = "none";
}

function showLoadingPreCotiPantallaEnviaForm() {
    document.getElementById('AnimacionCargandoPantalla').style.display = "block";
    document.getElementById('dv_BtnEnviarForm').style.display = "none";
}

function showLoadingInstitucionProdecedencia() {
    document.getElementById('dv_cargandoNivelProcedencia').style.display = "block";
    document.getElementById('dv_cargandoNombreProcedencia').style.display = "block";
    document.getElementById('dv_cargandoEstadoProcedencia').style.display = "block";
}


function showAlert() {
    var dv_alerta = document.getElementById('alertaPersonalizada');

    setTimeout(function () {
        console.log("Muestro alerta")
        dv_alerta.style.display = "block";
    }, 500);
    setTimeout(function () {
        if (dv_alerta.style.display == "block") {
            console.log("Oculto alerta despues de 7s")
            dv_alerta.style.display = "none";
        }
    }, 7000);
}

function showErrorAlert() {
    var dv_alerta = document.getElementById('alertaPersonalizada');

    setTimeout(function () {
        console.log("Muestro alerta de error")
        dv_alerta.classList.replace("AlertaCorrecto", "AlertaIncorrecto");
        dv_alerta.style.display = "block";


    }, 2000);
    setTimeout(function () {
        if (dv_alerta.style.display == "block") {
            console.log("Oculto alerta despues de 7s")
            dv_alerta.style.display = "none";
            dv_alerta.classList.replace("AlertaIncorrecto", "AlertaCorrecto");
        }
    }, 7000);
}

function cambiarColor() {
    setTimeout(function () {
        var control = document.getElementById('fileUpload');
        control.style.color = "black";
        alert("Cambie color");
    }, 3000);
}
