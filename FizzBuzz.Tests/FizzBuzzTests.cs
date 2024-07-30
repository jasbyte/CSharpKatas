using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase((object)new string[] { })]
        [TestCase((object)new string[] { "1", "2" })]
        public void Start_WhenInvalidNumberOfProvided_ShouldThrowException(string[] arguments)
        {
            Assert.Throws<ArgumentException>(
                () => FizzBuzz.Start(arguments),
                $"Expected 1 argument but received {arguments.Length}"
            );
        }

        [TestCase((object)new string[] { "one" })]
        [TestCase((object)new string[] { "One" })]
        [TestCase((object)new string[] { "1One" })]
        public void Start_WhenStringValueCanNotBeParsed_ShouldThrowException(string[] arguments)
        {
            Assert.Throws<ArgumentException>(
                () => FizzBuzz.Start(arguments),
                $"{arguments[0]} can not be parsed to a number"
            );
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        [TestCase(21)]
        [TestCase(24)]
        [TestCase(27)]
        public void DetermineStringValue_WhenValueOnlyDivisibleBy3_ShouldReturnFizz(int value)
        {
            Assert.That(FizzBuzz.DetermineStringValue(value), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(35)]
        [TestCase(40)]
        [TestCase(50)]
        [TestCase(55)]
        public void DetermineStringValue_WhenValueOnlyDivisibleBy5_ShouldReturnBuzz(int value)
        {
            Assert.That(FizzBuzz.DetermineStringValue(value), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        [TestCase(75)]
        [TestCase(90)]
        [TestCase(105)]
        [TestCase(120)]
        public void DetermineStringValue_WhenValueBothDisivibleBy3And5_ShouldReturnFizzBuzz(int value)
        {
            Assert.That(FizzBuzz.DetermineStringValue(value), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        public void DetermineStringValue_WhenValueBothNotDisivibleBy3And5_ShouldReturnFizzBuzz(int value)
        {
            Assert.That(FizzBuzz.DetermineStringValue(value), Is.EqualTo(value.ToString()));
        }
    }
}
