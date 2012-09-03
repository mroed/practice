namespace mroed.trd.ovelse8
{
    public class BuzzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}