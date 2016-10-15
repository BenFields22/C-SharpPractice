using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };


            //Console.WriteLine(numbers.Length);

            /* string[] names = new string[] { "Eddie", "alex", "Michael" };

             foreach (string a in names)
                 Console.WriteLine(a);*/

            string zig = "my name is ben fields";

            char[] chararray = zig.ToCharArray();
            Array.Reverse(chararray);

            foreach (char zigchar in chararray)
            {
                Console.Write(zigchar);
                
            }
            Console.WriteLine("\n");

            //2 dimensional arrays
            //initialize the two dinsional aspect with the syntax [,]
            //can then call the specific refererence within the array with name[x,y]
            // the first x indicates which array to look at and the second y indicates which reference within x to look at
           string[,] numbers = 
                { 
                { "one", "two", "three" } ,
                { "apple","orange", "grape"}
                };

            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write("{0}  ",numbers[row, column]);

                }
                Console.WriteLine();
            }

            Console.ReadLine();
            

            


        }
    }
}
