namespace mroed.trd.ovelse8
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

        public virtual bool Matches(Counter counter)
        {
            return (_fizzPredicate.Matches(counter) || _buzzPredicate.Matches(counter));
        }
        public FizzBuzzPredicate()
        {
        }
    }
}