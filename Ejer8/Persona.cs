using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer8
{

    public class Persona
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        private string _dni;
        public string DNI
        {
            get => _dni;
            set => _dni = value;
        }

        private bool _check;
        public bool Check            
        {
            get => _check;
            set => _check = value;
        }


        public Persona(string dni)
        {
            _dni = dni;
        }

        public string Show()
        {
            //Soy NOMBRE con edad EDAD y mi dni es: DNI
            var ret = string.Format("Soy {0} con edad {1} y mi dni es: {2}", Name, Age, DNI);
            return $"Soy {Name} con edad {Age} y mi dni es {DNI}"; 
        }

        public void ShowFromConsole()
        {
            Console.WriteLine("Soy " + Name + " con edad " + Age + " y mi dni es " + DNI);            
        }

        public bool EsMayorDeEdadProperty
        {
            get
            {            
                if(Age == 0)
                {
                    throw new NotMayorityAgeException();
                    //throw new Exception();
                }
                return Age >= Settings.MayoriaDeEdad;
            }
        }

        public bool EsMayorDeEdadMethod()
        {
            return Age >= Settings.MayoriaDeEdad;
        }
            //=> Age >= 18;
            //=> Age >= 18 ? true : false;
            /*
        {
            if(Age >= 18)
            {
                return true;
            }
            return false;
        }
            */
    }
}
