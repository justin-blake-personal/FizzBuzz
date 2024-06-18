using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public FizzBuzzResult GetFizzBuzzResult(string value)
        {
            var isNumeric = int.TryParse(value, out int x);

            if (isNumeric)
            {
                // check naming
                var isMultipleOfThree = IsDivisible(x, 3);
                var isMultipleOfFive = IsDivisible(x, 5);

                if (isMultipleOfThree && isMultipleOfFive)
                {
                    return new FizzBuzzResult { Input = value, Result = "FizzBuzz", IsFizzBuzzMultiple = true, IsValid = true };

                }
                else if (isMultipleOfThree)
                {
                    return new FizzBuzzResult { Input = value, Result = "Fizz", IsFizzBuzzMultiple = true, IsValid = true };

                }
                else if (isMultipleOfFive)
                {
                    return new FizzBuzzResult { Input = value, Result = "Buzz", IsFizzBuzzMultiple = true, IsValid = true };

                }
                else
                {
                    return new FizzBuzzResult { Input = value, IsFizzBuzzMultiple = false, IsValid = true };
                }
            }
            else
            {
                return new FizzBuzzResult { Input = value, IsValid = false };
            }
        }

        private bool IsDivisible(int x, int n)
        {
            return (x % n) == 0;
        }
    }
}
