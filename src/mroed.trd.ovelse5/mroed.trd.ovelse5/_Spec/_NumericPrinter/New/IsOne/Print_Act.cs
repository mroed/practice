using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._NumericPrinter.New.IsOne
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        private const int counterValue = 1;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(counterValue);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }
}