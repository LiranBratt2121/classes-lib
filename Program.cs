using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;

            int? x = condition ? 12 : null;

            IEnumerable<int> xs = x is null ? new List<int>() { 0, 1 } : new int[] { 2, 3 };
        }
    }
}
