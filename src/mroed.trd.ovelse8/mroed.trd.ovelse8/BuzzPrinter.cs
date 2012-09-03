using System;

namespace mroed.trd.ovelse8
{
    public class BuzzPrinter
    {
        private readonly WordPrinter<BuzzWord> _buzzWord;

        public BuzzPrinter(WordPrinter<BuzzWord> buzzWord)
        {
            _buzzWord = buzzWord;
        }

        public virtual string Print()
        {
            return _buzzWord.Print();
        }

        public BuzzPrinter()
        {
            
        }
    }
}