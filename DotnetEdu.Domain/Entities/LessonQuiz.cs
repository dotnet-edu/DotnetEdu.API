using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Properties for Quiz lessons
public class LessonQuiz : Auditable
{
    public IEnumerable<QuizQuestion> Questions { get; set; }
}
