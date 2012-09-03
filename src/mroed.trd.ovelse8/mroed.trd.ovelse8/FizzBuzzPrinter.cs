namespace mroed.trd.ovelse8
{
    public class FizzBuzzPrinter
    {
        private readonly FizzPredicate _fizzPredicate;
        private readonly BuzzPredicate _buzzPredicate;
        private readonly FizzPrinter _fizzPrinter;
        private readonly BuzzPrinter _buzzPrinter;
        private readonly FizzAndBuzzPrinter _fizzAndBuzzPrinter;

        private Counter _counter;
        private string _returnValue;


        public FizzBuzzPrinter(FizzPredicate fizzPredicate, BuzzPredicate buzzPredicate, FizzPrinter fizzPrinter, BuzzPrinter buzzPrinter, FizzAndBuzzPrinter fizzAndBuzzPrinter)
            //Counter fizzCounter, Counter buzzCounter, Counter fizzBuzzCounter, WordPrinter fizzPrinter, WordPrinter buzzPrinter, WordPrinter fizzBuzzPrinter)
        {
            _fizzPredicate = fizzPredicate;
            _buzzPredicate = buzzPredicate;
            _fizzPrinter = fizzPrinter;
            _buzzPrinter = buzzPrinter;
            _fizzAndBuzzPrinter = fizzAndBuzzPrinter;
        }

        public virtual string Print(Counter counter)
        {
            _counter = counter;
            if (TryPrintFizzBuzz() || TryPrintBuzz())
                return _returnValue;
            return PrintFizz();
        }

        private bool TryPrintFizzBuzz()
        {
            bool match = IsFizzAndBuzz();
            if (match)
                _returnValue = _fizzAndBuzzPrinter.Print();
            return match;
        }

        private bool TryPrintBuzz()
        {
            bool match = IsBuzz();
            if (match)
                _returnValue = _buzzPrinter.Print();
            return match;
        }

        private string PrintFizz()
        {
            _returnValue = _fizzPrinter.Print();
            return _returnValue;
        }
        
        private bool IsFizzAndBuzz()
        {
            return IsFizz() && IsBuzz();
        }

        private bool IsFizz()
        {
            return _fizzPredicate.Matches(_counter);
        }

        private bool IsBuzz()
        {
            return _buzzPredicate.Matches(_counter);
        }


        public FizzBuzzPrinter()
        {
        }
    }
}