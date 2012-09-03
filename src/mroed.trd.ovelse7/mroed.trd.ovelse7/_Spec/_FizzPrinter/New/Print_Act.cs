using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzPrinter.New
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "word ";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubWordPrinter();
        }

        private void StubWordPrinter()
        {
            WordPrinter.Stub(x => x.Print("Fizz")).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}