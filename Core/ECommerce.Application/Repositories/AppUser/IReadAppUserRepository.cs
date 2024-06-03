using ECommerce.Domain.Entities.Concretes;

namespace ECommerce.Application.Repositories;

public interface IReadAppUserRepository : IReadGenericRepository<AppUser>
{
    Task<AppUser?> GetUserByEmail(string email);
    Task<AppUser?> GetUserByUserName(string userName);
    Task<AppUser?> GetUserByUserNameAndPassword(string userName, string password);
    Task<bool> CheckUserNamePassword(string userName, string password);
}
