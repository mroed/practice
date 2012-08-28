using System;

namespace mroed.trd.ovelse3
{
    public class Counter
    {
        public virtual void Increment()
        {
            throw new NotImplementedException();
        }

        public virtual int Value { get; set; }
    }
}