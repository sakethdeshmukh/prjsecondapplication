using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Eg1
    {
        //method with void return type
        void Welcome()
        {
            Console.WriteLine("welcome all!!!");
        }
        //method with string return type
        string Getname()
        {
            return "Manoj";

        }
        //method with int return type
        int Getage()
        {
            return 22;

        }
        char Getinitial()
        {
            return 'd';
        }
        static void Main()
        {
            Eg1 eg1 = new Eg1();
            eg1.Welcome();
            string name = eg1.Getname();
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("age:{0}", eg1.Getage());
            Console.WriteLine("initial:{0}", eg1.Getinitial());
            Console.Read();


        }
    }
}
