using Rhino.Mocks;

namespace mroed.trd.ovelse5._Spec._BuzzPredicate.New
{
    public class New_Act : Base_Act
    {
        protected BuzzPredicate Sut { get; set; }
        protected Counter Counter = MockRepository.GenerateStrictMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new BuzzPredicate();
        }

    }
}