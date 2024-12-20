using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Categories to organize courses
public class Category : Auditable
{
    public string Name { get; set; }

    public IEnumerable<Course> Courses { get; set; }
}
