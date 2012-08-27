using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mroed.trd.ovelse1
{
    class FizzBuzz
    {
        //private string result = "";
        private int counter = 0;

        public string Print()
        {
            counter++;

            if (counter % 3 == 0 && counter % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (counter % 3 == 0)
            {
                return "Fizz";
            }
            if (counter % 5 == 0)
            {
                return "Buzz";
            }

            return Convert.ToString(counter);
        }
    }
}
