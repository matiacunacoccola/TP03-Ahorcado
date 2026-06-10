public class PalabrasAhorcado
{
   private List<string> palabras;

   public PalabrasAhorcado()
   {
     this.palabras = new List<string>
     {"CUADERNO","MONTAÑAS","PANTALLA","TECLADOS","COMPAÑERO","COCINERO","ELEFANTE","HOSPITAL","JUGUETES","ZAPATERO"};

   }

   public string obtenerPalabra()
   {
      Random random = new Random(); 
      int numero=random.Next(palabras.Count);
      return palabras[numero];

   }

}
