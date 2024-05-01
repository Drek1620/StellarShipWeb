using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StellarShipWeb.Models
{
    public class BusquedaPaquete
    {
        [Required]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        public long IdGuia { get; set; }
    }
}
