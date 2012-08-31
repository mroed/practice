using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._FizzBuzzPrinter.New.FizzNotBuzz.GivenTwo
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubPredicates();
            StubFizzCounter();
        }

        private void StubFizzCounter()
        {
            FizzCounter.Stub(x => x.Value).Return(2);
        }

        private void StubPredicates()
        {
            FizzPredicate.Stub(x => x.Matches(Counter)).Return(true);
            BuzzPredicate.Stub(x => x.Matches(Counter)).Return(false);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }
}