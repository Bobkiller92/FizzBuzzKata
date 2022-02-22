using FizzBuzzKata.Prod;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTests
    {        
        [Test]
        public void Should_Return_Fizz_For_9()
        {
            uint number = 9;

            string result = FizzBuzz.GetFizzBuzzMessage(number);
            
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void Should_Return_SameNumber_For_7()
        {
            uint number = 7;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("7", result);
        }

        [Test]
        public void Should_Return_Nothing_For_2()
        {
            uint number = 2;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("2", result);
        }

        [Test]
        public void Should_Return_Nothing_For_13()
        {
            uint number = 13;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("13", result);
        }

        [Test]
        public void Should_Return_Buzz_For_10()
        {
            uint number = 10;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void Should_Return_Buzz_For_25()
        {
            uint number = 25;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void Should_Return_FizzBuzz_For_15()
        {
            uint number = 15;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void Should_Return_FizzBuzz_For_30()
        {
            uint number = 30;

            string result = FizzBuzz.GetFizzBuzzMessage(number);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}