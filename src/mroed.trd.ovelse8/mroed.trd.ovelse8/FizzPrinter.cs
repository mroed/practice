namespace mroed.trd.ovelse8
{
    public class FizzPrinter
    {
        private readonly WordPrinter<FizzWord> _fizzWord;
        //private const string Fizz = "Fizz";

        public FizzPrinter(WordPrinter<FizzWord> fizzWord)
        {
            _fizzWord = fizzWord;
        }

        public virtual string Print()
        {
            return _fizzWord.Print();
        }

        public FizzPrinter()
        {

        }
    }
}