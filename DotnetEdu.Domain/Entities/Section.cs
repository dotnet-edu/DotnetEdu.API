using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Sections within a module, may contain lessons and optionally sub-sections
public class Section : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public long? ModuleId { get; set; }
    public Module Module { get; set; }

    public Section? Parent { get; set; } // Optional parent for sub-section structure
    public IEnumerable<Lesson> Lessons { get; set; }
}
