using System;

namespace mroed.trd.ovelse2
{
    public class FizzBuzzPrinter
    {
        public virtual string Print(int number)
        {
            string result = "";
            if (number % 3 == 0 && number % 5 != 0)
                return "Fizz";
            if (number % 5 == 0 && number % 3 != 0)
                return "Buzz";
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            return null;
        }
    }
}