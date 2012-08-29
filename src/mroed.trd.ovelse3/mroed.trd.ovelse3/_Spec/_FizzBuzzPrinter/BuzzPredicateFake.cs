using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter
{
    public class BuzzPredicateFake : BuzzPredicate
    {
        private bool _expected;
        private Counter _counter;

        public override bool Matches(Counter counter)
        {
            if (_counter == counter)
                return _expected;

            throw new InvalidOperationException();
        }

        public void MatchesShouldReturn(bool expected, Counter counter)
        {
            _expected = expected;
            _counter = counter;
        }
    }
}