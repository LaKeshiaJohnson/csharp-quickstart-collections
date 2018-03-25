using System;
using System.Collections.Generic;

namespace cSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Keshia", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
