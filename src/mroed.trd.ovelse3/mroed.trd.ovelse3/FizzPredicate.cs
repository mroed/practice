namespace mroed.trd.ovelse3
{
    public class FizzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 3 == 0);
        }
    }
}