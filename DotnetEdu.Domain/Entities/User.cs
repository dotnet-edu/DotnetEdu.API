using DotnetEdu.Domain.Commons;
using Microsoft.AspNetCore.Identity;

namespace DotnetEdu.Domain.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBIrth { get; set; }
}

public class Course : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public IEnumerable<Section> Sections { get; set; }
}
public class Section
{
    public string Name { get; set; }

}



