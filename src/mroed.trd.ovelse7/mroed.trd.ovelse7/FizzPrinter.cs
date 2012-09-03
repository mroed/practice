namespace mroed.trd.ovelse7
{
    public class FizzPrinter
    {
        private readonly WordPrinter _wordPrinter;
        private const string Fizz = "Fizz";

        public FizzPrinter(WordPrinter wordPrinter)
        {
            _wordPrinter = wordPrinter;
        }

        public virtual string Print()
        {
            return _wordPrinter.Print(Fizz);
        }

        public FizzPrinter()
        {

        }
    }
}