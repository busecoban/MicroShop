using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserService.Data;
using UserService.DTOs;
using UserService.Models;
using UserService.Services;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

namespace UserService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserDbContext _context;
    private readonly JwtService _jwt;

    public AuthController(UserDbContext context, JwtService jwt)
    {
        _context = context;
        _jwt = jwt;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        if (await _context.Users.AnyAsync(u => u.Email == request.Email))
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

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Created("", new
        {
            user.Id,
            user.Name,
            user.Email,
            user.Role,
            user.CreatedAt
        });
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var user = _context.Users.SingleOrDefault(u => u.Email == request.Email);

        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            return Unauthorized(new { message = "Invalid credentials" });
        }

        var token = _jwt.GenerateToken(user);

        return Ok(new { token });
    }

  private string HashPassword(string password)
{
    return BCrypt.Net.BCrypt.HashPassword(password);
}

}
