using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzBuzzPrinter Sut { get; set; }
        protected FizzPredicate FizzPredicate = MockRepository.GenerateStrictMock<FizzPredicate>();
        protected BuzzPredicate BuzzPredicate = MockRepository.GenerateStrictMock<BuzzPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected FizzPrinter FizzPrinter = MockRepository.GenerateStrictMock<FizzPrinter>();
        protected BuzzPrinter BuzzPrinter = MockRepository.GenerateStrictMock<BuzzPrinter>();
        protected FizzAndBuzzPrinter FizzAndBuzzPrinter = MockRepository.GenerateStrictMock<FizzAndBuzzPrinter>();
        


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzBuzzPrinter(FizzPredicate, BuzzPredicate, FizzPrinter, BuzzPrinter, FizzAndBuzzPrinter);
        }


    }
}