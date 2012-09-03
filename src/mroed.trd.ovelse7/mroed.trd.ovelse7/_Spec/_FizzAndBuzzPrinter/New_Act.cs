using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._FizzAndBuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected FizzAndBuzzPrinter Sut { get; set; }
        protected WordPrinter WordPrinter = MockRepository.GenerateStrictMock<WordPrinter>();

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