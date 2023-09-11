window.onload = function () {
    var menuPanel = document.getElementById('Pnl_Header');
    function hideMenuPanel() {
        menuPanel.style.display = "none";
    }

    // Evento clic en el documento para ocultar el panel cuando se hace clic fuera de él
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

};