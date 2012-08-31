using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzz.New.IsFizzBuzz
{
    public class Print_Act : New_Act
    {
        protected string Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubFizzBuzzPredicate();
            StubFizzBuzzPrinter();
        }

        private void StubFizzBuzzPredicate()
        {
            FizzBuzzPredicate.Stub(x => x.Matches(Counter)).Return(true);
        }

        private void StubFizzBuzzPrinter()
        {
            FizzBuzzPrinter.Stub(x => x.Print(Counter)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}