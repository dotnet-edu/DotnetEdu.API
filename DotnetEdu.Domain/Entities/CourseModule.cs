using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Modules within a course, containing sections
public class CourseModule : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public long CourseId { get; set; }
    public Course Course { get; set; }

    public IEnumerable<ModuleSection> Sections { get; set; }
}
