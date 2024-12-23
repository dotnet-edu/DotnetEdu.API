using DotnetEdu.Data.Contexts;
using DotnetEdu.Data.Repositores;
using DotnetEdu.Domain.Entities;

namespace DotnetEdu.Data.UnitOfWorks;

public class UnitOfWork : IDisposable
{
    public readonly AppDbContext context;

    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
    }

    public IRepository<Category> Categories { get; }
    public IRepository<Course> Courses { get; }
    public IRepository<Module> Module { get; }
    public IRepository<Section> Section { get; }
    public IRepository<Lesson> Lesson { get; }

    public IRepository<Article> Articles { get; }
    public IRepository<Quiz> Quiz { get; }
    public IRepository<Exam> Exam { get; }

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
