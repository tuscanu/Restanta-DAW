using Microsoft.EntityFrameworkCore;
using Restanta_DAW.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ActorRepository : IRepository<Actor>
{
    private readonly ApplicationDbContext _context;

    public ActorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Actor>> GetAllAsync()
    {
        return await _context.Actori.ToListAsync();
    }

    public async Task<Actor> GetByIdAsync(int id)
    {
        return await _context.Actori.FindAsync(id);
    }

    public async Task AddAsync(Actor actor)
    {
        await _context.Actori.AddAsync(actor);
        await _context.SaveChangesAsync();
    }



    public async Task DeleteAsync(int id)
    {
        var actor = await _context.Actori.FindAsync(id);
        if (actor != null)
        {
            _context.Actori.Remove(actor);
            await _context.SaveChangesAsync();
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Actor> GetAll()
    {
        throw new NotImplementedException();
    }

    public Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Actor entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Actor entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Actor entity)
    {
        throw new NotImplementedException();
    }

    public Task GetActorByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddActorAsync(Actor actor)
    {
        throw new NotImplementedException();
    }
}
