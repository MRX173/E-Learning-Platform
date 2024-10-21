namespace Domain.Common;


public abstract class DomainEvent
{
    protected DomainEvent()
    {
        OccurredOn = DateTime.UtcNow;
        Id = Guid.NewGuid();
    }
    public DateTime OccurredOn { get; }
    public Guid Id { get; }
}
