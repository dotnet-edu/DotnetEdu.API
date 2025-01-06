using DotnetEdu.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DotnetEdu.Service.Services.UserService;

public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async ValueTask<User> GetUserByIdAsync(string userId)
    {
        return await _userManager.FindByIdAsync(userId);
    }

    public async ValueTask<User> GetUserByUsernameAsync(string username)
    {
        return await _userManager.FindByNameAsync(username);
    }

    public async ValueTask<IdentityResult> CreateUserAsync(User user, string password)
    {
        return await _userManager.CreateAsync(user, password);
    }

    public async ValueTask<SignInResult> SignInAsync(string username, string password)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user == null) return SignInResult.Failed;

        return await _signInManager.PasswordSignInAsync(user, password, false, false);
    }

    public async ValueTask SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}

