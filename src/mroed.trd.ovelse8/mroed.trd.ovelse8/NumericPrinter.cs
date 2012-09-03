using System;

namespace mroed.trd.ovelse8
{
    public class NumericPrinter
    {
        public virtual string Print(Counter counter)
        {
            return Convert.ToString(counter.Value);
        }
    }
}