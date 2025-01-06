using DotnetEdu.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DotnetEdu.Service.Services.UserService;

public interface IUserService
{
    ValueTask<User> GetUserByIdAsync(string userId);
    ValueTask<User> GetUserByUsernameAsync(string username);
    ValueTask<IdentityResult> CreateUserAsync(User user, string password);
    ValueTask<SignInResult> SignInAsync(string username, string password);
    ValueTask SignOutAsync();
}
