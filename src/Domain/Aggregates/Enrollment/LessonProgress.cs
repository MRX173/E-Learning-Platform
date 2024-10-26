using Domain.Common;
using Domain.Enums;

namespace Domain.Aggregates.Enrollment;



public class LessonProgress : Entity<Guid>
{

    public Guid EnrollmentId { get; private set; }
    public Guid LessonId { get; private set; }
    public LessonProgressStatus Status { get; private set; }
    public DateTime? StartedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
} 
