using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzz
{
    public class FizzBuzzPrinterFake : FizzBuzzPrinter
    {
        private string _expected;
        private int _number;
        private Counter _counter;

        public void PrintShouldReturn(string expected, int number)
        {
            _expected = expected;
            _number = number;
        }

        public void PrintShouldReturn(string expected, Counter counter)
        {
            _expected = expected;
            _counter = counter;
        }

        public override string Print(int number)
        {
            if (_number == number)
                return _expected;

            throw new InvalidOperationException();
        }

        public override string Print(Counter counter)
        {
            if (_counter == counter)
                return _expected;

            throw new InvalidOperationException();
        }
    }
}