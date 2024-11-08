using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Courses within a category, containing various modules
public class Course : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<CourseModule> Modules { get; set; }
}
