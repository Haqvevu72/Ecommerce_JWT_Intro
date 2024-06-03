using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.DTOs;

public class AppUserDTO
{
    public string UserName { get; set; }
    public string Password { get; set; }

    [Compare("Password")]
    public string RePassword  { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
