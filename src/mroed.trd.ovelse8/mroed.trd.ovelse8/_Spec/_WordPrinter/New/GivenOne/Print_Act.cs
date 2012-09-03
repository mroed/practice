using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._WordPrinter.New.GivenOne
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected string Expected = "Buzz";
        private const string WordValue = "Buzz";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
            StubWordPrinter();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(1);
        }

        private void StubWordPrinter()
        {
            Word.Stub(x => x.Value).Return(WordValue);

        }

        protected override void Act()
        {
            Returned = Sut.Print(Word);
        }
         
    }
}