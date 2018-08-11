using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach (int values in value)
            {
               Console.WriteLine(values);
            }
               Console.ReadLine();
        }
    }
}
