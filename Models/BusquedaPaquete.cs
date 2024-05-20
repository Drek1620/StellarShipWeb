using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StellarShipWeb.Models
{
    public class BusquedaPaquete
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 18, MinimumLength = 18, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        //[Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        public long IdGuia { get; set; }
    }
}
