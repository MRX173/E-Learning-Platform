using Domain.Common;
using Domain.Enums;

namespace Domain.Aggregates.Payment;
  


public class Payment : AggregateRoot
{

   public Guid UserId { get; private set; }
    public Guid CourseId { get; private set; }
    public Money Amount { get; private set; }
    public PaymentStatus Status { get; private set; }
    public string TransactionId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
}
