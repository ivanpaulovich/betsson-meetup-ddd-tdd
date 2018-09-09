[Fact]
public void Deposit_Should_Change_Balance_When_Account_Is_New()
{
    //
    // Arrange
    Guid expectedCustomerId = Guid.Parse("ac608347-74ac-4607-abc2-7b95cdc8a122");
    Amount expectedAmount = new Amount(400m);

    //
    // Act
    Account sut = new Account(expectedCustomerId);
    sut.Deposit(expectedAmount);
    Amount balance = sut.GetCurrentBalance();

    //
    // Assert
    Assert.Equal(expectedCustomerId, sut.CustomerId);
    Assert.Equal(expectedAmount, balance);
    Assert.Single(sut.Transactions.ToReadOnlyCollection());
}

[Fact]
public void Deposit_Should_Change_Balance_Equivalent_Amount()
{
    //
    // Arrange
    Guid expectedCustomerId = Guid.Parse("ac608347-74ac-4607-abc2-7b95cdc8a122");
    Amount expectedAmount = new Amount(400m);

    //
    // Act
    Account sut = new Account(expectedCustomerId);
    sut.Deposit(expectedAmount);
    Amount balance = sut.GetCurrentBalance();

    //
    // Assert
    Assert.Equal(expectedAmount, balance);
}

[Fact]
public void Deposit_Should_Add_Single_Transaction()
{
    //
    // Arrange
    Guid expectedCustomerId = Guid.Parse("ac608347-74ac-4607-abc2-7b95cdc8a122");
    Amount expectedAmount = new Amount(400m);

    //
    // Act
    Account sut = new Account(expectedCustomerId);
    sut.Deposit(expectedAmount);

    //
    // Assert
    Assert.Single(sut.Transactions.ToReadOnlyCollection());
}

[Fact]
public void NewAccount_Should_Return_The_Correct_CustomerId()
{
    //
    // Arrange
    Guid expectedCustomerId = Guid.Parse("ac608347-74ac-4607-abc2-7b95cdc8a122");
    Amount expectedAmount = new Amount(400m);

    //
    // Act
    Account sut = new Account(expectedCustomerId);

    //
    // Assert
    Assert.Equal(expectedCustomerId, sut.CustomerId);
}