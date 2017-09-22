using NUnit.Framework;
using System;

namespace StringCalculatorKata.UnitTests
{
    public class StringCaculatorSpecs
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("7", 7)]
        public void ShouldReturnPassedValue(string input, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("1,2", 3)]
        [TestCase("2,2", 4)]
        [TestCase("21,2", 23)]
        [TestCase("21,2,1", 24)]
        [TestCase("1|2|12", 15)]
        [TestCase("1.2.12", 15)]
        [TestCase("//;\n1;2", 3)]
        public void ShouldReturnSumOf2Numbers(string input, int expected)
        {
            var sut = new StringCalculator();
            var result = sut.Add(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("-1")]
        [TestCase("//;\n-1;2")]
        public void ShouldNotAllowNegativeNumbers(string input)
        {
            var sut = new StringCalculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.Add(input));
        }
    }
}