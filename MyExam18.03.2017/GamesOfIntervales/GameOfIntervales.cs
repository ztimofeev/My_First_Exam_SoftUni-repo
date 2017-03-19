using System;

namespace GamesOfIntervales
{
    class GameOfIntervales
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

            double result = 0;
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double invalid = 0;

            for (int i = 0; i < counter; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    result += (currentNumber * 0.20);
                    count1++;
                }
                else if (currentNumber >= 10 && currentNumber <= 19)
                {
                    result += (currentNumber * 0.30);
                    count2++;
                }
                else if (currentNumber >= 20 && currentNumber <= 29)
                {
                    result += (currentNumber * 0.40);
                    count3++;
                }
                else if (currentNumber >= 30 && currentNumber <= 39)
                {
                    result += 50;
                    count4++;
                }
                else if (currentNumber >= 40 && currentNumber <= 50)
                {
                    result += 100;
                    count5++;
                }
                else if (currentNumber < 0 || currentNumber > 50)
                {
                    result = result / 2;
                    invalid++;
                }
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", count1 / counter * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", count2 / counter * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", count3 / counter * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", count4 / counter * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", count5 / counter * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalid / counter * 100);
        }
    }
}
