namespace mroed.trd.ovelse8._Spec._FizzBuzzWord
{
    public class New_Act : Base_Act
    {
        protected FizzBuzzWord Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzBuzzWord();
        }
         
    }
}