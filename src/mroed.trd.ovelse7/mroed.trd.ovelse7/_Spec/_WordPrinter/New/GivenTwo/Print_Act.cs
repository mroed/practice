using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter.New.GivenTwo
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

        protected override void Act()
        {
            Returned = Sut.Print("Fizz");
        }
         
    }
}