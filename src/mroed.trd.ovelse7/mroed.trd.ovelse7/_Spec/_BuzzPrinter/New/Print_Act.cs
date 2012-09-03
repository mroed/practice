using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._BuzzPrinter.New
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "samme hva som står her!";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubWordPrinter();
        }

        private void StubWordPrinter()
        {
            BuzzPrinter.Stub(x => x.Print("Buzz")).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
         
    }
}