using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[15];
            Random r = new Random();
            double s = 0;
            double p = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-100, 101);
                Console.WriteLine(mas[i] + " ") ;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    p *= mas[i];
                }
            }
            int dex = 0;
            double max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    dex += i;
                    max = mas[i];
                }
            }
            for (int i = 0; i < dex; i++)
            {
                if (mas[i] > 0)
                {
                    s += mas[i];

                }
            }
            Console.WriteLine();
            Console.WriteLine("Reverse: ");
            Array.Reverse(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i] + " ");
            }
                Console.WriteLine() ;
            Console.WriteLine("Summ elements of mas before max: " + s);
            Console.WriteLine("Product negative numbers in mas: " + p);
            Console.ReadLine();



        }
       
    }
}
