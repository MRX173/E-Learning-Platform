using Domain.Common;
using Domain.Enums;

namespace Domain.Aggregates.Course;

public class Lesson : Entity<Guid>
{
    public Guid ModuleId { get; private set; }
    public string Title { get; private set; }
    public string Content { get; private set; }
    public LessonType Type { get; private set; }
    public int OrderIndex { get; private set; }
    public TimeSpan EstimatedDuration { get; private set; }
    public Quiz.Quiz Quiz { get; private set; }
}
