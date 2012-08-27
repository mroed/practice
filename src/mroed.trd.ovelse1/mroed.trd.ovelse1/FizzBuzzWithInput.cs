using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mroed.trd.ovelse1
{
    public class FizzBuzzWithInput
    {
        public string PrintNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return Convert.ToString(number);
        }
    }
}
