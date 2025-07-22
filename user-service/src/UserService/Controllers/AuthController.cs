using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserService.Data;
using UserService.DTOs;
using UserService.Models;
using System.Security.Cryptography;
using System.Text;

namespace UserService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserDbContext _db;

    public AuthController(UserDbContext db)
    {
        _db = db;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        if (await _db.Users.AnyAsync(u => u.Email == request.Email))
        {
            return Conflict(new { message = "Email already registered." });
        }

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Email = request.Email,
            PasswordHash = HashPassword(request.Password),
            Role = UserRole.Customer,
            CreatedAt = DateTime.UtcNow
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();

        return Created("", new
        {
            user.Id,
            user.Name,
            user.Email,
            user.Role,
            user.CreatedAt
        });
    }

    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
