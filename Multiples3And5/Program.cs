using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; //Create a running total
            for (int i = 1; i < 1000; i++) //Run a for loop that increments up to 100
            {
                if (i % 3 == 0 || i % 5 == 0) //If the number leaves a remainder of 0 when divided by 3 or 5, add it to the running total
                {
                    sum += i; //Running total equals the running total plus the number
                }
            }

            Console.WriteLine("The sum of all numbers less than 1000 that are divisible by 3 or 5 is " + sum);
        }
    }
}
