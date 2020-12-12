using CashMachineApplication;
using FluentAssertions;
using NUnit.Framework;

namespace CashMachineTests
{
    [TestFixture(Category = "UnitTests")]
    public class AtmTests
    {

        [Test]
        public void WhenDepositIsCalledBalanceShouldBeIncreased()
        {
            // Arrange
            var expectedBalance = 1000;
            ATMBase atm = new ATM();
            
            // Act
            atm.Deposit(1000);
            
            // Assert
            atm.Balance.Should().Be(expectedBalance, "1000 was deposited to an empty balance");
        }
        
        [Test]
        public void WhenWithdrawIsCalledBalanceShouldBeDecreased()
        {
            // Arrange
            var expectedBalance = 1000;
            ATMBase atm = new ATM();
            atm.Deposit(2000);
            
            // Act
            atm.Withdraw(1000);
            
            // Assert
            atm.Balance.Should().Be(expectedBalance, "1000 was withdrawn from a balance of 2000");
        }
    }
}