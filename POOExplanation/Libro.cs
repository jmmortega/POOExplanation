using System;
using System.Collections.Generic;
using System.Text;

namespace POOExplanation
{
    public class Libro
    {
        //-->Accessors
        //private
        //protected
        //public
        //internal Ignore

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


        private int _pages;
        public int Pages 
        {
            get => _pages;
            
            set
            {
                if(value != 0 || value > 0)
                {
                    _pages = value;
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

        private string _encuadernacion;
        public string Encuadernacion
        {
            get;
            set;
        }

        public void LeerCapitulo(int capitulo)
        {

        }

        public static Libro Empty() => new Libro();


    }
}
