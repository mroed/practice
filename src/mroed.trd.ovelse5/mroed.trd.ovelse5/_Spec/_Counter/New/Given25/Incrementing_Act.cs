namespace mroed.trd.ovelse5._Spec._Counter.New.Given25
{
    public class Incrementing_Act : New_Act
    {
        protected Counter Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            IncrementCounter();
        }

        private void IncrementCounter()
        {
            for (int i = 0; i < 25; i++)
            {
                Sut.Increment();
            }
        }

        protected override void Act()
        {
            Returned = Sut;
        }
    }
}