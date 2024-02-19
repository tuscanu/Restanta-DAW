namespace Restanta_DAW.Repositories.Interface
{
    using Restanta_DAW.Models.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IFilmeRepository
    {
        Task<IEnumerable<Actor>> GetAllFilmeAsync();
        Task<Filme> GetFilmeByIdAsync(int FilmId);
        Task AddFilmeAsync(Filme filme);
        Task UpdatefilmeAsync(Filme Filme);
        Task DeleteFilmeAsync(int FilmId);
        
    }
}
