using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class Stringeg
    {
        static void Main()
        {
            string firstname = "Saketh";
            Console.WriteLine("length of the string:{0}", firstname.Length);
            Console.WriteLine("Converting to uppercase:{0}", firstname.ToUpper());
            Console.WriteLine("contain:{0}", firstname.Contains("ake"));
            Console.WriteLine("indesx s:{0}", firstname.IndexOf("s"));
            Console.Read();
        }
    }
}
