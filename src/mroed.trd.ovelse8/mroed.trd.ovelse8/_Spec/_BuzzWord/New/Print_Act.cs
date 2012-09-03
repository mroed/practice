namespace mroed.trd.ovelse8._Spec._BuzzWord.New
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "Buzz";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Value;
        }
         
    }
}