namespace mroed.trd.ovelse7
{
    public class BuzzPrinter
    {
        private readonly WordPrinter _wordPrinter;
        private const string Buzz = "Buzz";


        public BuzzPrinter(WordPrinter printer)
        {
            _wordPrinter = printer;
        }

        public virtual string Print()
        {
            return _wordPrinter.Print(Buzz);
        }

        public BuzzPrinter()
        {
            
        }
    }
}