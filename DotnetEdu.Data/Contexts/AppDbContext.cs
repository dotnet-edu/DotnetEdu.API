using DotnetEdu.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetEdu.Data.Contexts;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categries { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseModule> CourseModules { get; set; }
    public DbSet<ModuleSection> ModuleSections { get; set; }
    public DbSet<CourseLesson> CourseLessons { get; set; }

    public DbSet<LessonArticle> LessonsArticles { get; set; }
    public DbSet<LessonQuiz> LessonsQuizes { get; set; }
    public DbSet<LessonExam> LessonsExams { get; set; }

    public DbSet<ExamQuestion> ExamQuestions { get; set; }
    public DbSet<QuizQuestion> QuizQuestions { get; set; }
}
