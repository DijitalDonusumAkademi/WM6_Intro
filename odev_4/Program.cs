using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Baklava şekli
            Console.WriteLine("Birsayı giriniz: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < 2 * x; i++)
            {
                if (i <= x)
                {
                    for (int j = 1; j <= i + x - 1; j++)
                    {

                        if (x - i >= j) Console.Write(" ");
                        else Console.Write("x");
                    }
                }
                else
                {
                    for (int j = 1; j < (2 * x) - (i - x); j++)
                    {
                        if (i - x >= j) Console.Write(" ");
                        else Console.Write("x");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------");

            //İçi boş üçgen şekli
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < 2*x-1; j++)
                {
                    if (j==x-i-1 || j==x+i-1 || i==x-1)
                    {
                        Console.Write("x");
                    }
                    else
                    { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
