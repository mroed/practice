using Rhino.Mocks;

namespace mroed.trd.ovelse7._Spec._WordPrinter.New.GivenOne
{
    public class Print_Act : New_Act
    {
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCounter();
        }

        private void StubCounter()
        {
            Counter.Stub(x => x.Value).Return(1);
        }

        //private void StubWordPrinter()
        //{
        //    //WordPrinter.Stub(x => x.Print("Fizz", Counter));
            
        //}

        protected override void Act()
        {
            Returned = Sut.Print("Buzz");
        }
         
    }
}