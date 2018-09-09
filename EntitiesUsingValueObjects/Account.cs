public sealed class Account : IEntity, IAggregateRoot
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public TransactionCollection Transactions { get; private set; }

    public Account(Guid customerId) { ... }

    public void Withdraw(Amount amount)
    {
        Amount balance = Transactions.GetBalance();

        if (balance < amount)
            throw new InsuficientFundsException(
            $"The account {Id} does not have enough funds to withdraw {amount}. Current Balance {balance}.");

        Debit debit = new Debit(Id, amount);
        Transactions.Add(debit);
    }

    public void Deposit(Amount amount) { ... }
}

