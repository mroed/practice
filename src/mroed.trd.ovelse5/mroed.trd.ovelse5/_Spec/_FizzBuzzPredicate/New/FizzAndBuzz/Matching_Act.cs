﻿using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._FizzBuzzPredicate.New.FizzAndBuzz
{
    public class Matching_Act : New_Act
    {
        protected bool Returned;// { get; set; }

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
            BuzzPredicate.Stub(x => x.Matches(Counter)).Return(true);           
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }
    }
}