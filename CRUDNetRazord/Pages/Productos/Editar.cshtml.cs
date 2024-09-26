using CRUDNetRazord.Datos;
using CRUDNetRazord.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNetRazord.Pages.Productos
{

    public class EditarModel(ApplicationDbContext contexto) : PageModel
    {
        private readonly ApplicationDbContext _contexto = contexto;

        [BindProperty]
        public Producto Producto { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int id)
        {
            Producto = await _contexto.Producto.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeDB = await _contexto.Producto.FindAsync(Producto.Id);


                CursoDesdeDB.NombreProducto = Producto.NombreProducto;
                CursoDesdeDB.Descripcion = Producto.Descripcion;
                CursoDesdeDB.BnStock = Producto.BnStock;
                CursoDesdeDB.Precio = Producto.Precio;

                await _contexto.SaveChangesAsync();
                Mensaje = "Producto editado correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }

    }
}

