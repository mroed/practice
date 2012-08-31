namespace mroed.trd.ovelse7
{
    public class BuzzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}