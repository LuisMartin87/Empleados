using EmpleadosApp.Models;
using EmpleadosApp.Repositories.Interfaces;
using System.Threading.Tasks;

namespace EmpleadosApp.Repositories.Interfaces
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        Task<int> ContarActivosAsync();
        Task<int> ContarInactivosAsync();
    }
}
