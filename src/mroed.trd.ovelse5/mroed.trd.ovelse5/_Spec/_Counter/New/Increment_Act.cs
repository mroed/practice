namespace mroed.trd.ovelse5._Spec._Counter.New
{
    public class Increment_Act : New_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut.Increment();
        }
    }
}