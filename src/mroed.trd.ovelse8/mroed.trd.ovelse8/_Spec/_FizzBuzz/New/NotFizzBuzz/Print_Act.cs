using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzz.New.NotFizzBuzz
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubFizzBuzzPredicate();
            StubNumericPrinter();
        }

        private void StubFizzBuzzPredicate()
        {
            FizzBuzzPredicate.Stub(x => x.Matches(Counter)).Return(false);
        }

        private void StubNumericPrinter()
        {
            NumericPrinter.Stub(x => x.Print(Counter)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}