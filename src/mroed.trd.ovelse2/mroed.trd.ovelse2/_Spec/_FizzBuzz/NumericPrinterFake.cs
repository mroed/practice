using System;

namespace mroed.trd.ovelse2._Spec._FizzBuzz
{
    public class NumericPrinterFake : NumericPrinter
    {
        private int _number;
        private string _expected;

        public void PrintShouldReturn(string expected, int number)
        {
            _expected = expected;
            _number = number;
        }

        public override string Print(int number)
        {
            if (_number == number)
                return _expected;
            throw new InvalidOperationException(string.Format("Expected: {0} but was {1}",_number,number));
        }
    }
}