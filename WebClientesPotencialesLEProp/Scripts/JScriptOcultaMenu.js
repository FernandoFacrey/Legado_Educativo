window.onload = function () {
    // Obtener referencia al panel del menú por su ID en el lado del cliente
    var menuPanel = document.getElementById('Pnl_Header');

    // Función para ocultar el panel
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
            }
        }
    });
};