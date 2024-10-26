namespace Domain.Aggregates.Enrollment;



public class Enrollment : AggregateRoot
{
    private readonly List<LessonProgress> _lessonProgresses = new();

    public Guid UserId { get; private set; }
    public Guid CourseId { get; private set; }
    public DateTime EnrolledAt { get; private set; }
    public EnrollmentStatus Status { get; private set; }
    public DateTime? CompletedAt { get; private set; }

    public IReadOnlyCollection<LessonProgress> LessonProgresses => _lessonProgresses.AsReadOnly();
}
 
