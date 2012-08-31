using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzBuzzPrinter.New.FizzAndBuzz.GivenOne
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubPredicates();
            StubFizzBuzzCounter();
        }

        private void StubFizzBuzzCounter()
        {
            FizzBuzzCounter.Stub(x => x.Value).Return(1);
        }

        private void StubPredicates()
        {
            FizzPredicate.Stub(x => x.Matches(Counter)).Return(true);
            BuzzPredicate.Stub(x => x.Matches(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }
}