using System;

namespace mroed.trd.ovelse2
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

        public virtual string Print(int number)
        {
            if (_fizzPredicate.Matches(number) && _buzzPredicate.Matches(number))
                return "FizzBuzz";
            if (_buzzPredicate.Matches(number))
                return "Buzz";
            return "Fizz";
        }

        public FizzBuzzPrinter()
        {

        }
    }
}