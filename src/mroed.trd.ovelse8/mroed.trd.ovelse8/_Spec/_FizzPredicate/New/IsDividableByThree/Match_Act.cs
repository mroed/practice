using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzPredicate.New.IsDividableByThree
{
    public class Match_Act : New_Act
    {
        protected bool Returned;
        private const int CounterValue = 3;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(CounterValue);
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }
}