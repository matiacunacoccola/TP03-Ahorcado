public class PalabrasAhorcado
{
   private List<string> palabras;

   public PalabrasAhorcado(List<string> palabras)
   {
     this.palabras = new List<string>
     {"COMPUTADORA","PROGRAMACION","INFORMATICA","LABORATORIO","COMPAÑERO","ARQUITECTURA","SEGMENTACION","PAGINACION","PROCESADOR","TELEVISION"};

   }

   public string obtenerPalabra()
   {
      Random random = new Random();
      int numero = 0;
       
      numero=random.next(palabras.Count);
    

-
      return palabras(numero);

   }


}