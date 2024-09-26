using CRUDNetRazord.Datos;
using CRUDNetRazord.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNetRazord.Pages.Productos
{
    public class CrearModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Producto Producto { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Producto.FechaCreacion = DateTime.Now;

            _contexto.Add(Producto);
            await _contexto.SaveChangesAsync();
            Mensaje = "Producto creado correctamente";
            return RedirectToPage("Index");
        }
    }
}
