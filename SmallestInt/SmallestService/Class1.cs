using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindClosestIntToZero(int[] input)
        {
            if(input.Length==0)
                throw new ArgumentException();

            var closestIntToZero = input[0];
            foreach (var num in input)
            {
                if (Math.Abs(num) < Math.Abs(closestIntToZero) && (Math.Abs(num) == Math.Abs(closestIntToZero) && num < closestIntToZero))
                    closestIntToZero = num;
                else
                    closestIntToZero = num;
            }
            return closestIntToZero;
        }
        public int FindSmallestInt(int[]input)
        {
            if (input.Length == 0)
                throw new ArgumentException();

            // var smallestInt = input[0];

            // foreach (var num in input)
            // {
            //     if (num < smallestInt)
            //         smallestInt = num;
            // }

            // return smallestInt;

            return input.Min();
        }
    }
}
