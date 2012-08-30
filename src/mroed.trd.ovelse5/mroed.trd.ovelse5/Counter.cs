namespace mroed.trd.ovelse5
{
    public class Counter
    {
        public virtual void Increment()
        {
            Value++;
        }

        public virtual int Value { get; protected set; }
    }
}