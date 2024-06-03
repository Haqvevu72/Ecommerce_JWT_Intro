using ECommerce.Application.Repositories;
using ECommerce.Domain.Entities.Concretes;
using ECommerce.Persistence.DbContexts;
using ECommerce.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence.Repositories;

public class ReadAppUserRepository : ReadGenericRepository<AppUser>, IReadAppUserRepository
{
    public ReadAppUserRepository(ECommerceDbContext context) : base(context)
    {
    }

    public async Task<bool> CheckUserNamePassword(string userName, string password)
    {
        var user =  await _table.FirstOrDefaultAsync(p => p.UserName == userName && p.Password == password);
        return (user is not null);
    }

    public async Task<AppUser?> GetUserByEmail(string email)
    {
        return await _table.FirstOrDefaultAsync(p => p.Email == email);
    }

    public async Task<AppUser?> GetUserByUserName(string userName)
    {
        return await _table.FirstOrDefaultAsync(p => p.UserName == userName);
    }

    public async Task<AppUser?> GetUserByUserNameAndPassword(string userName, string password)
    {
        return await _table.FirstOrDefaultAsync(p => p.UserName == userName && p.Password == password);
    }
}
