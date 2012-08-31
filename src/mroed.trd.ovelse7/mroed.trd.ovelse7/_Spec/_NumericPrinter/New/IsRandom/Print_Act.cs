using System;
using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._NumericPrinter.New.IsRandom
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected int RandomNumber;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
        }

        private void StubCounter()
        {
            var random = new Random();
            RandomNumber = random.Next();
            Counter.Stub(x => x.Value).Return(RandomNumber);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }
}