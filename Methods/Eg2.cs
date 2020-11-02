using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Eg2
    {
        void DisplayingUserDetails(string cn, string ci, string g, string mail)
        {
            Console.WriteLine("name:{0}||gender:{2}||email:{3}", cn, ci, g, mail);
        }
        int Total(int[] marray)
        {
            //local to this method
            int sum = 0;
            for(int i=0;i<marray.Length;i++)
            {
                sum = sum + marray[i];
            }
            return sum;

        }
        static void Main()
        {
            string CName, City, gender, email;
            int[] mark = new int[3] { 89, 90, 67 };
            Console.WriteLine("enter cname");
            CName = Console.ReadLine();
            Console.WriteLine("enter City");
            City = Console.ReadLine();
            Console.WriteLine("enter gender");
            gender = Console.ReadLine();
            Console.WriteLine("enter email");
            email = Console.ReadLine();
            Eg2 eg2 = new Eg2();
            eg2.DisplayingUserDetails(CName, City, gender, email);
            Console.WriteLine("sum of marks is : {0}", eg2.Total(mark));
            Console.Read();

        }
    }
}
