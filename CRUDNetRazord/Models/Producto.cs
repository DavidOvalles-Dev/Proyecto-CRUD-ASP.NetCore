using System.ComponentModel.DataAnnotations;

namespace CRUDNetRazord.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Display(Name = "Cantidad en Stock")]
        public int BnStock { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }

    }
}
