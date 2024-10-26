using Domain.Common;

namespace Domain.Aggregates.Quiz;

public class Answer : Entity<Guid>
{
  public Guid QuestionId { get; private set; }
    public string Text { get; private set; }
    public bool IsCorrect { get; private set; }
}
