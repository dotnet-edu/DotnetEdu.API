using Microsoft.AspNetCore.Identity;

namespace DotnetEdu.Domain.Entities;

// User entity extending IdentityUser for authentication and user management
public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}
