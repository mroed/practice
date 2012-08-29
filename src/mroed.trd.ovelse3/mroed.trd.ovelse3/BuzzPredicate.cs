using System;

namespace mroed.trd.ovelse3
{
    public class BuzzPredicate
    {
        //TODO remove int method
        //public virtual bool Matches(int number)
        //{
        //    return (number%5 == 0);
        //}

        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}