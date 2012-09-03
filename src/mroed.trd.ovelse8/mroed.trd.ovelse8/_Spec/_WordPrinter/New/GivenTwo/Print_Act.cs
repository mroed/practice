using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._WordPrinter.New.GivenTwo
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "Fizz 2 times!";
        private const string WordValue = "Fizz";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
            StubWord();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(2);
        }

        private void StubWord()
        {
            Word.Stub(x => x.Value).Return(WordValue);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Word);
        }
         
    }
}