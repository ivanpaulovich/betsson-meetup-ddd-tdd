public sealed class Account : IEntity, IAggregateRoot
{
    public Account(Guid customerId) {  }

    private Amount balance;

    public void Deposit(Amount amount) {
        balance = amount;
    }

    public Amount GetCurrentBalance() {
        return balance;
    }
}

