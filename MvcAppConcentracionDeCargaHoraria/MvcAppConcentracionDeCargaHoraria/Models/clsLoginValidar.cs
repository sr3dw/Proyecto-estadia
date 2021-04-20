using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MvcAppConcentracionDeCargaHoraria.Models
{
    public class clsLoginValidar
    {
        [DisplayName("Correo Electronico: ")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Correo electronico es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "No mas de 50 caracteres")]
        [EmailAddress(ErrorMessage = "Correo invalido")]
        public string vchEmail { set; get; }

        [DisplayName("Contraseña: ")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Contraseña es requerida")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "No mas de 50 caracteres")]
        public string vchPass { set; get; }
    }
}