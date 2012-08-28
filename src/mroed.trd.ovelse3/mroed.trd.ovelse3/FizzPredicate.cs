using System;

namespace mroed.trd.ovelse3
{
    public class FizzPredicate
    {
        public virtual bool Matches(int number)
        {
            return (number%3 == 0);
        }

        public virtual bool Matches(Counter counter)
        {
            throw new NotImplementedException();
        }
    }
}