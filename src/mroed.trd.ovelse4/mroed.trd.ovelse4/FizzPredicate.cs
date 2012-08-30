namespace mroed.trd.ovelse4
{
    public class FizzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 3 == 0);
        }
    }
}