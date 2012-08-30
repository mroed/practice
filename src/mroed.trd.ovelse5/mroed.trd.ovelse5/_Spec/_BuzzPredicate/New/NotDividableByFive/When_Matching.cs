﻿using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._BuzzPredicate.New.NotDividableByFive
{
    [TestFixture]
    public class When_Matching : Matching_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_False()
        {
            Assert.IsFalse(Returned);
        }
    }
}