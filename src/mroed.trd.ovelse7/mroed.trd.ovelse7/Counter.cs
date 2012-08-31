namespace mroed.trd.ovelse7
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