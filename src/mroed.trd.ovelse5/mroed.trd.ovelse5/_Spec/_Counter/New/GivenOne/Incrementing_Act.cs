namespace mroed.trd.ovelse5._Spec._Counter.New.GivenOne
{
    public class Incrementing_Act : New_Act
    {
        protected Counter Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Sut.Increment();
        }

        protected override void Act()
        {
            Returned = Sut;
        }
    }
}