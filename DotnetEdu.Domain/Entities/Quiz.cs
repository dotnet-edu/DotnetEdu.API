using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Properties for Quiz lessons
public class Quiz : Auditable
{
    public long LessonId { get; set; }
    public IEnumerable<QuizQuestion> Questions { get; set; }
}
