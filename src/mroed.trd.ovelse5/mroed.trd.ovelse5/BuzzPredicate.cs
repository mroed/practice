namespace mroed.trd.ovelse5
{
    public class BuzzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}