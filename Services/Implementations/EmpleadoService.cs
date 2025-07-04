using System.Collections.Generic;
using System.Threading.Tasks;
using EmpleadosApp.Services.Interfaces;
using EmpleadosApp.Repositories.Interfaces;
using EmpleadosApp.Models;

namespace EmpleadosApp.Services.Implementations
{
    public class EmpleadoService : Service<Empleado>, IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository) : base(empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public async Task<int> ContarActivosAsync()
        {
            return await _empleadoRepository.ContarActivosAsync();
        }

        public async Task<int> ContarInactivosAsync()
        {
            return await _empleadoRepository.ContarInactivosAsync();
        }
    }
}
