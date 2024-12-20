using DotnetEdu.Data.Contexts;
using DotnetEdu.Data.Repositores;
using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Data.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IRepository<Category> Categories { get; }
    IRepository<Course> Courses { get; }
    IRepository<CourseModule> CourseModules { get; }
    IRepository<ModuleSection> ModuleSections { get; }
    IRepository<SectionLesson> SectionLessons { get; }

    IRepository<LessonArticle> LessonArticles { get; }
    IRepository<LessonQuiz> LessonQuiz { get; }
    IRepository<LessonExam> LessonExam { get; }

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
    public IRepository<CourseModule> CourseModule { get; }
    public IRepository<ModuleSection> ModuleSection { get; }
    public IRepository<SectionLesson> SectionLesson { get; }

    public IRepository<LessonArticle> LessonArticles { get; }
    public IRepository<LessonQuiz> LessonQuiz { get; }
    public IRepository<LessonExam> LessonExam { get; }

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
