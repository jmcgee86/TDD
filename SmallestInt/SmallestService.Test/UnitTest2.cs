using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }
        
        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            var input = new int[1]{1};
            var output = finder.FindClosestIntToZero(input);
            var expectedOutput = 1;
            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            var input = new int[2]{2,3};
            var output = finder.FindClosestIntToZero(input);
            var expectedOutput = 2;
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            var input = new int[3]{5, 9, 7};
            var output = finder.FindClosestIntToZero(input);
            var expectedOutput = 5;
            Assert.AreEqual(expectedOutput, output);
        }
        
        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            var input = new int[5]{5, 11, 7, -3, 2};
            var output = finder.FindClosestIntToZero(input);
            var expectedOutput = 2;
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            var input = new int[5]{5, 11, 7, 2, -2};
            var output = finder.FindClosestIntToZero(input);
            var expectedOutput = -2;
            Assert.AreEqual(expectedOutput, output);
        }    
    }
}