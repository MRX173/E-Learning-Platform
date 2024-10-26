using Domain.Common;

namespace Domain.Aggregates.Quiz;

public class Quiz : AggregateRoot
{
    private readonly List<Question> _questions = new();
    public Guid LessonId { get; private set; }
    public string Title { get; private set; }
    public decimal PassingScore { get; private set; }
    public IReadOnlyCollection<Question> Questions => _questions.AsReadOnly();
}
