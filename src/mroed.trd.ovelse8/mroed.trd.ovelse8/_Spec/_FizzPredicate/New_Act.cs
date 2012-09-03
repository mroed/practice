using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzPredicate
{
    public class New_Act : Base_Act
    {
        protected FizzPredicate Sut { get; set; }
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzPredicate();
        }
    }
}