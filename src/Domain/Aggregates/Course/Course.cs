using Domain.Common;
using Domain.Enums;

namespace Domain.Aggregates.Course;

public class Course : AggregateRoot
{
    private readonly List<Module> _modules = new();
    private readonly List<Enrollment.Enrollment> _enrollments = new();

    public string Title { get; private set; }
    public string Description { get; private set; }
    public Guid InstructorId { get; private set; }
    public Money Price { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime PublishedAt { get; private set; }
    public CourseStatus Status { get; private set; }

    public IReadOnlyCollection<Module> Module => _modules;
    public IReadOnlyCollection<Enrollment.Enrollment> Enrollments => _enrollments.AsReadOnly();
}
