using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzzPrinter
{
    public class BuzzPredicateFake : BuzzPredicate
    {
        private bool _expected;
        private int _number;
        private Counter _counter;

        //TODO remove int method
        //public override bool Matches(int number)
        //{
        //    if (_number == number)
        //        return _expected;

        //    throw new InvalidOperationException();
        //}

        public override bool Matches(Counter counter)
        {
            if (_counter == counter)
                return _expected;

            throw new InvalidOperationException();
        }

        //TODO remove int method
        //public void MatchesShouldReturn(bool expected, int index)
        //{
        //    _expected = expected;
        //    _number = index;
        //}

        public void MatchesShouldReturn(bool expected, Counter counter)
        {
            _expected = expected;
            _counter = counter;
        }
    }
}