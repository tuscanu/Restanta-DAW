
using Restanta_DAW.Models.Domain;

public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task GetActorByIdAsync(int id);
    Task AddActorAsync(Actor actor);
}
