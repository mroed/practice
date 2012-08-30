namespace mroed.trd.ovelse5
{
    public class FizzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 3 == 0);
        }
    }
}