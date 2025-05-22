using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] example1 = { "How", "is", "it", "you" };
            string[] example2 = { "first", "second", "third", "4" };

            int[] result1 = Len.lens(example1);
            int[] result2 = Len.lens(example2);
            Console.WriteLine(string.Join(", ", result1)); // Output: 3, 2, 2, 3
            Console.WriteLine(string.Join(", ", result2)); // Output: 5, 6, 5, 1
            Console.ReadLine();
        }
    }
}
