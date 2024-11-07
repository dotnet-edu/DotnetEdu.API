using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

public class Category : Auditable
{
    public string Name { get; set; }

    public IEnumerable<Course> Courses { get; set; }
}



