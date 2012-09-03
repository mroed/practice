namespace mroed.trd.ovelse7
{
    public class WordPrinter
    {
        private readonly Counter _counter;
        
        public WordPrinter(Counter counter)
        {
            _counter = counter;
        }

        public virtual string Print(string word)
        {
            _counter.Increment();
            if (_counter.Value > 1)
                return word + " " + _counter.Value + " times!";
            return word;
        }

        public WordPrinter()
        {

        }
    }
}