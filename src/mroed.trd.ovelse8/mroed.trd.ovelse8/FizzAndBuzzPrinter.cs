namespace mroed.trd.ovelse8
{
    public class FizzAndBuzzPrinter
    {
        private readonly WordPrinter<FizzBuzzWord> _fizzBuzzWord;

        public FizzAndBuzzPrinter(WordPrinter<FizzBuzzWord> fizzBuzzWord)
        {
            _fizzBuzzWord = fizzBuzzWord;
        }

        public virtual string Print()
        {
            return _fizzBuzzWord.Print();
        }

        public FizzAndBuzzPrinter()
        {
            
        }
    }
}