using Domain.Common;
using Domain.Enums;

namespace Domain.Aggregates.Quiz;


public class Question : Entity<Guid>
{
  private readonly List<Answer> _answers = new();
    public Guid QuizId { get; private set; }
    public string Text { get; private set; }
    public QuestionType Type { get; private set; }
    public IReadOnlyCollection<Answer> Answers => _answers.AsReadOnly();
}
 
