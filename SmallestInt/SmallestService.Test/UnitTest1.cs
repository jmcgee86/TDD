using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }
        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1]{1};
            var output = finder.FindSmallestInt(input);
            var expectedOutput = 1;
            Assert.AreEqual(expectedOutput, output);
        }

               [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2]{4, 2};
            var output = finder.FindSmallestInt(input);
            var expectedOutput = 2;
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3]{4, 5, 3};
            var output = finder.FindSmallestInt(input);
            var expectedOutput = 3;
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[10]{4, 5, 3, 100, -7, 0, 19, 27, 1000, 11};
            var output = finder.FindSmallestInt(input);
            var expectedOutput = -7;
            Assert.AreEqual(expectedOutput, output); 
        }
    }
}