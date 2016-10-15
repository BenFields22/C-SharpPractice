using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime myValue = DateTime.Now;
            /*
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            */

            Console.WriteLine(myValue.Month.ToString());
            Console.WriteLine(myValue.Second);

            //DateTime myBirthday = new DateTime(1992, 07, 24);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("7/24/1992");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine("You are {0} seconds old",myAge.TotalSeconds);

            Console.ReadLine();

        }
    }
}
