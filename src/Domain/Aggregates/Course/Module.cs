using Domain.Common;

namespace Domain.Aggregates.Course;

public class Module : Entity<Guid>
{
    private readonly List<Lesson> _lessons = new();
    
    public Guid CourseId { get; private set; }
    public string Title { get; private set; }
    public int OrderIndex { get; private set; }
    public IReadOnlyCollection<Lesson> Lessons => _lessons.AsReadOnly();
}
