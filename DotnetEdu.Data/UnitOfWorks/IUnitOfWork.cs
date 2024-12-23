using DotnetEdu.Data.Contexts;
using DotnetEdu.Data.Repositores;
using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Data.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IRepository<Category> Categories { get; }
    IRepository<Course> Courses { get; }
    IRepository<Module> CourseModules { get; }
    IRepository<Section> ModuleSections { get; }
    IRepository<Lesson> SectionLessons { get; }

    IRepository<Article> LessonArticles { get; }
    IRepository<Quiz> LessonQuiz { get; }
    IRepository<Exam> LessonExam { get; }

    IRepository<ExamQuestion> ExamQuestions { get; }
    IRepository<QuizQuestion> QuizQuestions { get; }
}
public class UnitOfWord : IDisposable
{
    public readonly AppDbContext context;

    public UnitOfWord(AppDbContext context)
    {
        this.context = context;
    }

    public IRepository<Category> Categories { get; }
    public IRepository<Course> Courses { get; }
    public IRepository<Module> CourseModule { get; }
    public IRepository<Section> ModuleSection { get; }
    public IRepository<Lesson> SectionLesson { get; }

    public IRepository<Article> LessonArticles { get; }
    public IRepository<Quiz> LessonQuiz { get; }
    public IRepository<Exam> LessonExam { get; }

    public IRepository<ExamQuestion> ExamQuestions { get; }
    public IRepository<QuizQuestion> QuizQuestions { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public async ValueTask<bool> SaveAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }
}
