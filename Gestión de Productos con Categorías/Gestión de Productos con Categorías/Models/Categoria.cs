using System.ComponentModel.DataAnnotations;

namespace Gestión_de_Productos_con_Categorías.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public ICollection<Producto> productos { get; set; } = new List<Producto>();

                                              

    }
}
