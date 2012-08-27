using System;

namespace mroed.trd.ovelse2._Spec._FizzBuzz
{
    public class FizzBuzzPrinterFake : FizzBuzzPrinter
    {
        private string _expected;
        private int _number;

        public void PrintShouldReturn(string expected, int number)
        {
            _expected = expected;
            _number = number;
        }

        public override string Print(int number)
        {
            if (_number == number)
                return _expected;

            throw new InvalidOperationException();
        }
    }
}