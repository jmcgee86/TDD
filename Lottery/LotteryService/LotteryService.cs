using System;

namespace LotteryService
{
    public class Class1
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            if(lotteryNums.Length<2)
                return lotteryNums; 
            
            int temp;
            bool sorted = false;
            while(!sorted)
            {
                var swaps = 0;

                for(var i = 0; i<lotteryNums.Length-1; i++)
                {
                    if(lotteryNums[i]>lotteryNums[i+1])
                    {
                        temp = lotteryNums[i];
                        lotteryNums[i] = lotteryNums[i+1];
                        lotteryNums[i+1] = temp;
                        swaps++;
                    }
                    // if(i==lotteryNums.Length-2 && swaps==0)  
                }
                if(swaps==0)
                    sorted = true;
            }

            return lotteryNums;
        }
    }
}
