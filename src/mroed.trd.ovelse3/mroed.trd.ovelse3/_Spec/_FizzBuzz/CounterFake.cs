using System;

namespace mroed.trd.ovelse3._Spec._FizzBuzz
{
    public class CounterFake : Counter
    {
        public override void Increment()
        {
            Value++;
        }

        public override int Value { get; set; }
    }
}