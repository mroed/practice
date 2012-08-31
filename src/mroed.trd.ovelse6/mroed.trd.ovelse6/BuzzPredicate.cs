namespace mroed.trd.ovelse6
{
    public class BuzzPredicate
    {
        public virtual bool Matches(Counter counter)
        {
            return (counter.Value % 5 == 0);
        }
    }
}