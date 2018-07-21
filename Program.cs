using System;
using FizzBuzzLib;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i<=100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }
        }
    }
}
