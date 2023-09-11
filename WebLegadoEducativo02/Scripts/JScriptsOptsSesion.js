var btnPerfil = document.getElementById('Btn_Perfil');
var panel = document.getElementById('dv_OptsSesion');

//document.addEventListener('click', function (event) {        
//    var currentPage = window.location.pathname;
//    if (currentPage == "/HomePerfil.aspx") {
//        var targetElement = event.target;
//        if (!panel.contains(targetElement) && targetElement !== btnPerfil) {
//            OcultarMenu();
//        }
//    }       
//});  

function OcultarMenu() {
    console.log("Funcion llamada desde CodeBehind para ocultar Menu");
    var panel = document.getElementById('dv_OptsSesion');
    var bloqu_panel = document.getElementById('bloque_Btn_Perfil');

    setTimeout(function () {
        console.log("Remuevo clase 1");
        panel.classList.remove("dv_OptsSesion");
        console.log("Agrego clase 2");
        panel.classList.add("dv_OptsSesion2");
    }, 50);
    setTimeout(function () {
        console.log("Remuevo clase 1 otra vez");
        panel.classList.remove("dv_OptsSesion");
    }, 50);
    setTimeout(function () {
        bloqu_panel.style.display = "none";
        console.log("Bloquea panel en none");
        panel.style.display = "none";
        console.log("Oculto panel");
    }, 400);
}

function MuestraMenu() {
    console.log("Funcion llamada desde CodeBehind para Mostrar Menu");
    var panel = document.getElementById('dv_OptsSesion');
    panel.style.display = "block";
    var bloqu_panel = document.getElementById('bloque_Btn_Perfil');
    bloqu_panel.style.display = "block";
    console.log("Bloquea panel en block");
}
