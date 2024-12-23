using DotnetEdu.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetEdu.Data.Contexts;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<ExamQuestion> ExamQuestions { get; set; }
    public DbSet<QuizQuestion> QuizQuestions { get; set; }

}