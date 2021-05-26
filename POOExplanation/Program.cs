using System;

namespace POOExplanation
{
    class Program
    {
        static void Main(string[] args)
        {
            var harryPotterYLaPiedraFilosofal = new Libro("Harry potter y la piedra filosofal", 100)
            {
                Encuadernacion = "Cartoné"
            };

            harryPotterYLaPiedraFilosofal.Pages = 100;
            
            var libroDeCocinaDeKarlosArguiniano = new Libro("Cocina con K.A", 30);

            var libroWithoutPages = new Libro();


            Libro.Empty();
            harryPotterYLaPiedraFilosofal.LeerCapitulo(1);
           
        }
    }
}
