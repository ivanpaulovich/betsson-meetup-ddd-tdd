[Theory]
[InlineData(100)]
[InlineData(0)]
[InlineData(400)]
public void Deposit_Should_Change_Balance_The_Equivalent_Amount(decimal amountToDeposit)
{
    //
    // Arrange
    Guid customerId = Guid.NewGuid();
    Account sut = new Account(customerId);
    Amount amount = new Amount(amountToDeposit);

    //
    // Act
    sut.Deposit(amount);

    //
    // Assert
    Amount balance = sut.GetCurrentBalance();
    Assert.Equal(customerId, sut.CustomerId);
    Assert.Equal(amountToDeposit, (decimal)balance);
    Assert.Single(sut.Transactions.ToReadOnlyCollection());
}

