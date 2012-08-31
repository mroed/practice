using System;

namespace mroed.trd.ovelse6
{
    public class FizzBuzz
    {
        private readonly NumericPrinter _numericPrinter;
        private readonly FizzBuzzPrinter _fizzBuzzPrinter;
        private readonly FizzBuzzPredicate _fizzBuzzPredicate;
        private readonly Counter _counter;
      

        public FizzBuzz(NumericPrinter numericPrinter, FizzBuzzPrinter fizzBuzzPrinter, FizzBuzzPredicate fizzBuzzPredicate, Counter counter)
        {
            _numericPrinter = numericPrinter;
            _fizzBuzzPrinter = fizzBuzzPrinter;
            _fizzBuzzPredicate = fizzBuzzPredicate;
            _counter = counter;
        }

        public String Print()
        {
            _counter.Increment();
            if (_fizzBuzzPredicate.Matches(_counter))
                return _fizzBuzzPrinter.Print(_counter);
            return _numericPrinter.Print(_counter);
        }
    }
}
