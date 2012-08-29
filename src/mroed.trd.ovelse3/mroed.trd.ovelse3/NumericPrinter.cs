using System;

namespace mroed.trd.ovelse3
{
    public class NumericPrinter
    {
        //TODO remove int method
        //public virtual string Print(int number)
        //{
        //    return Convert.ToString(number);
        //}
        
        public virtual string Print(Counter counter)
        {
            return Convert.ToString(counter.Value);
        }
    }
}