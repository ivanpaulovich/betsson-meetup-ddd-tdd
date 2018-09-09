public sealed class Account : IEntity, IAggregateRoot
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public TransactionCollection Transactions { get; private set; }

    public Account(Guid customerId) { ... }

    public void Deposit(Amount amount)
    {
        Credit credit = new Credit(Id, amount);
        Transactions.Add(credit);
    }

    public Amount GetCurrentBalance()
    {
        Amount balance = Transactions.GetBalance();
        return balance;
    }
}

