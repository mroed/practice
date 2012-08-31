using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter.New.FizzNotBuzz.GivenTwo
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(2);
        }

        //private void StubWordPrinter()
        //{
        //    WordPrinter.Stub(x => x.Print("Fizz", Counter));
        //}

        protected override void Act()
        {
            Returned = Sut.Print("Fizz 2 times!");
        }
         
    }
}