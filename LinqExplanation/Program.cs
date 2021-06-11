using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExplanation
{
    //https://linqsamples.com/linq-to-objects
    class Program
    {
        static void Main(string[] args)
        {
            var people = GetPeople();
            

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void LazyPrinciple(List<Persona> people)
        {
            var mayores18Mujeres = people.Where(p => p.Age >= 18 && p.Sex == 'M');
            //var mayores18Mujeres = people.Where(SearchMayores18YMujeres).ToList();

            people.Add(new Adulto() { Name = "Catalina", Age = 20, Sex = 'M' });
            people.Add(new Adulto() { Name = "Ana", Age = 14, Sex = 'M' });

            foreach (var elem in mayores18Mujeres)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("-----------------");
            people.Add(new Adulto() { Name = "Irene", Age = 57, Sex = 'M' });

            foreach (var elem in mayores18Mujeres)
            {
                Console.WriteLine(elem);
            }
        }

        private static void FirstExplanationHOF(List<Persona> people)
        {
            Console.WriteLine(new Adulto());
            //                               f                          (x)
            var mayores18Hombres = people.Where(p => p.Age >= 18 && p.Sex.Equals('H')).ToList();
            var mayores18Mujeres = people.Where(p => p.Age >= 18 && p.Sex.Equals('M')).ToList();

            var mayores18 = people.Where(p => p.Age >= 18);
            var mayores18H = mayores18.Where(p => p.Sex == 'H');
            var mayores18M = mayores18.Where(p => p.Sex == 'M');

            var m = people.Where(p => p.Age >= 18)
                .Where(p => p.Sex == 'M');


            /*
            mayores18.ForEach(
                persona //Parametro (1)
                =>
                {                    
                    Console.WriteLine(persona.Name);//(2)
                    Console.WriteLine(persona.Age);
                });
            */
        }

        private static void ShowPerson(Persona obj) //(1)
        {
            Console.WriteLine(obj.Name); //(2)
        }



        //Func<Persona,bool>
        private static bool SearchMayores18YMujeres(Persona arg)
        {
            if (arg.Age >= 18 && arg.Sex == 'M')
            {
                return true;
            }
            return false;
        }

        private static List<Persona> GetPeople()
        {
            //Where -- filter
            //Select -- map
            //SelectMany -- flatmap

            var people = new List<Persona>();
            people.Add(new Adulto() { Name = "Paco", Age = 35, Sex = 'H' });
            people.Add(new Adulto() { Name = "Esteban", Age = 28, Sex = 'H'});
            people.Add(new Adulto() { Name = "Esther", Age = 28, Sex = 'M' });
            people.Add(new Niño() { Name = "Paquito", Age = 5, Sex = 'H'});
            people.Add(new Niño() { Name = "Maria", Age = 10, Sex = 'M' });

            return people;
        }

        private static void FirstAproachForASearch(List<Persona> people)
        {
            var mayores18 = new List<Persona>();
            var menores18 = new List<Persona>();
            foreach (var element in people)
            {
                /*
                if (element.GetType() == typeof(Niño))
                {

                }
                else
                {

                }*/

                if (element.Age >= 18)
                {
                    mayores18.Add(element);
                }
                else
                {
                    menores18.Add(element);
                }
            }
        }

        

        private static void UseAExtensionMethods()
        {
            string url = "www.google.com?q=hello world";
            url.EncodingUrl();
        }


        public static void ExplanationCollection()
        {
            ArrayList list = new ArrayList();

            list.Add("Hello");
            list.Add(1);
            list.Add(2);
            list.Add(new Adulto());

            for (int i = 0; i < list.Count; i++)
            {
                string s = (string)list[i];
            }

            List<Persona> people = new List<Persona>();
            people.Add(new Adulto());
            people.Add(new Niño());            
        }
    }

    

    public abstract class Persona
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public char Sex { get; set; }

        public override string ToString()
            => $"{Name} {Sex}";
    }

    public class Adulto : Persona
    {
        public double Salary { get; set; }        
    }

    public class Niño : Persona
    {
        public int NivelFornite { get; set; }
    }
    
}
