using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DotnetEdu.Domain.Entities;

// User entity extending IdentityUser for authentication and user management
public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}
