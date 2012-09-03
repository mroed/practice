using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._Counter
{
    public class New_Act : Base_Act
    {
        //protected Counter Sut = MockRepository.GenerateStrictMock<Counter>();
        protected Counter Sut { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new Counter();
        }
    }
}