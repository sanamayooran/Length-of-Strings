using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_strings
{
    internal class Len
    {
        public static int[] lens(string[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr), "Input array cannot be null.");
            }

            int[] lengths = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                lengths[i] = arr[i] == null ? 0 : arr[i].Length;
            }
            return lengths;
        }
    }
}
