using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPrinter.New.FizzAndBuzz
{
    public class Printing_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubPredicates();
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