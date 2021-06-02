using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer8
{
    public class NotMayorityAgeException : Exception
    {
        public NotMayorityAgeException() : base("Edad no seteada")
        {

        }

        /*
         * We can pass parameters from child to parents classes
        public NotMayorityAgeException(string msg) : base(msg)
        {

        }
        */
        //public override string Message => "Edad no seteada";
    }
}
