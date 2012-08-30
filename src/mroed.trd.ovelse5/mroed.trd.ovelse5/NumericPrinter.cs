using System;

namespace mroed.trd.ovelse5
{
    public class NumericPrinter
    {
        public virtual string Print(Counter counter)
        {
            return Convert.ToString(counter.Value);
        }
    }
}