using Microsoft.EntityFrameworkCore;
using EmpleadosApp.Models;

namespace EmpleadosApp.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options) { }

		public DbSet<Empleado> Empleados { get; set; }
	}
}
