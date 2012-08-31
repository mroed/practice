namespace mroed.trd.ovelse6
{
    public class FizzBuzzPrinter
    {
        private readonly FizzPredicate _fizzPredicate;
        private readonly BuzzPredicate _buzzPredicate;
        private readonly Counter _fizzCounter;
        private readonly Counter _buzzCounter;
        private readonly Counter _fizzBuzzCounter;
        private Counter _counter;
        private string _returnValue;


        public FizzBuzzPrinter(FizzPredicate fizzPredicate, BuzzPredicate buzzPredicate, Counter fizzCounter,
                               Counter buzzCounter, Counter fizzBuzzCounter)
        {
            _fizzPredicate = fizzPredicate;
            _buzzPredicate = buzzPredicate;
            _fizzCounter = fizzCounter;
            _buzzCounter = buzzCounter;
            _fizzBuzzCounter = fizzBuzzCounter;
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
                PrintWord("FizzBuzz",_fizzBuzzCounter);
            return match;
        }

        private bool TryPrintBuzz()
        {
            bool match = IsBuzz();
            if (match)
                PrintWord("Buzz",_buzzCounter);
            return match;
        }

        private string PrintFizz()
        {
            PrintWord("Fizz",_fizzCounter);
            return _returnValue;
        }

        private void PrintWord(string word, Counter counter)
        {
            counter.Increment();
            if (counter.Value > 1)
                _returnValue = word + " " + counter.Value + " times!";
            else
                _returnValue = word;            
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