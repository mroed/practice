using System;
using System.Collections.Generic;

namespace mroed.trd.ovelse3
{
    public class OrPredicateFactory<T>
    {
         public virtual OrPredicate<T> Create(IEnumerable<Predicate<T>> predicates )
         {
             throw new NotImplementedException();
         }
    }
}