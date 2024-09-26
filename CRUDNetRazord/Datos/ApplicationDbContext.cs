using CRUDNetRazord.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNetRazord.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        //Aqui van los modelos
        public DbSet<Producto> Producto { get; set; }
    }
}
