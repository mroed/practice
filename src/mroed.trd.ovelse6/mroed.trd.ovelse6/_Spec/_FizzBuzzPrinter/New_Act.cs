using Rhino.Mocks;

namespace mroed.trd.ovelse6._Spec._FizzBuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzBuzzPrinter Sut { get; set; }
        protected FizzPredicate FizzPredicate = MockRepository.GenerateStrictMock<FizzPredicate>();
        protected BuzzPredicate BuzzPredicate = MockRepository.GenerateStrictMock<BuzzPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Counter FizzCounter = MockRepository.GenerateMock<Counter>();
        protected Counter BuzzCounter = MockRepository.GenerateMock<Counter>();
        protected Counter FizzBuzzCounter = MockRepository.GenerateMock<Counter>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzBuzzPrinter(FizzPredicate, BuzzPredicate, FizzCounter, BuzzCounter, FizzBuzzCounter);
        }
    }
}