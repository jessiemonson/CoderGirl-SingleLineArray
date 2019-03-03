using System;

namespace SingleLineArray
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Initialize a single line an array with the following values: 1, 1, 2, 3, 5, 8. 
            int[] arrayList = { 1, 1, 2, 3, 5, 8 };
            // TODO: Loop through the array using foreach and print out each value on its own line.
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
