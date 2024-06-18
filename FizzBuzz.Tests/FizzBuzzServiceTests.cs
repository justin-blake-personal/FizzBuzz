using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void Six_Should_Be_Fizz()
        {
            // arrange
            string value = "6";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value); 

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Fizz", result.Result);
        }


        [TestMethod]
        public void Six_Should_Not_Be_Buzz()
        {
            // arrange
            string value = "6";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("Buzz", result.Result);
        }

        [TestMethod]
        public void Six_Should_Not_Be_FizzBuzz()
        {
            // arrange
            string value = "6";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("FizzBuzz", result.Result);
        }

        [TestMethod]
        public void Ten_Should_Be_Buzz()
        {
            // arrange
            string value = "10";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Buzz", result.Result);
        }

        [TestMethod]
        public void Ten_Should_Not_Be_Fizz()
        {
            // arrange
            string value = "10";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("Fizz", result.Result);
        }

        [TestMethod]
        public void Ten_Should_Not_Be_FizzBuzz()
        {
            // arrange
            string value = "10";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("FizzBuzz", result.Result);
        }

        [TestMethod]
        public void Fifteen_Should_Be_FizzBuzz()
        {
            // arrange
            string value = "15";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("FizzBuzz", result.Result);
        }

        [TestMethod]
        public void Fifteen_Should_Not_Be_Fizz()
        {
            // arrange
            string value = "15";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("Fizz", result.Result);
        }

        [TestMethod]
        public void Fifteen_Should_Not_Be_Buzz()
        {
            // arrange
            string value = "15";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsTrue(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreNotEqual("Buzz", result.Result);
        }


        [TestMethod]
        public void One_Should_Not_Be_FizzBuzzMultiple()
        {
            // arrange
            string value = "1";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsFalse(result.IsFizzBuzzMultiple);
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(null, result.Result);
        }

        [TestMethod]
        public void ABC_Should_Not_Be_Valid()
        {
            // arrange
            string value = "ABC";

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsFalse(result.IsFizzBuzzMultiple);
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(null, result.Result);
        }

        [TestMethod]
        public void Null_Should_Not_Be_Valid()
        {
            // arrange
            string value = null;

            // act
            var result = _fizzBuzzService.GetFizzBuzzResult(value);

            // assert
            Assert.IsFalse(result.IsFizzBuzzMultiple);
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(null, result.Result);
        }
    }
}