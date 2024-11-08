using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Sections within a module, may contain lessons and optionally sub-sections
public class ModuleSection : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public long? ModuleId { get; set; }
    public CourseModule Module { get; set; }

    public ModuleSection? Parent { get; set; } // Optional parent for sub-section structure
    public IEnumerable<SectionLesson> Lessons { get; set; }
}
