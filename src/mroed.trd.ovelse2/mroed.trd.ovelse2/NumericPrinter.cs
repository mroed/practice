using System;

namespace mroed.trd.ovelse2
{
    public class NumericPrinter
    {
         public virtual string Print(int number)
         {
             return Convert.ToString(number);
         }
    }
}