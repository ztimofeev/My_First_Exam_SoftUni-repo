using System;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            var carClass = "";
            var carType = "Jeep";
            double price = 0;

            if (budget <= 100 )
            {
                carClass = "Economy class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    price = budget * 0.80;
                }
            }
            else
            {
                carClass = "Luxury class";
                price = budget * 0.90;
            }
            Console.WriteLine(carClass);
            Console.WriteLine("{0} - {1:f2}", carType, price);
        }
    }
}
