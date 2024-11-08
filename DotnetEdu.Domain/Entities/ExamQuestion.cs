using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Question types for exams
public class ExamQuestion : Auditable
{
    public string QuestionText { get; set; }
    public IEnumerable<string> Options { get; set; }
    public int CorrectAnswerIndex { get; set; }
}
