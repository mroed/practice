using System;
using System.Collections.Generic;

namespace mroed.trd.ovelse2
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

        public virtual bool Matches(int number)
        {
            return (_fizzPredicate.Matches(number) || _buzzPredicate.Matches(number));
        }

        public FizzBuzzPredicate()
        {

        }
    }
}