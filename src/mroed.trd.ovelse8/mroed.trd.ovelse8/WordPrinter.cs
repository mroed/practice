namespace mroed.trd.ovelse8
{
    public class WordPrinter
    {
        private readonly Counter _counter;
        
        public WordPrinter(Counter counter)
        {
            _counter = counter;
        }

        public virtual string Print(Word word)
        {
            _counter.Increment();
            if (_counter.Value > 1)
                return word.Value + " " + _counter.Value + " times!";
            return word.Value;
        }

        //public virtual string Print(string word)
        //{
        //    _counter.Increment();
        //    if (_counter.Value > 1)
        //        return word + " " + _counter.Value + " times!";
        //    return word;
        //}

        public WordPrinter()
        {

        }
    }
}