using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StellarShipWeb.Models
{
    public class BusquedaPaquete
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        public long IdGuia { get; set; }
    }
}
