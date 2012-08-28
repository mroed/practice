using System;

namespace mroed.trd.ovelse2
{
    public class BuzzPredicate
    {
        public virtual bool Matches(int number)
        {
            return (number%5 == 0);
        } 
    }
}