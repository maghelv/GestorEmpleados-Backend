using System.ComponentModel.DataAnnotations;

namespace MiWebAPI.Models
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }
        public string Empresa { get; set; }
    }
}
