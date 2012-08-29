namespace mroed.trd.ovelse3._Spec
{
    public class CounterFake : Counter
    {
        public override void Increment()
        {
            Value++;
        }
        public void SetValue(int value)
        {
            Value = value;
        }
        
    }
}