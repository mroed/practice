namespace mroed.trd.ovelse6
{
    public class Counter
    {
        public virtual void Increment()
        {
            Value++;
        }

        public virtual int Value { get; private set; }
    }
}