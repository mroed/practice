using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzPrinter Sut { get; set; }
        protected WordPrinter WordPrinter = MockRepository.GenerateStrictMock<WordPrinter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzPrinter(WordPrinter);
        }
    }
}