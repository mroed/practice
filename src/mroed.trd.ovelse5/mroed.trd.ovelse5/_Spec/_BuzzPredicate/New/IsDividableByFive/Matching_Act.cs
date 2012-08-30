﻿using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._BuzzPredicate.New.IsDividableByFive
{
    public class Matching_Act : New_Act
    {
        protected bool Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounterWithFive();
        }

        private void StubCounterWithFive()
        {
            Counter.Stub(x => x.Value).Return(5);
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Counter);
        }

    }
}