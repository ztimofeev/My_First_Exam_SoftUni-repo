using System;

namespace TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var counter = 0;
 
            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    var sum = i + j;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        return;
                    } 
                } 
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
