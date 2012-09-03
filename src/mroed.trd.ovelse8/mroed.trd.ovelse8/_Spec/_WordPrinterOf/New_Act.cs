using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._WordPrinterOf
{
    public class New_Act : Base_Act
    {
        protected WordPrinter<Word> Sut; 
        protected WordPrinter InnerPrinter = MockRepository.GenerateMock<WordPrinter>();
        protected Word Word = MockRepository.GenerateMock<Word>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new WordPrinter<Word>(Word, InnerPrinter);
        }
         
    }
}