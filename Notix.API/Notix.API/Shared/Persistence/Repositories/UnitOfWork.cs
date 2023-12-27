using Notix.API.Shared.Domain.Repositories;

namespace Notix.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;

    public UnitOfWork(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task CompleteAsync()
    {
        await _appDbContext.SaveChangesAsync();
    }
}