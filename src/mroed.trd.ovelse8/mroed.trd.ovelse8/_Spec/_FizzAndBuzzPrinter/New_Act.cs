using Rhino.Mocks;

namespace mroed.trd.ovelse8._Spec._FizzAndBuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzAndBuzzPrinter Sut { get; set; }
        protected WordPrinter<FizzBuzzWord> WordPrinter = MockRepository.GenerateStrictMock<WordPrinter<FizzBuzzWord>>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FizzAndBuzzPrinter(WordPrinter);
        }
         
    }
}