using System.Collections.Generic;
using System;

namespace Dislpay_values_in_reverse
{
    class Program
    {
        static Stack<string> values = new Stack<string>();

        static void Main()
        {
            Console.WriteLine("Type any 5 values");

            values.Push(Console.ReadLine());
            values.Push(Console.ReadLine());
            values.Push(Console.ReadLine());
            values.Push(Console.ReadLine());
            values.Push(Console.ReadLine());

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
