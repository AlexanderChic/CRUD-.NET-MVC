using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestión_de_Productos_con_Categorías.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }
    }
}
