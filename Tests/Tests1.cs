[Fact]
public void Withdraw_Throws_InsuficientFundsException_When_Amount_Is_Bigger_Than_Balance()
{
    //
    // Arrange
    Account sut = new Account(Guid.NewGuid());
    sut.Deposit(200m);

    //
    // Act
    Exception ex = Record.Exception(() => sut.Withdraw(5000m));

    //
    // Assert
    Assert.NotNull(ex);
    Assert.IsType<InsuficientFundsException>(ex);
}