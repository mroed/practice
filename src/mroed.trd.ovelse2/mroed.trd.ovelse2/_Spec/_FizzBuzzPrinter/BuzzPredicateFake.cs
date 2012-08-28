using System;

namespace mroed.trd.ovelse2._Spec._FizzBuzzPrinter
{
    public class BuzzPredicateFake : BuzzPredicate
    {
        private bool _expected;
        private int _number;

        public override bool Matches(int number)
        {
            if (_number == number)
                return _expected;

            throw new InvalidOperationException();
        }

        public void MatchesShouldReturn(bool expected, int index)
        {
            _expected = expected;
            _number = index;
        }
    }
}