namespace mroed.trd.ovelse3
{
    public interface Predicate<T>
    {
        bool Matches(T arg);
    }
}