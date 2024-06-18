using FizzBuzz.Controllers;
using FizzBuzz.Models;
using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        HomeController _controller;

        public HomeControllerTests()
        {
            _fizzBuzzService = new FizzBuzzService();
            _controller = new HomeController(_fizzBuzzService);
        }

        [TestMethod]
        public void FizzBuzz_Returns_ListOfFizzBuzzResult()
        {
            // arrange
            List<string> inputs = new List<string>()
            {
                "1","3","5", null, "15", "A", "23"
            };

            // act
            var result = _controller.FizzBuzz(inputs);

            var viewResult = result.Result as ViewResult;
            var fizzBuzzResults = viewResult?.Model as List<FizzBuzzResult>;

            // assert
            Assert.IsTrue(fizzBuzzResults?.Count == 7);
            Assert.IsFalse(fizzBuzzResults[0].IsFizzBuzzMultiple);
            Assert.IsTrue(fizzBuzzResults[1].IsFizzBuzzMultiple);
            Assert.IsTrue(fizzBuzzResults[2].IsFizzBuzzMultiple);
            Assert.IsFalse(fizzBuzzResults[3].IsFizzBuzzMultiple);
            Assert.IsTrue(fizzBuzzResults[4].IsFizzBuzzMultiple);
            Assert.IsFalse(fizzBuzzResults[5].IsFizzBuzzMultiple);
            Assert.IsFalse(fizzBuzzResults[6].IsFizzBuzzMultiple);
        }
    }
}
