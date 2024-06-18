using FizzBuzz.Models;

namespace FizzBuzz.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        FizzBuzzResult GetFizzBuzzResult(string value);
    }
}
