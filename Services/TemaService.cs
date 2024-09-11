using AutoMapper;
using WebGrilla.DTOs;
using WebGrilla.Interfaces;

namespace WebGrilla.Services
{
    public class TemaService
    {
        private readonly ITemaRepository _temaRepository;
        private readonly IMapper _mapper;

        public TemaService(ITemaRepository temaRepository, IMapper mapper)
        {
            _temaRepository = temaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TemaDTO>> GetAllAsync()
        {
            var lista = await _temaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TemaDTO>>(lista);
        }

        public async Task<TemaDTO> GetByIdAsync(int id)
        {
            var tema = await _temaRepository.GetByIdAsync(id);
            return _mapper.Map<TemaDTO>(tema);
        }

    }

}
