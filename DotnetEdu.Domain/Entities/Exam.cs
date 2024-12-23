using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Properties for Exam lessons
public class Exam : Auditable
{
    public long LessonId { get; set; }
    public IEnumerable<ExamQuestion> Questions { get; set; }
}
