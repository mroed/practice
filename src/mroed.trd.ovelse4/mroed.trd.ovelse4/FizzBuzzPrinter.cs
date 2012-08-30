namespace mroed.trd.ovelse4
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