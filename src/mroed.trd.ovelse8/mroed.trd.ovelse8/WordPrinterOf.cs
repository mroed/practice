using System;

namespace mroed.trd.ovelse8
{
    public class WordPrinter<TWord> where TWord : Word
    {
        private readonly TWord _word;
        private readonly WordPrinter _innerPrinter;

        public WordPrinter(TWord word, WordPrinter innerPrinter)
        {
            _word = word;
            _innerPrinter = innerPrinter;
        }

        public virtual string Print()
        {
            return _innerPrinter.Print(_word);
        }

        public WordPrinter()
        {
        }
    }
}