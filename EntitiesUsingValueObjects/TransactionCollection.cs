public sealed class TransactionCollection
{
    private readonly IList<ITransaction> _transactions;

    public TransactionCollection()
    {
        _transactions = new List<ITransaction>();
    }

    public void Add(ITransaction transaction) { ... }
    public void Add(IEnumerable<ITransaction> transactions) { ... }
    public Amount GetBalance() { ... }
    
    public IReadOnlyCollection<ITransaction> ToReadOnlyCollection() { ... }
    public ITransaction CopyOfLastTransaction() { ... }
}


