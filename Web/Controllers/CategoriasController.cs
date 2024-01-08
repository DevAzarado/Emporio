
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ILogger<CategoriasController> _logger;
        private readonly ApplicationDbContext _dataContext;

        public CategoriasController(ILogger<CategoriasController> logger, ApplicationDbContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public async Task<ActionResult<Categoria>> Index()
        {
            var categorias = await _dataContext.Categorias.AsNoTracking().ToListAsync();
            return View(categorias);
        }


    }
}