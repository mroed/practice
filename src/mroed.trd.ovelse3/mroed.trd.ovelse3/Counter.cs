namespace mroed.trd.ovelse3
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