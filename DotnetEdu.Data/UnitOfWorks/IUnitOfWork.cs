using DotnetEdu.Data.Repositores;
using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Data.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IRepository<Category> Categories { get; }
    IRepository<Course> Courses { get; }
    IRepository<Module> Modules { get; }
    IRepository<Section> Sections { get; }
    IRepository<Lesson> Lessons { get; }

    IRepository<Article> Articles { get; }
    IRepository<Quiz> Quiz { get; }
    IRepository<Exam> Exam { get; }

    IRepository<ExamQuestion> ExamQuestions { get; }
    IRepository<QuizQuestion> QuizQuestions { get; }
}
