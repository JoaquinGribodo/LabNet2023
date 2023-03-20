
const botonProbar = document.getElementById("probar");
const ayuda = document.getElementById("ayuda");
const botonReiniciar = document.getElementById("reiniciar");
const resultadoPerder = document.getElementById("resultadoPerder");
const resultadoGanar = document.getElementById("resultadoGanar");
const botonMusica = document.getElementById("musica");

let maximoPuntaje = document.getElementById("maximoPuntaje");
let puntaje = document.getElementById("puntaje");
let Aleatorio = document.getElementById("Aleatorio");
let numeroAleatorio = Math.floor(Math.random() * 20);

resultadoPerder.style.display = "none";
resultadoGanar.style.display = "none";
puntaje.value = 20;
maximoPuntaje.value = localStorage.getItem("maximoPuntaje");
Aleatorio.value = '?';

botonProbar.addEventListener("click", function(){
    
    resultadoPerder.style.display = "none";
    let ingresarNumero = document.getElementById("ingresoNumero").value;
    ingresarNumero > numeroAleatorio ? ayuda.value = "¡Más bajo!" : ayuda.value = "¡Más alto!"
    
    if(ingresarNumero == numeroAleatorio) 
    {
        maximoPuntaje.value = puntaje.value;
        ayuda.value = "¡Número correcto!";

        resultadoGanar.style.display = "block";
        localStorage.setItem("maximoPuntaje", maximoPuntaje.value);
        Aleatorio.value = numeroAleatorio;
    }
    else
    {
        puntaje.value = puntaje.value - 1;
    }

    if(puntaje.value == 0)
    {
        ayuda.value = "Se terminaron los intentos. Perdiste."
        resultadoPerder.style.display = "block"
        document.body.style.backgroundColor = "#EC1B11";
        resultadoGanar.style.display = "none"; 
        puntaje.value = 20;
    }
});

botonReiniciar.addEventListener("click", function(){
    ayuda.value = "";
    Aleatorio.value = "?";
    numeroAleatorio = Math.floor(Math.random() * 10);
    resultadoPerder.style.display = "none";
    resultadoGanar.style.display = "none";  
    puntaje.value = 20;
})

botonMusica.addEventListener("click", function(){
    let escucharMusica = document.createElement("audio");
    escucharMusica.setAttribute("src", "musica.mp3");
    escucharMusica.volume = 0.2;
    escucharMusica.play();
    botonMusica.disabled = true;
})