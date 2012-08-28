using System;

namespace mroed.trd.ovelse2
{
    public class FizzPredicate
    {
        public virtual bool Matches(int number)
        {
            return (number%3 == 0);
        }   
    }
}