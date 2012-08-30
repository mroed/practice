namespace mroed.trd.ovelse4
{
    public class BuzzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}