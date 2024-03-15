using System.ComponentModel.DataAnnotations;

namespace StellarShipWeb.Models
{
    public class BusquedaPaquete
    {
        [Required]
        public long IdGuia { get; set; }
    }
}
