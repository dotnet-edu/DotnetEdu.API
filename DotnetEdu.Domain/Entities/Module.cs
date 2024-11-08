using DotnetEdu.Domain.Commons;

namespace DotnetEdu.Domain.Entities;

// Modules within a course, containing sections
public class Module : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<Section> Sections { get; set; }
}
