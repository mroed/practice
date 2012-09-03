using System;
using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzz
{
    public class New_Act : Base_Act
    {
        protected FizzBuzz Sut { get; set; }
        protected FizzBuzzPrinter FizzBuzzPrinter = MockRepository.GenerateStrictMock<FizzBuzzPrinter>();
        protected NumericPrinter NumericPrinter = MockRepository.GenerateStrictMock<NumericPrinter>();
        protected FizzBuzzPredicate FizzBuzzPredicate = MockRepository.GenerateStrictMock<FizzBuzzPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected readonly string Expected = Guid.NewGuid().ToString();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzBuzz(NumericPrinter, FizzBuzzPrinter, FizzBuzzPredicate, Counter);
        }
    }
}