using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._FizzBuzzPrinter.New.BuzzNotFizz.GivenTwo
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubPredicates();
            StubBuzzCounter();
        }

        private void StubBuzzCounter()
        {
            BuzzCounter.Stub(x => x.Value).Return(2);
        }

        private void StubPredicates()
        {
            FizzPredicate.Stub(x => x.Matches(Counter)).Return(false);
            BuzzPredicate.Stub(x => x.Matches(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }
}