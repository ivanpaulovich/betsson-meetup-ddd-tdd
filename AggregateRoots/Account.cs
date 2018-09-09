public sealed class Account : IEntity, IAggregateRoot
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public TransactionCollection Transactions { get; private set; }

    public Account(Guid customerId)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        Transactions = new TransactionCollection();
    }

    public void Deposit(Amount amount) { ... }
    public void Withdraw(Amount amount) { ... }
    public void Close() { ... }
    public Amount GetCurrentBalance() { ... }
    public ITransaction GetLastTransaction() { ... }

    private Account() { }

    public static Account LoadFromDetails(Guid id, Guid customerId, TransactionCollection transactions) { ... }
}


