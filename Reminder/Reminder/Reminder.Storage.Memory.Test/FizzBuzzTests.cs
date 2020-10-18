using NUnit.Framework;

namespace Reminder.Storage.Memory.Test
{
    public class FizzBuzzTests
    {
        [Test]
        public void GivenThree_ShouldReturnFizz() => Assert.AreEqual("Fizz", FizzBuzz(3));

        [Test]
        public void Given9_ShouldReturnFizz() => Assert.AreEqual("Fizz", FizzBuzz(9));

        [Test]
        public void Test3() => Assert.AreEqual("Buzz", FizzBuzz(20));

        [Test]
        public void Test4() => Assert.AreEqual("13", FizzBuzz(13));

        [Test]
        public void Test5() => Assert.AreEqual("FizzBuzz", FizzBuzz(15));

        [TestCase(3, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(20, "Buzz")]
        [TestCase(13, "13")]
        [TestCase(15, "FizzBuzz")]
        public void GivenFitheen_ShouldReturnExpectedString(int number, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz(number));
        }



        public string FizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

    }
}