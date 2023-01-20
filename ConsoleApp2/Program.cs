using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Write size of matrix");
            int s = int.Parse(Console.ReadLine());
            int[,] matrix = new int[s, s];

            Console.Write("Matrix:\n\n");
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    matrix[i, j] = r.Next(-3, 15);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine("\n");
            } 


            int sum = 0;
            for (int i = 0; i < s; i++)  
            {
                sum = 0;
                for (int j = 0; j < s; j++)
                {
                    if (matrix[i, j] >= 0) sum += matrix[i, j];
                    else
                    {
                        sum = 0;
                        break;
                    }
                }
                if (sum != 0) Console.WriteLine("\nSum of elements in row № {0} = {1}", i + 1, sum);
            }

          

            int diagonal1 = 0, diagonal2 = 0, diagonal3 = 0, diagonal4 = 0;


            for (int k = 0; k < s - 2; k++)
            {
                diagonal1 += matrix[k, k + 2];
                diagonal4 += matrix[k + 2, k];
            }

            for (int k = 0; k < s - 1; k++)
            {
                diagonal2 += matrix[k, k + 1];
                diagonal3 += matrix[k + 1, k];
            }

            Console.WriteLine("Sum diagonal  :\n");
            Console.Write(diagonal1 + ", " + diagonal2 + ", " + diagonal3 + ", " + diagonal4 + "");

            int[] masD = { diagonal1, diagonal2, diagonal3, diagonal4 };
            int min = masD.Min();

            Console.WriteLine("\n\nMin elements in diagonal: {0}", min);

            Console.ReadKey();
        }
    }

    
}
