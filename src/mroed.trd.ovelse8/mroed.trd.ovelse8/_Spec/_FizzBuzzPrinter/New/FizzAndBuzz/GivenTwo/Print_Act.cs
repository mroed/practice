using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPrinter.New.FizzAndBuzz.GivenTwo
{
    public class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "FizzBuzz 2 times!";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubFizzAndBuzzPrinter();
            StubPredicates();
            //StubFizzBuzzCounter();
        }

        //private void StubFizzBuzzCounter()
        //{
        //    FizzBuzzCounter.Stub(x => x.Value).Return(2);
        //}

        private void StubFizzAndBuzzPrinter()
        {
            FizzAndBuzzPrinter.Stub(x => x.Print()).Return(Expected);
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