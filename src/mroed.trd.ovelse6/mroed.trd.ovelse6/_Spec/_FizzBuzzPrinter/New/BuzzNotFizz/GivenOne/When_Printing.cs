﻿using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._FizzBuzzPrinter.New.BuzzNotFizz.GivenOne
{
    [TestFixture]
    public class When_Printing : Print_Act
    {
        [TestFixtureSetUp]
        public void BeforeAll()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Increment_First()
        {
            BuzzCounter.AssertWasCalled(x => x.Increment());
        }

        [Test]
        public void Should_Return_Buzz()
        {
            Assert.AreEqual("Buzz", Returned);
        }
    }
}