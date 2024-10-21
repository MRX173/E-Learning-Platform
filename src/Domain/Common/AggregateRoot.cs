namespace Domain.Common;
  public abstract class AggregateRoot : Entity
{
    
    protected AggregateRoot(){
        CreatedAt = DateTime.UtcNow;
    }
}

 
