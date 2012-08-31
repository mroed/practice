using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._BuzzPredicate.New.NotDividableByFive
{
    public class Match_Act : New_Act
    {
        protected bool Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounterWithFour();
        }

        private void StubCounterWithFour()
        {
            Counter.Stub(x => x.Value).Return(4);
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }
}