using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class DbService
{
    private readonly ApplicationContext _applicationContext;

    public DbService(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<ICollection<Characters>> GetCharacterData(int characterID)
    {
        return await _applicationContext.Characters.Include(e => e.FirstName)
            .Include(e => e.LastName)
            .Include(e => e.CurrentWei)
            .Include(e => e.MaxWeight)
            .Where(e => e.Id == characterID)
            .ToListAsync();

    }
}