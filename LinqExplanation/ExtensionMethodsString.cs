using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExplanation
{
    public static class ExtensionMethodsString
    {
        public static string EncodingUrl(this string url)
        {
            /*
            //if(url.contains(' '))
            {
                url = url.Replace(' ', "%20");
            }
            */

            return url;
        }

        public static void Show(this Persona p)
        {
            Console.WriteLine(p);
        }

        public static void Foreach<T>(this List<T> coll, Action<T> execute)
        {
            foreach(var element in coll)
            {
                execute.Invoke(element);
            }
        }
    }
}
