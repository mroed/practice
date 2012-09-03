namespace mroed.trd.ovelse8
{
    public class FizzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 3 == 0);
        }
    }
}