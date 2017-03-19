using System;

namespace DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            var houseWidth = double.Parse(Console.ReadLine());
            var houseHeight = double.Parse(Console.ReadLine());

            var sideWall = houseWidth * houseWidth / 2;
            var backSide = (houseWidth / 2) * (houseWidth / 2) + (houseWidth / 2) * (houseHeight - houseWidth / 2) / 2;
            var frontSide = backSide - houseWidth / 5 * houseWidth / 5;
            var roof = 2 * houseWidth * houseWidth / 2;

            var greenColor = (2 * sideWall + backSide + frontSide) / 3;
            var redColor = roof / 5;

            Console.WriteLine("{0:f2}", greenColor);
            Console.WriteLine("{0:f2}", redColor);
        }
    }
}
