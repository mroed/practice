using System;

namespace mroed.trd.ovelse2._Spec._FizzBuzz
{
    public class FizzBuzzPredicateFake : FizzBuzzPredicate
    {
        private bool _returnValue;
        private int _index;

        public override bool Matches(int number)
        {
            if (_index == number)
                return _returnValue;

            throw new InvalidOperationException();
        }
        
        public void MatchesShouldReturn(bool returnValue, int index)
        {
            _returnValue = returnValue;
            _index = index;
        }
    }
}