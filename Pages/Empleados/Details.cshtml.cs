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
    public class DetailsModel : PageModel
    {
        private readonly EmpleadosApp.Data.AppDbContext _context;

        public DetailsModel(EmpleadosApp.Data.AppDbContext context)
        {
            _context = context;
        }

        public Empleado Empleado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleado = await _context.Empleados.FirstOrDefaultAsync(m => m.Id == id);

            if (Empleado == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
