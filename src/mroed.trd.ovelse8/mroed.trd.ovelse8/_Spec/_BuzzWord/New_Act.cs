namespace mroed.trd.ovelse8._Spec._BuzzWord
{
    public class New_Act : Base_Act
    {
        protected BuzzWord Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new BuzzWord();
        }
         
    }
}