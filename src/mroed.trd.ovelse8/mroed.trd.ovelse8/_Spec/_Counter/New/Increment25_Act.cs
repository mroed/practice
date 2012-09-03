namespace mroed.trd.ovelse8._Spec._Counter.New
{
    public class Increment25_Act : New_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            for (int i = 0; i < 25; i++)
            {
                Sut.Increment();
            }

        }
    }
}