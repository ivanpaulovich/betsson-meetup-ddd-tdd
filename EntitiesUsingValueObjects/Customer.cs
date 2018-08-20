public class Customer : IEntity
{
    public int Id { get; set; }
    public FirstName FirstName { get; set; }
    public LastName LastName { get; set; }
    public Personnummer Personnummer { get; set; }
    public Email Email { get; set; }
}

