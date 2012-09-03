using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzBuzzPrinter.New.BuzzNotFizz.GivenOne
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "Buzz";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubBuzzPrinter();
            StubPredicates();
        }

        private void StubBuzzPrinter()
        {
            BuzzPrinter.Stub(x => x.Print()).Return(Expected);
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