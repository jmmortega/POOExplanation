using System;
using System.Collections.Generic;
using System.Text;

namespace POOExplanation
{
    public class PoetryBook : Libro , IAudioBook
    {
        public string Type { get; set; }

        public override string TypeLiteral => nameof(PoetryBook); //"PoetryBook";

        public void ChangeShelve(int shelve)
        {
            if(CheckPages(Pages))
            {

            }
        }

        public override void LeerCapitulo(int capitulo)
        {
            if(Type == "Poesia libre")
            {
                Console.WriteLine("Leer libro");
            }
            else
            {
                base.LeerCapitulo(capitulo);
            }   
            
        }

        public void PlayChapter(int chapter)
        {
            //Add code here...
        }

        public override string ToString()
        {
            return Pages.ToString() + " " + Title;
        }


    }
}
