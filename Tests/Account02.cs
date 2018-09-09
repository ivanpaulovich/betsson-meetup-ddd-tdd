public sealed class Account : IEntity, IAggregateRoot
{
    public Account(Guid customerId) {  }

    public void Deposit(Amount amount) {
        Credit credit = new Credit(Id, amount);
        Transactions.Add(credit);
    }

    public Amount GetCurrentBalance() {
        Amount balance = Transactions.GetBalance();
        return balance;
    }
}

