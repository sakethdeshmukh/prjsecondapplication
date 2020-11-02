using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class Typeconversioneg
    {
        static void Main()
        {
            //Implicit conversion lower to higher
            //value type
            int salary = 20000;
            float f = salary;
            double d = f;
            Console.WriteLine("implicit conversion");
            Console.WriteLine("Int:{0}||float:{1}||double:{2}", salary, f, d);
            Console.WriteLine("-------------------------");
            //explicit conversion higher to lower
            float sal = 30000.78f;
            int i = Convert.ToInt32(sal);
            Console.WriteLine("explicit conversion");
            Console.WriteLine("float to int : {0}",i);
            Console.Read();



        }
    }
}
