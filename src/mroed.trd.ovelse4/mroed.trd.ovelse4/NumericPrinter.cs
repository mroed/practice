using System;

namespace mroed.trd.ovelse4
{
    public class NumericPrinter
    {
        public virtual string Print(Counter counter)
        {
            return Convert.ToString(counter.Value);
        }
    }
}