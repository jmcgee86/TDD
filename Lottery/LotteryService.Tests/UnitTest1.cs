using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests
    {
        Class1 _testService = new Class1();
        [Test]
        public void return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);
        }
        [Test]
        public void return_OneNumSorted()
        {
            int[]lotteryNumbers1 = new int[1];
            lotteryNumbers1[0] = 1;
            var expected = new int[1]{1};
            var output = _testService.SortNumbers(lotteryNumbers1);
            Assert.AreEqual(expected,output);
        }
        [Test]
        public void return_twoNumSorted()
        {
            int[]lotteryNumbers2 = new int[2];
            lotteryNumbers2[0] = 11;
            lotteryNumbers2[1] = 7;
            var expected = new int[2]{7,11};
            var output = _testService.SortNumbers(lotteryNumbers2);
            Assert.AreEqual(expected,output);
        }
        [Test]
        public void return_threeNumSorted()
        {
            int[]lotteryNumbers3 = new int[3];
            lotteryNumbers3[0] = 30;
            lotteryNumbers3[1] = 15;
            lotteryNumbers3[2] = 2;
            var expected = new int[3]{2,15,30};
            var output = _testService.SortNumbers(lotteryNumbers3);
            Assert.AreEqual(expected,output);
        }

        [Test]
        public void return_tenNumSorted()
        {
            int[]lotteryNumbers10 = new int[10];
            lotteryNumbers10[0] = 9;
            lotteryNumbers10[1] = 3;
            lotteryNumbers10[2] = 2;
            lotteryNumbers10[3] = 1;
            lotteryNumbers10[4] = 10;
            lotteryNumbers10[5] = 4;
            lotteryNumbers10[6] = 7;
            lotteryNumbers10[7] = 5;
            lotteryNumbers10[8] = 6;
            lotteryNumbers10[9] = 8;
            
            var expected = new int[10]{1,2,3,4,5,6,7,8,9,10};
            var output = _testService.SortNumbers(lotteryNumbers10);
            Assert.AreEqual(expected,output);
        }
    }
}