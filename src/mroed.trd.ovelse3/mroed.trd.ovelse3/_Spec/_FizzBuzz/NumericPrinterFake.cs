using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzz
{
    public class NumericPrinterFake : NumericPrinter
    {
        private string _expected;
        private Counter _counter;

        public void PrintShouldReturn(string expected, Counter counter)
        {
            _expected = expected;
            _counter = counter;
        }

        public override string Print(Counter counter)
        {
            if (_counter == counter)
                return _expected;
            throw new InvalidOperationException(string.Format("Expected: {0} but was {1}", _counter, counter));
        }
    }
}