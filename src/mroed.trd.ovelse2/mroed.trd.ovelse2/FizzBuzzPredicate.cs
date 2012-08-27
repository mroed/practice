using System;

namespace mroed.trd.ovelse2
{
    public class FizzBuzzPredicate
    {
        public virtual bool Matches(int number)
        {
            if (number % 3 == 0)
                return true;
            if (number % 5 == 0)
                return true;
            return false;
        } 
    }
}