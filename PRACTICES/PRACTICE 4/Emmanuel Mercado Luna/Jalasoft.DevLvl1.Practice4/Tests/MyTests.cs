using Jalasoft.DevLvl1.Practice4;

namespace Tests
{
    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public void TestWhenSimpleDeposit()
        {
            Account myAccount = new Account(100);
            Operation deposit1 = new Operation(100, OperationTypes.Deposit, "Payment from Lucia");
            myAccount.Deposit(deposit1);

            Assert.AreEqual(200,myAccount.AccountBalance);
        }
    }
}