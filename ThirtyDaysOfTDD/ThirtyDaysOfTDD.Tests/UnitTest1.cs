using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using ThirtyDaysOfTDD.Service;

namespace ThirtyDaysOfTDD.Tests
{
    [TestFixture]
    public class StringUtilsTest
    {
        private StringUtils _stringUtils;

        [OneTimeSetUpAttribute]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            //Arrange
            var sentenceToScan = "TDD is awesome!";
            var charToScanFor = "e";
            var expectedResult=2;
            //Act
            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var charToScanFor = "n";
            var expectedResult = 5;
            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentenceToScan = "This test should throw an exception";
            var charToScanFor = "xx";
            //stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor);
            Assert.That(() => _stringUtils.FindNumberOfOccurences(sentenceToScan, charToScanFor), 
                Throws.TypeOf<ArgumentException>());
        }
    }
}