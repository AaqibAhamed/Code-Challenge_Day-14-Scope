using System;
using System.Linq;

namespace Code_Challenge_Day_14_Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.WriteLine(d.maximumDifference);
            

            
        }
    }
}
