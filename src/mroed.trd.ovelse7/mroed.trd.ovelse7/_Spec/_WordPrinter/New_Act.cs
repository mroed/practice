using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter
{
    public class New_Act : Base_Act
    {
        protected WordPrinter Sut { get; set; }
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        //protected WordPrinter WordPrinter = MockRepository.GenerateStub<WordPrinter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }
        
        

        protected override void Act()
        {
            Sut = new WordPrinter();
        }
    }
}