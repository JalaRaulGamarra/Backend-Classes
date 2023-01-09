using ATMSystem.Controller;
using ATMSystem.Model;

namespace ATMSystemTests
{
    [TestClass]
    public class AccountTest
    {
        Account account = new();
        
        [TestMethod]
        // Debe agregarse un deposito cuando el monto es multiplo de diez
        public void ShouldAddADepositWhenTheAmountIsAMultipleOfTen()
        {
            this.account.Deposit(100);
            var actual = account.GetOperations(100);
            var expected = 1;

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        // Debe cachar una excepcion cuando el monto no es multiplo de diez
        public void ShouldCatchAnExceptionWhenTheAmountIsNotAMultipleOfTen()
        {
            Assert.ThrowsException<Exception>(() => { account.Deposit(25); } );
        }

        [TestMethod]
        // Deber retirar un monto cuando el monto es igual al balance 
        public void ShouldWithdrawAnAmountWhenTheAmountIsEqualThanTheBalance()
        {
            this.account.Deposit(100);
            this.account.Withdraw(99);
            var actual = account.GetOperations(99);
            var expected = 2;

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        // Debe retirar un monto cuando el monto es menor al balance 
        public void ShouldWithdrawAnAmountWhenTheAmountIsLessThanTheBalance()
        {
            this.account.Deposit(50);
            this.account.Withdraw(40);
            var actual = this.account.GetOperations(30);
            var expected = 2;

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        // Debe captar una excepcion cuando el monto es mayor al balance 
        public void ShouldCatchAnExceptionWhenTheAmountIsHigherThanTheBalance()
        {
            this.account.Deposit(100);
            Assert.ThrowsException<Exception>(() => { account.Withdraw(200); });
        }

        [TestMethod]
        // Debe devolver una lista de operaciones filtrado con el valor del monto
        public void ShouldReturnAListOfOperationsFilteredWithTheValueOfTheAmount()
        {
            this.account.Deposit(50);
            var actual = this.account.GetOperations(50);
            var expected = 1;

            Assert.AreEqual(expected, actual.Count);
        }
        
        [TestMethod]
        // Debe devolver una lista de operaciones filtrado con el valor del monto y el tipo de operacion deposito
        public void ShouldReturnAListOfFilteredOperationsWithTheValueOfTheAmountAndTheTypeOfOperationDeposit()
        {
            this.account.Deposit(60);
            this.account.Withdraw(30);
            var actual = this.account.GetOperations(60, OperationType.Deposit);
            var expected = 1;

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        // Debe devolver una lista de operaciones filtrado con el valor del monto y el tipo de operacion Withdraw
        public void ShouldReturnAListOfFilteredOperationsWithTheValueOfTheAmountAndTheTypeOfOperationWithdrawal()
        {
            this.account.Deposit(50);
            this.account.Withdraw(40);
            var actual = this.account.GetOperations(10, OperationType.Withdrawal);
            var expected = 0;

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        // Debe devolver el balance actual
        public void ShouldReturnTheCurrentBalance()
        {
            this.account.Deposit(70);
            this.account.Withdraw(50);
            var actual = this.account.GetBalance();
            var expected = 20;

            Assert.AreEqual(expected, actual);
        }
    }
}