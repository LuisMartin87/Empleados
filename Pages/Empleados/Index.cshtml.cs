using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmpleadosApp.Data;
using EmpleadosApp.Models;

namespace EmpleadosApp.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly EmpleadosApp.Data.AppDbContext _context;

        public IndexModel(EmpleadosApp.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; }

        public async Task OnGetAsync()
        {
            Empleado = await _context.Empleados.ToListAsync();
        }
    }
}
