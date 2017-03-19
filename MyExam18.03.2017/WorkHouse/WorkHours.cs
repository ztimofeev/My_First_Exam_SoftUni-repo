using System;

namespace WorkHouse
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var totalWorkTime = workers * workingDays * 8;
            if (totalWorkTime >= hours)
            {
                Console.WriteLine("{0} hours left", totalWorkTime - hours);
            }
            else
            {
                Console.WriteLine("{0} overtime", hours - totalWorkTime);
                var penalties = (hours - totalWorkTime) * workingDays;
                Console.WriteLine("Penalties: {0}", penalties);
            }
        }
    }
}
