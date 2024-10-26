namespace Domain.Common;


public abstract class AggregateRoot : Entity<Guid>
{
    protected AggregateRoot(){
        CreatedAt = DateTime.UtcNow;
    }
}
