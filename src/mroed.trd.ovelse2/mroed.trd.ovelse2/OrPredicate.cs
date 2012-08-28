using System;
using System.Collections.Generic;

namespace mroed.trd.ovelse2
{
    public class OrPredicate<T>
    {
        public virtual OrPredicate<T> Setup(IEnumerable<T> predicates)
        {
            throw new NotImplementedException();
        }

        public virtual bool Matches(T arg)
        {
            throw new NotImplementedException();
        }
         
    }
}