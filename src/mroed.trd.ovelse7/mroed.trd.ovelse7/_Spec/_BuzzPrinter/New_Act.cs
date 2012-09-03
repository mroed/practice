using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._BuzzPrinter
{
    public class New_Act : Base_Act
    {
        protected BuzzPrinter Sut { get; set; }
        protected WordPrinter BuzzPrinter = MockRepository.GenerateMock<WordPrinter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new BuzzPrinter(BuzzPrinter);
        }
         
    }
}