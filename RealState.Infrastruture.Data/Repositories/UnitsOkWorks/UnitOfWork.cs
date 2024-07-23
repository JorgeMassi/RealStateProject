using RealState.Application.Interfaces.UnitOfWork;
using RealState.Infrastruture.Data.Repositories.ApplicationDbContexts;

namespace RealState.Infrastruture.Data.Repositories.UnitsOkWorks;

public class UnitOfWork : IUnitOfWork
{
    private ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Commit()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public bool HasChanges()
    {
        return _context.ChangeTracker.HasChanges();
    }
}

