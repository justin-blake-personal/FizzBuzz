using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public HomeController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<string> FizzBuzz(List<string> values)
        {
            List<FizzBuzzResult> fizzBuzzResults = [];

            foreach (var value in values)
            {
                fizzBuzzResults.Add(_fizzBuzzService.GetFizzBuzzResult(value));
            }

            return View("Results", fizzBuzzResults);
        }
    }
}
