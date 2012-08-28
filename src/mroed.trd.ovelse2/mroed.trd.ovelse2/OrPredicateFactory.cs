using System;
using System.Collections.Generic;

namespace mroed.trd.ovelse2
{
    public class OrPredicateFactory<T>
    {
         public virtual OrPredicate<T> Create(IEnumerable<Predicate<T>> predicates )
         {
             throw new NotImplementedException();
         }
    }
}