using System;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Persona("30000000Z");

            if(p.EsMayorDeEdadProperty)
            {
                Console.WriteLine(p.Show());
            }
                   
            try
            {
                if (p.EsMayorDeEdadMethod())
                {                    
                    Console.WriteLine(p.Show());
                }                            
            }
            catch (NotMayorityAgeException e)
            {
                
                Console.WriteLine(e.Message);
            }            
            finally
            {
                p.Check = true;
            }
            

            /*
             * Allow a try-catch situation that free memory to the end.
             * However I can't "catch" the exception
            using (var per = new Persona("000000Z"))
            {

            }
            */
                
            Console.WriteLine(p.Check);
            Console.ReadKey();
        }
    }
}
