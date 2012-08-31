using System;

namespace mroed.trd.ovelse7
{
    public class NumericPrinter
    {
        public virtual string Print(Counter counter)
        {
            return Convert.ToString(counter.Value);
        }
    }
}