/** 
 * Unit Tests
 * lufer
 * POO - 2024
 * 
 * Test method requirements
 * - A test method must meet the following requirements:
 * - It's decorated with the [TestMethod] attribute.
 * - It returns void.
 * - It cannot have parameters.
 * 
 * Pattern: Arrange | Act | Assert
 * Ver: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Testar classes da Aula 1
using Aula_1;

namespace BankAccountTestNS
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void DebitWithValidAmountUpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void DebitWhenAmountIsLessThanZeroShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void DebitWhenAmountIsMoreThanBalanceShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]        
        public void DebitWhenAmountIsMoreThanBalanceShouldThrowArgumentOutOfRange_II()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Lufer", beginningBalance);
            try
            {
                // Act
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 5, 8)]
        public void AdditionTest(int a, int b, int result)
        {
            Assert.AreEqual(result, a + b);
        }
    }


}
