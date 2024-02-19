namespace Restanta_DAW.Repositories.Interface
{
    using Restanta_DAW.Models.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IActorRepository
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor> GetActorByIdAsync(int actorId);
        Task AddActorAsync(Actor actor);
        Task UpdateActorAsync(Actor actor);
        Task DeleteActorAsync(int actorId);
    }
}
