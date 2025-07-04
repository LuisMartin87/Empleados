using System.Collections.Generic;
using System.Threading.Tasks;
using EmpleadosApp.Models;

namespace EmpleadosApp.Services.Interfaces
{
    public interface IEmpleadoService : IService<Empleado>
    {
        Task<int> ContarActivosAsync();
        Task<int> ContarInactivosAsync();
    }
}
