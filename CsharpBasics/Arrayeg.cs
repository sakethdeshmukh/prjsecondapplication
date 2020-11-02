using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    //array is collection of homogeneous data type
    class Arrayeg
    {
        static void Main()
        {
            //data type[] arrname=new datatype[size];
            //datatype[] arrname=new datatype[size]{};
            //new----> allocates memory
            string[] flower = new string[4];
            flower[0] = "lilly";
            flower[1] = "rose";
            flower[2] = "jasmine";
            flower[3] = "lotus";
            Console.WriteLine(flower[0]);
            for (int i = 0; i < flower.Length; i++)
            {
                Console.WriteLine("index{0}:{1}", i, flower[i]);
            }
            //int size=4;
            //int[] marks=new int[4] {10,20,30,40};


            /*Console.WriteLine("enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] sweets = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("index{0}:{1}", i, sweets[i]);
                size = Convert.ToInt32(Console.ReadLine());
            }
            Console.Read();
            */
            int marks;
            Console.WriteLine("Enter size of index:");
            marks = Convert.ToInt32(Console.ReadLine());
            int[] index = new int[marks];
            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine("Enter number:");
                index[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.Read();
        }
    }
}
