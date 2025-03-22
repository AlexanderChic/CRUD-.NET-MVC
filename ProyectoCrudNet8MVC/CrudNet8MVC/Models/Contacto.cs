using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key] //Cuando se pone Key, se agrega que es una clave primaria, no es necesario indicarlo pero ayuda, ya que la coloca como
        //llave primaria cuando tiene la palabra id
        public int Id { get; set; }
        [Required(ErrorMessage = "Es obligatorio, nombre vacio")] 
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio, Telefono vacio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es obligatorio, Celular vacio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Es obligatorio, email vacio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
