using ECommerce.Domain.Entities.Concretes;

namespace ECommerce.Application.Services;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
