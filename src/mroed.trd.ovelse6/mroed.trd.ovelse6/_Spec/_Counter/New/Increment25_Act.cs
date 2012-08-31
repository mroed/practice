namespace mroed.trd.ovelse6._Spec._Counter.New
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