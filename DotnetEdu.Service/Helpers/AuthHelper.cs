﻿using DotnetEdu.Domain.Entities;
using System.Security.Claims;
using System.Text;

namespace DotnetEdu.Service.Helpers;

public class AuthHepler
{
    public static string GenerateToken(User user)
    {
        //var tokenHandler = new JwtSecurityTokenHandler();
        //var key = Encoding.UTF8.GetBytes(EnvironmentHelper.JWTKey);
        //var tokenDescriptor = new SecurityTokenDescriptor
        //{
        //    Subject = new ClaimsIdentity(new Claim[]
        //    {
        //    new Claim("id", user.Id.ToString()),
        //    new Claim("email", user.Email),
        //    new Claim("phone_number", user.PhoneNumber),
        //    new Claim("firstname", user.FirstName),
        //    new Claim("lastname", user.LastName),
        //    new Claim(ClaimTypes.Role, user.UserRole.ToString()),
        //    }),

        //    Expires = DateTime.UtcNow.AddDays(
        //        Convert.ToInt32(EnvironmentHelper.TokenLifeTimeInDays)),

        //    SigningCredentials = new SigningCredentials(
        //        new SymmetricSecurityKey(key),
        //        SecurityAlgorithms.HmacSha256Signature)
        //};
        //var token = tokenHandler.CreateToken(tokenDescriptor);

        //return tokenHandler.WriteToken(token);
        return "ok";
    }
}
