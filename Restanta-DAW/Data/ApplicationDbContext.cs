using Restanta_DAW.Models.Domain;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{

    public DbSet<Actor> Actori { get; set; }
    public DbSet<Filme> Filme { get; set; }
    
    public DbSet<FilmeActor> FilmActor { get; set; }

    internal object Entry(object existent)
    {
        throw new NotImplementedException();
    }

    internal Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}

public class DbSet<T>
{
    internal Task AddAsync(Actor actor)
    {
        throw new NotImplementedException();
    }

    internal Task<Actor> FindAsync(int id)
    {
        throw new NotImplementedException();
    }

    internal Task FindAsync(string actorId)
    {
        throw new NotImplementedException();
    }

    internal void Remove(Actor actor)
    {
        throw new NotImplementedException();
    }

    internal Task<IEnumerable<Actor>> ToListAsync()
    {
        throw new NotImplementedException();
    }
}

public class DbContext
{
}