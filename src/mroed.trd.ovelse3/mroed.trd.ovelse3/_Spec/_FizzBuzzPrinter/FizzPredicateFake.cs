using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter
{
    public class FizzPredicateFake : FizzPredicate
    {
        private bool _expected;
        private int _index;
        private Counter _counter;

        public override bool Matches(int number)
        {
            if (_index == number)
                return _expected;

            throw new InvalidOperationException();
        }

        public override bool Matches(Counter counter)
        {
            if (_counter == counter)
                return _expected;
            throw new InvalidOperationException();
        }

        public void MatchesShouldReturn(bool expected, int index)
        {
            _expected = expected;
            _index = index;
        }

        public void MatchesShouldReturn(bool expected, Counter counter)
        {
            _expected = expected;
            _counter = counter;
        }
    }
}