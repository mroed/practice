namespace mroed.trd.ovelse7
{
    public class FizzAndBuzzPrinter
    {
        private readonly WordPrinter _wordPrinter;
        private const string FizzBuzz = "FizzBuzz";

        public FizzAndBuzzPrinter(WordPrinter wordPrinter)
        {
            _wordPrinter = wordPrinter;
        }

        public virtual string Print()
        {
            return _wordPrinter.Print(FizzBuzz);
        }

        public FizzAndBuzzPrinter()
        {
            
        }
    }
}