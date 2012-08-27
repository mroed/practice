using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mroed.trd.ovelse2
{
    public class FizzBuzz
    {
        private readonly NumericPrinter _numericPrinter;
        private readonly FizzBuzzPrinter _fizzBuzzPrinter;
        private readonly FizzBuzzPredicate _fizzBuzzPredicate;
        private int _counter = 0;

        public FizzBuzz(NumericPrinter numericPrinter, FizzBuzzPrinter fizzBuzzPrinter, FizzBuzzPredicate fizzBuzzPredicate)
        {
            _numericPrinter = numericPrinter;
            _fizzBuzzPrinter = fizzBuzzPrinter;
            _fizzBuzzPredicate = fizzBuzzPredicate;
        }

        public String Print()
        {
            _counter++;
            if (_fizzBuzzPredicate.Matches(_counter))
                return _fizzBuzzPrinter.Print(_counter);
            return _numericPrinter.Print(_counter);

        }

    }
}
