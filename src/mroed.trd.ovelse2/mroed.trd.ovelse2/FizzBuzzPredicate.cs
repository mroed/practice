using System;

namespace mroed.trd.ovelse2
{
    public class FizzBuzzPredicate
    {
        public virtual bool Matches(int number)
        {
            throw new InvalidOperationException();
        } 
    }
}