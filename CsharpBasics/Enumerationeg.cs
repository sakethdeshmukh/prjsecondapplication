using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    enum Feedback
    {
        poor = 1, fair, good, excellent
    }
    class Enumerationeg
    {
        enum Months
        {
            Jan, Feb, mar, April, May, June, July
        }
        static void Main()
        {
            string Ename = "saketh";
            Console.WriteLine("name:{0}||feedback:{1}", Ename, (int)Feedback.good);
            Console.WriteLine("name:{0}||feedback:{1}", Ename, Feedback.good);
            Console.WriteLine("name:{0}||feedback:{1}", Ename, Convert.ToInt32(Feedback.good));
            Console.Read();
        }

    }
}
