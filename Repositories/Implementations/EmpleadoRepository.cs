using EmpleadosApp.Data;
using EmpleadosApp.Models;
using EmpleadosApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmpleadosApp.Repositories.Implementations
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<int> ContarActivosAsync()
        {
            return await _context.Empleados.CountAsync(e => e.Activo);
        }

        public async Task<int> ContarInactivosAsync()
        {
            return await _context.Empleados.CountAsync(e => !e.Activo);
        }
    }
}
