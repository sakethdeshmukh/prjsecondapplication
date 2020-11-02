using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class TwoDarrayeg
    {
        static void Main()
        {
            Console.WriteLine("enetr the rows and columns of matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    Console.WriteLine("Matrix[{0}{1}]",i,j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //displaying
            for(int i=0;i<row;i++)
                {
                for(int j=0;j<column;j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
