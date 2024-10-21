namespace Domain.Common;

public abstract class Entity
{
    public int Id { get; protected init; }
    private List<DomainEvent> _domainEvents = new ();
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public DateTime CreatedAt { get; protected set; }
    public DateTime? UpdatedAt { get; protected set; }
    
    protected void AddDomainEvent(DomainEvent domainEvent){
      _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents() => _domainEvents.Clear();
}
