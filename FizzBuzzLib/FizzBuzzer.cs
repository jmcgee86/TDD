using System;

namespace FizzBuzzLib
{
    public class FizzBuzzer
    {
       public static string GetValue(int input)
       {
           //return "1"; - passes test 1
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            if(input % 3 == 0)
                return "Fizz";
            if (input % 5 ==0)
                return "Buzz";
           return input.ToString(); //passes tests 1+2
       }
    }
}
