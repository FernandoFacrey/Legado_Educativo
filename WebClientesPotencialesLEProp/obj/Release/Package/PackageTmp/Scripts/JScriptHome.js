console.log("Inicio Script");
var currentImage = 0;
var images = document.querySelectorAll("#slider-container img");
var prevButton = document.querySelector("#Btn_Prev");
var nextButton = document.querySelector("#Btn_Next");
var LabelTxt = document.getElementById("txt_Home");
var LabelSubTxt = document.getElementById("sub_txt_Home");

var btn_IniciarLegado = document.getElementById("main_btn_IniciarLegado");
var btn_QueEs = document.getElementById("main_btn_QueEs");
var btn_Beneficios = document.getElementById("main_btn_Beneficios");

var intervalId;

function showImage(index) {
    images[currentImage].classList.remove("active");
    images[index].classList.add("active");
    currentImage = index;

    switch (currentImage) {
        case 0:
            changeLabelBtnWithAnimation(
                "Legado Educativo UDEM",
                "En la Universidad de Monterrey, sabemos que la mejor inversión que puedes hacer es la educación de tu familia.");
            OcultarMostarBotones("btn_IniciarLegado");
            break;

        case 1:
            changeLabelBtnWithAnimation("Qué es Legado Educativo", "");
            OcultarMostarBotones("btn_QueEs");
            break;

        case 2:
            changeLabelBtnWithAnimation("Beneficios", "Los certificados de educación tienen un gran número de beneficios");
            OcultarMostarBotones("btn_Beneficios");
            break;
    }
}

function OcultarMostarBotones(Boton) {
    setTimeout(function () {
        btn_IniciarLegado.classList.add("fade_out");
        btn_QueEs.classList.add("fade_out");
        btn_Beneficios.classList.add("fade_out");
        btn_IniciarLegado.style.display = "none";
        btn_QueEs.style.display = "none";
        btn_Beneficios.style.display = "none";
    }, 50);

    switch (Boton) {
        case "btn_IniciarLegado":
            btn_IniciarLegado.classList.add("fade_out");
            setTimeout(function () {
                btn_IniciarLegado.classList.remove("fade_out");
                btn_IniciarLegado.classList.add("fade_in");
            }, 300);

            setTimeout(function () {
                btn_IniciarLegado.classList.remove("fade_in");
                btn_IniciarLegado.style.display = "block";
            }, 50);
            break;

        case "btn_QueEs":
            btn_QueEs.classList.add("fade_out");
            setTimeout(function () {
                btn_QueEs.classList.remove("fade_out");
                btn_QueEs.classList.add("fade_in");
            }, 300);

            setTimeout(function () {
                btn_QueEs.classList.remove("fade_in");
                btn_QueEs.style.display = "block";
            }, 50);
            break;

        case "btn_Beneficios":
            btn_Beneficios.classList.add("fade_out");
            setTimeout(function () {
                btn_Beneficios.classList.remove("fade_out");
                btn_Beneficios.classList.add("fade_in");
            }, 300);

            setTimeout(function () {
                btn_Beneficios.classList.remove("fade_in");
                btn_Beneficios.style.display = "block";
            }, 50);
            break;
    }
}

function nextImage() {
    console.log("Cambio imagen");
    var index = currentImage + 1;
    if (index >= images.length) {
        index = 0;
    }
    showImage(index);
}

// Función para cambiar el texto de los labels con animación
function changeLabelBtnWithAnimation(newText, newSubText) {
    LabelTxt.classList.add("fade_out");
    LabelSubTxt.classList.add("fade_out");

    setTimeout(function () {
        LabelTxt.textContent = newText;
        LabelSubTxt.textContent = newSubText;

        LabelTxt.classList.remove("fade_out");
        LabelSubTxt.classList.remove("fade_out");

        LabelTxt.classList.add("fade_in");
        LabelSubTxt.classList.add("fade_in");
    }, 300);

    setTimeout(function () {
        LabelTxt.classList.remove("fade_in");
        LabelSubTxt.classList.remove("fade_in");
    }, 50);
}

intervalId = setInterval(nextImage, 7000);


prevButton.addEventListener("click", function () {
    event.preventDefault();
    console.log("Boton previo");
    var index = currentImage - 1;
    if (index < 0) {
        index = images.length - 1;
    }
    showImage(index);
});

nextButton.addEventListener("click", function () {
    event.preventDefault();
    console.log("Boton siguiente");
    clearInterval(intervalId);
    nextImage();
});              