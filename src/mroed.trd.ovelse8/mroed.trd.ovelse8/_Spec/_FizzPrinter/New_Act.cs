using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzPrinter Sut { get; set; }
        protected WordPrinter<FizzWord> WordPrinter = MockRepository.GenerateStrictMock<WordPrinter<FizzWord>>();

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