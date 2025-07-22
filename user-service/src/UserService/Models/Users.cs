namespace UserService.Models;

public enum UserRole
{
    Customer,
    Admin
}

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public UserRole Role { get; set; } = UserRole.Customer;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
