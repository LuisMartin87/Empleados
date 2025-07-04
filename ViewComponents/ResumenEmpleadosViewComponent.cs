using EmpleadosApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmpleadosApp.ViewComponents
{
    public class ResumenEmpleadosViewComponent : ViewComponent
    {
        private readonly IEmpleadoRepository _repo;

        public ResumenEmpleadosViewComponent(IEmpleadoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var activos = await _repo.ContarActivosAsync();
            var inactivos = await _repo.ContarInactivosAsync();
            ViewData["Activos"] = activos;
            ViewData["Inactivos"] = inactivos;
            return View();
        }
    }
}
