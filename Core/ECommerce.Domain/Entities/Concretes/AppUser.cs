using ECommerce.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Concretes;

public class AppUser:BaseEntity
{
    public int  Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? UserName { get; set; }
    public string? Role { get; set; }

    public bool?  IsConfirmed { get; set; }

    // Navigation Property
    public  virtual ICollection<Order> Orders { get; set; }
}
