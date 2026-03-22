using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HarnishBalanceSheetAi.Server.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HarnishBalanceSheetAi.Server.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController(IRepository repository, IConfiguration configuration) : ControllerBase
{
    [HttpPost("login")]
    public async Task<JsonResult> Login([FromBody] LoginRequest request)
    {
        var user = await repository.GetUser(request.Email);

        if (user == null)
        {
            return new JsonResult(new { message = "Unauthorized" }) { StatusCode = 401 };
        }

        if (BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            var claims = new[]
            {
                new Claim("UserId", user.UserId.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: credentials
            );

            return new JsonResult(Ok(new JwtSecurityTokenHandler().WriteToken(token)));
        }

        return new JsonResult(new { message = "Unauthorized" }) { StatusCode = 401 };
    }
}

public class LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
