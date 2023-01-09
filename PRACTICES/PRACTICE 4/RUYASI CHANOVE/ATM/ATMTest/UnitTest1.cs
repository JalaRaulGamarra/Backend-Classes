using System.Security.Principal;

namespace ATMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DepositTest()
        {
            double initialBalance = 1500, extra = 500;

            Account ac = new Account(initialBalance);
            ac.Deposit(extra);
            Assert.AreEqual(ac.AccountBalance, initialBalance + extra);
        }
        [TestMethod]
        public void WithdrawTest()
        {
            double initialBalance = 1500, withdrawing = 500;

            Account ac = new Account(initialBalance);
            ac.Withdraw(withdrawing);
            Assert.AreEqual(ac.AccountBalance, initialBalance - withdrawing);
        }


        //    [TestMethod]
        //    public void ShowOperationsTest()
        //    {
        //        Account ac = new Account(1000);
        //            Console.WriteLine(ac.Op.ToString());

        //    }

        //}
        [TestMethod]
        public void ShowBalanceTest()
        {
            Account ac = new Account(1000);
            Assert.AreEqual(ac.ShowBalance(), "The current balance is: 1000");
        }
    }

}