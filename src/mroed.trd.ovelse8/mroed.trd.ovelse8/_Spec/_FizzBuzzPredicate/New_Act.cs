using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzBuzzPredicate
{
    public class New_Act : Base_Act
    {
        protected FizzBuzzPredicate Sut { get; set; }
        protected FizzPredicate FizzPredicate = MockRepository.GenerateStrictMock<FizzPredicate>();
        protected BuzzPredicate BuzzPredicate = MockRepository.GenerateStrictMock<BuzzPredicate>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzBuzzPredicate(FizzPredicate, BuzzPredicate);
        }
    }
}