namespace mroed.trd.ovelse2
{
    public interface Predicate<T>
    {
        bool Matches(T arg);
    }
}