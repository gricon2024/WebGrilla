using Microsoft.EntityFrameworkCore;
using WebGrilla.Interfaces;
using WebGrilla.Models;

namespace WebGrilla.Data
{
    public class TemaRepository : ITemaRepository
    {

        private readonly AppDbContext _context;

        public TemaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Tema tema)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tema>> GetAllAsync()
        {
            return await _context.Temas.ToListAsync();
        }

        public async Task<Tema> GetByIdAsync(int id)
        {
            return await _context.Temas.FindAsync(id);
        }

        public Task UpdateAsync(Tema tema)
        {
            throw new NotImplementedException();
        }
    }
}
