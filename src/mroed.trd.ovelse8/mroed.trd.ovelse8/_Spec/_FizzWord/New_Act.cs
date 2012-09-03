namespace mroed.trd.ovelse8._Spec._FizzWord
{
    public class New_Act : Base_Act
    {
        protected FizzWord Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzWord();
        }
         
    }
}