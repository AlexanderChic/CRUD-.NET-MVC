using Gestión_de_Productos_con_Categorías.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestión_de_Productos_con_Categorías.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //Agregar los medelos aqui (cada modelo corresponde a una tabla en la BD)
        public DbSet<Categoria> Categoria {  get; set; }
        public DbSet<Categoria> Producto { get; set; }

    }
}
