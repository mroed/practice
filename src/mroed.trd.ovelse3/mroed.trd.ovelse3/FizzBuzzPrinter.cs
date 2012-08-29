using System;

namespace mroed.trd.ovelse3
{
    public class FizzBuzzPrinter
    {
        private readonly FizzPredicate _fizzPredicate;
        private readonly BuzzPredicate _buzzPredicate;

        public FizzBuzzPrinter(FizzPredicate fizzPredicate, BuzzPredicate buzzPredicate)
        {
            _fizzPredicate = fizzPredicate;
            _buzzPredicate = buzzPredicate;
        }

        //TODO remove int method
        //public virtual string Print(int number)
        //{
        //    if (_fizzPredicate.Matches(number) && _buzzPredicate.Matches(number))
        //        return "FizzBuzz";
        //    if (_buzzPredicate.Matches(number))
        //        return "Buzz";
        //    return "Fizz";
        //}

        public virtual string Print(Counter counter)
        {
            if (_fizzPredicate.Matches(counter) && _buzzPredicate.Matches(counter))
                return "FizzBuzz";
            if (_buzzPredicate.Matches(counter))
                return "Buzz";
            return "Fizz";
        }

        public FizzBuzzPrinter()
        {

        }
    }
}