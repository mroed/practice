﻿using NUnit.Framework;

namespace mroed.trd.ovelse8._Spec._FizzPredicate.New.IsDividableByThree
{
    [TestFixture]
    public class When_Matching : Match_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Should_Return_True()
        {
            Assert.IsTrue(Returned);
        }
    }
}