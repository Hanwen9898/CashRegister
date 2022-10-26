namespace CashRegisterTest
{
	using CashRegister;
	using Xunit;

	public class CashRegisterTest
	{
		[Fact]
		public void Should_process_execute_printing()
		{
			//given
			var spyprinter = new SpyPrinter();
			var cashRegister = new CashRegister(spyprinter);
			var purchase = new Purchase();
			//when
			cashRegister.Process(purchase);
			//then
			Assert.True(spyprinter.Hasprint);
			//verify that cashRegister.process will trigger print
		}
	}
}
