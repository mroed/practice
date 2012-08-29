using System;
using System.Collections.Generic;

namespace mroed.trd.ovelse3
{
    public class FizzBuzzPredicate
    {
        private readonly BuzzPredicate _buzzPredicate;
        private readonly FizzPredicate _fizzPredicate;

        public FizzBuzzPredicate(FizzPredicate fizzPredicate, BuzzPredicate buzzPredicate)
        {
            _buzzPredicate = buzzPredicate;
            _fizzPredicate = fizzPredicate;
        }

        //private readonly OrPredicate<int> _predicate;

        //public FizzBuzzPredicate(OrPredicateFactory<int> predicateFactory, FizzPredicate fizzPredicate, BuzzPredicate buzzPredicate)
        //{
        //    _predicate = predicateFactory.Create(new List<Predicate<int>>{fizzPredicate, buzzPredicate});
        //}

        //TODO remove int method
        //public virtual bool Matches(int number)
        //{
        //    return (_fizzPredicate.Matches(number) || _buzzPredicate.Matches(number));
        //}

        public virtual bool Matches(Counter counter)
        {
            return (_fizzPredicate.Matches(counter) || _buzzPredicate.Matches(counter));
        }
        public FizzBuzzPredicate()
        {
        }
    }
}