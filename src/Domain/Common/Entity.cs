namespace Domain.Common;

public abstract class Entity<IId> where IId : IEquatable<IId>
{
    public IId Id { get; protected init; }
    private List<DomainEvent> _domainEvents = new ();
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public DateTime CreatedAt { get; protected set; }
    public DateTime? UpdatedAt { get; protected set; }
    

    public static IEqualityComparer<Entity<IId>> IdEqualityComparer =>
      EqualityComparer<Entity<IId>>.Create((x, y) =>
          x is null ? y is null
          : y is not null && x.GetType() == y.GetType() && x.Id.Equals(y.Id));
    protected void AddDomainEvent(DomainEvent domainEvent){
      _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents() => _domainEvents.Clear();


}
