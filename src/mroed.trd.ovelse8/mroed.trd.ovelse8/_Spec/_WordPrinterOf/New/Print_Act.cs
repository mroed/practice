using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._WordPrinterOf.New
{
    public class Print_Act : New_Act
    {
        protected string Result;
        protected string WordValue = "trallala";
        protected string Expected = "expect";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubWord();
            StubInnerPrinter();
        }

        private void StubWord()
        {
            Word.Stub(x => x.Value).Return(WordValue);
        }

        private void StubInnerPrinter()
        {
            InnerPrinter.Stub(x => x.Print(Word)).Return(Expected);
        }


        protected override void Act()
        {
            Result = Sut.Print();
        }
    }
}