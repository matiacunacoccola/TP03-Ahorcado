let palabra;
let palabraOculta="";
const intentos=10;
const letra=document.getElementById("letra").value.ToUpperCase();


function arriesgarLetra()
{

    list<String> letras;
    if (letra!=1)
    {
       console.log("Error. Ingrese una sola letra.");

    }


    for(const i=0; i<palabras.Count; i++)
    {
       if(palabra[i] == letra)
        {
            palabraOculta[i] = letra;
            encontrada = true;
        }

    }

}