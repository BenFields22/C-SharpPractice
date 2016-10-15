using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a.ToString());
                if (a==7)
                {
                    Console.WriteLine("found seven!");
                    int v = a;

                    break;

                }
                if (a == 2)
                    Console.WriteLine("Why two is such a great number");
            }
            for (int i = 0; i < 12; i++)
            {
                int value = i + 7;

                Console.WriteLine(value);

            }
            Console.ReadLine();

        }
    }
}
