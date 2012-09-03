using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzAndBuzzPrinter.New
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "noen ord";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubWordPrinter();
        }

        private void StubWordPrinter()
        {
            WordPrinter.Stub(x => x.Print("FizzBuzz")).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}