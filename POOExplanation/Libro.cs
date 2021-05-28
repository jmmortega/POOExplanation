using System;
using System.Collections.Generic;
using System.Text;

namespace POOExplanation
{
    public abstract class Libro
    {
        //-->Accessors
        //private
        //protected
        //public
        //internal Ignore

        //namespace

        //-->Atributes
        //static

        //virtual
        //abstract // Require override | In class don't instantiate to object

        public Libro(string title, int pages)
        {       
            _title = title;
            Pages = pages;
        }

        public Libro()
        {

        }

        public string ISBN { get; set; }


        private int _pages;
        public int Pages 
        {
            get => _pages;
            
            set
            {
                if(value > 0)
                {
                    _pages = value;
                }
                else 
                {
                    Encuadernacion = string.Empty;
                    Console.WriteLine("");
                }
            }
        }

        /*
        private int _pages;
        public int Pages
        {
            get;
            set;
        }
        */

        /* In fact this is a property
        public int getPages()
        {
            return _pages;
        }

        
        */

        public void setPages(int pages)
        {
            _pages = pages;
        }

        private string _title;
        public string Title
        {
            get;
        }

        //Another way to categorize types of book is with a Enum
        //public EnumCategory Category { get; set; }

        
        private string _encuadernacion;
        public string Encuadernacion
        {
            get;
            set;
        }

        public abstract string TypeLiteral { get; }

        
        public virtual void LeerCapitulo(int capitulo)
        {
            Console.WriteLine(Settings.Path);
        }

        protected bool CheckPages(int pages) => _pages > 0;


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var comparedBook = (Libro)obj;

            return comparedBook.ISBN == ISBN;
        }

        /*
{
   if(_pages > 0)
   {
       return true;
   }
   else
   {
       return false;
   }
}
*/

        public static Libro Empty() => new Libro();

        


    }
}
