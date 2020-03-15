using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LengthJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[][] numbers = new byte[5][];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new byte[i + 3];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, numbers[i].Length);
            }
            Console.Read();
        }
    }
}
