using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
         
        static void Main(string[] args)
        {
            

            int number = FirstExplanation(); //11
            Console.WriteLine(number);

            string str = "Hello world";

            StringBuilder strB = new StringBuilder();

            for(int i = 0; i < 1000000; i++)
            {
                strB.AppendLine(str);
            }

            strB.ToString();


            StackAndHeapPassMethod(number);
            Console.ReadKey();
        }

        private static void StackAndHeapPassMethod(int number)
        {
            int[] stackAndHeapExplanation = new int[] { 1, 2, 3 };

            ModifyNumber(stackAndHeapExplanation[0]);
            ModifyNumber(number);

            Console.WriteLine(stackAndHeapExplanation[0]);
            Console.WriteLine(number);
        }

        private static void ModifyNumber(int[] numbers)
        {
            numbers[0] = 5;
        }

        private static void ModifyNumber(int distintaANumber)
        {
            distintaANumber = 5;
        }

        private static int FirstExplanation()
        {
            var number = 0;
            number += 1; // number = number + 1;
            var condition = number == 1; //Returns a true because is a condition operator (==)


            //Instruccion (Para) (For)
            for (int i = 0; i <= 10; i++)
            {
                number += 1;
            }

            if (number == 1)
            {
                Console.WriteLine("Is 1");
            }
            else if (number == 10)
            {
                Console.WriteLine("Is 10");
            }
            else
            {
                Console.WriteLine("Is another number");
            }

            return number;
        }

        private int RecursiveFor(int number, int condition, int i)
        {
            if(i <= condition)
            {
                number += 1;
               return  RecursiveFor(number, condition, i + 1);
            }
            return number;
        }


        private void CheckValue(int value)
        {
                    
            if(value == 1)
            {

            }
            


        }
        

    

    }
}
