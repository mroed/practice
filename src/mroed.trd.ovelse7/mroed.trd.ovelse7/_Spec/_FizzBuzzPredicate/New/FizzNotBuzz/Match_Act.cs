using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzBuzzPredicate.New.FizzNotBuzz
{
    public class Match_Act : New_Act
    {
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubFizzPredicate();
            StubBuzzPredicate();
        }

        private void StubFizzPredicate()
        {
            FizzPredicate.Stub(x => x.Matches(Counter)).Return(true);
        }

        private void StubBuzzPredicate()
        {
            BuzzPredicate.Stub(x => x.Matches(Counter)).Return(false);           
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }
}