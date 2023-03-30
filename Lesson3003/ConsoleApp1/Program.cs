using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           void Increment (ref int n)
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }
            int number = 5;
            Console.WriteLine($"Число до метода Increment: {number}");

            Increment(ref number);
            Console.WriteLine($"Число после метода Increment: {number}");

            Console.ReadLine();
        }
    }
}
 