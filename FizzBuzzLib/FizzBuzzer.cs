using System;

namespace FizzBuzzLib
{
    public class FizzBuzzer
    {
       public static string GetValue(int input)
       {
            string result = string.Empty;
            if(input % 3 == 0)
               result += "Fizz";
            if (input % 5 ==0)
                result += "Buzz";
            if(string.IsNullOrEmpty(result))
                result = input.ToString();

           return result;
       }
    }
}
