using WebGrilla.Models;

namespace WebGrilla.Interfaces
{
    public interface ITemaRepository
    {
        Task<IEnumerable<Tema>> GetAllAsync();
        Task<Tema> GetByIdAsync(int id);
        Task AddAsync(Tema tema);
        Task UpdateAsync(Tema tema);
        Task DeleteAsync(int id);
    }
}
