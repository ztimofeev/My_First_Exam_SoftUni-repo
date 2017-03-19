using System;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2 * n; i++)
            {
                var dotPart = new string('.', (12 * n - 5)/2 - 3 * i);
                Console.WriteLine(dotPart + "#" + new string('#', 6 * i) + dotPart);
            }
            for (int i = 1; i <= n - 1; i++)
            {
                var hashPart = new string('#', (12 * n - 5) - i * 6);
                Console.WriteLine('|' + new string('.', 3 * i - 1) + hashPart + new string('.', 3 * i));
            }
            for (int i = 1; i < n - 1; i++)
            {
                var bottomPart = new string('.', 3 * n - 4) + new string('#', 6 * n + 1) + new string('.', 3 * n - 3);
                Console.WriteLine('|' + bottomPart);
            }
            Console.WriteLine('@' + new string('.', 3 * n - 4) + new string('#', 6 * n + 1) + new string('.', 3 * n - 3));
        }
    }
}
