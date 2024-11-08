using DotnetEdu.Domain.Commons;
using DotnetEdu.Domain.Enums;

namespace DotnetEdu.Domain.Entities;

// Lessons representing learning content, with various types like articles, quizzes, and exams
public class Lesson : Auditable
{
    public LessonType Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation properties for different lesson types
    public LessonArticle Article { get; set; }
    public LessonQuiz Quiz { get; set; }
    public LessonExam Exam { get; set; }
}
