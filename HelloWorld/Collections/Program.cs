using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {Make = "BMW", Price= 111, Year= 1999, Color = "Blue" },
                new Car() { Make = "Ford", Price = 222, Year = 2222, Color = "Red" },
                new Car() {Make = "toyota", Price= 333, Year= 1998, Color = "Green" }
            };

            var selection = from car in myCars
                            where car.Color == "Blue"
                            && car.Make == "BMW"||car.Price > 300
                            select new { car.Make, car.Price, car.Year };

            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            

            foreach (var car in selection)
                Console.WriteLine("Make: {0} - Price: {1} - Year: {2}\n", car.Make, car.Price, car.Year);

            foreach (var car in orderedCars)
                Console.WriteLine("Make: {0} - Price: {1} - Year: {2}", car.Make, car.Price, car.Year);
            Console.ReadLine();


        }
    }

    class Car
    {
        public int Year { get; set; }
        public int Price { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

    }
    enum Color
    {
         RED,
        Blue,
        Green,
        Yellow,
        White
    }
    enum Make
    {
        ford,
        toyota,
        subaru,
        kia,
        bmw,
        mercedes,
        farrari
    }
    

    }

