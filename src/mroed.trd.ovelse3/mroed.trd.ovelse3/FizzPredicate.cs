using System;

namespace mroed.trd.ovelse3
{
    public class FizzPredicate
    {
        //TODO remove int method
        //public virtual bool Matches(int number)
        //{
        //    return (number%3 == 0);
        //}

        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 3 == 0);
        }
    }
}