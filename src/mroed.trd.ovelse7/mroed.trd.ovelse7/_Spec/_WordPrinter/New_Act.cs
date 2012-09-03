using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter
{
    public class New_Act : Base_Act
    {
        protected WordPrinter Sut { get; set; }
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        //protected Counter FizzCounter = MockRepository.GenerateMock<Counter>();
        //protected Counter BuzzCounter = MockRepository.GenerateMock<Counter>();
        //protected Counter FizzBuzzCounter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }
        
        protected override void Act()
        {
            Sut = new WordPrinter(Counter);
        }
    }
}