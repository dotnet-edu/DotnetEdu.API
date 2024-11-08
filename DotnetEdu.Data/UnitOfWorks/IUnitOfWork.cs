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
