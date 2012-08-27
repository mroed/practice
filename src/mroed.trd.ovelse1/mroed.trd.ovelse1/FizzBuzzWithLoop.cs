
using System;

namespace mroed.trd.ovelse1
{
    public class FizzBuzzWithLoop
    {
        private int counter = 0;
        private string result = "";
        
        public string Print()
        {
            
            
            counter++;
            result = Convert.ToString(counter);

            if (counter % 3 == 0)
                result = "Fizz";
            //for (int i = 0; i < 3; i++)
            //{
            //    result = Convert.ToString(i);
            //}

            return result;
        }
    }
}   