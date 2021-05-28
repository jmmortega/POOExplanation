
using System;
using System.Globalization;

namespace POOExplanation
{
    class Program
    {
        static void Main(string[] args)
        {           
            /*
            //Another use of static is create properties. It's like a constant but mutable :D
            Console.WriteLine(Settings.Path);
            var s = new Settings();
            Settings.Path = "D:\\MyApp\\Settings";
            */

            /*
            var harryPotterYLaPiedraFilosofal = new Libro("Harry potter y la piedra filosofal", 100)
            {
                Encuadernacion = "Cartoné"
            };
            

            harryPotterYLaPiedraFilosofal.Pages = 100;
            
            var libroDeCocinaDeKarlosArguiniano = new Libro("Cocina con K.A", 30);

            var libroWithoutPages = new Libro();

            harryPotterYLaPiedraFilosofal.LeerCapitulo(1);
            

            Libro cuatroTresDosUno = null;
            */

            var poesiasBecquer = new PoetryBook();
            poesiasBecquer.Pages = 100;
            poesiasBecquer.ISBN = "12345";

            var poesiasBecquer2 = new PoetryBook();
            poesiasBecquer2.Pages = 100;
            poesiasBecquer2.ISBN = "12345";

            var poesiasBecquer3 = poesiasBecquer;

            //Works like string
            //var result = poesiasBecquer.ISBN + poesiasBecquer2.ISBN;
            string str1 = "Hola";
            string str2 = "Hola";
                     
            if(poesiasBecquer.Equals(poesiasBecquer2))
            {
                Console.WriteLine("It's the same!");
            }

            if(poesiasBecquer == poesiasBecquer3)
            {
                Console.WriteLine("It's the same!");
            }

            poesiasBecquer.Encuadernacion = "Cartoné";

            Console.WriteLine(poesiasBecquer3.Encuadernacion);

            var essayBook1 = new EssayBook();


            poesiasBecquer.LeerCapitulo(1);
            essayBook1.LeerCapitulo(1);

            poesiasBecquer.PlayChapter(0);

            PlayBook(poesiasBecquer3);
            PlayBook(essayBook1);



            ShowPages(essayBook1);
            Console.ReadKey();
  
        }

        public static void PlayBook(IAudioBook audioBook)
        {

        }



        public static string ShowPages(Libro book)
        {
            /*
             * Not allow null
            int p = null;
                Allow null value
            int? pNullable = null;

                Check null value 
            var pages = book?.Pages;
            */

            if(book.GetType() == typeof(EssayBook))
            {
                var essay = (EssayBook)book;
            }
            

            if(book != null)
            {
                Console.WriteLine(book.Pages);
            }

            return book.Pages.ToString();           
        }
    }
}
