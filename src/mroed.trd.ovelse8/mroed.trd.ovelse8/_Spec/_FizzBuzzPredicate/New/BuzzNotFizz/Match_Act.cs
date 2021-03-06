﻿using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPredicate.New.BuzzNotFizz
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
            FizzPredicate.Stub(x => x.Matches(Counter)).Return(false);
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