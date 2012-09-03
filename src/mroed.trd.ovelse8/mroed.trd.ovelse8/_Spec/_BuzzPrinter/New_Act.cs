using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._BuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected BuzzPrinter Sut { get; set; }
        protected WordPrinter<BuzzWord> WordPrinter = MockRepository.GenerateMock<WordPrinter<BuzzWord>>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new BuzzPrinter(WordPrinter);
        }
         
    }
}