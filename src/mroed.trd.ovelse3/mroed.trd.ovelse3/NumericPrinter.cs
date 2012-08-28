using System;

namespace mroed.trd.ovelse3
{
    public class NumericPrinter
    {
         public virtual string Print(int number)
         {
             return Convert.ToString(number);
         }

         public virtual string Print(Counter counter)
         {
             throw new NotImplementedException();
         }
    }
}