﻿using NUnit.Framework;
using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzBuzzPrinter.New.BuzzNotFizz.GivenTwo
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
        public void Should_Return_Buzz()
        {
            Assert.AreEqual(Expected, Returned);
        }
    }
}