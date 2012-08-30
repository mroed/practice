namespace mroed.trd.ovelse5._Spec._Counter.New.Given0
{
    public class Incrementing_Act : New_Act
    {
        protected Counter Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut;
        }
    }
}