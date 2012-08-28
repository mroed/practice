using System;

namespace mroed.trd.ovelse3
{
    public class BuzzPredicate
    {
        public virtual bool Matches(int number)
        {
            return (number%5 == 0);
        } 
    }
}