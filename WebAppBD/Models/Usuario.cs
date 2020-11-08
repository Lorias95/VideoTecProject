using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppBD.Models
{
    //[Table("Usuario", Schema = "bdo")]
    public partial class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe digitar el nombre ")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "Debe digitar el apellido 1 ")]
       
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Debe digitar la contraseña ")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Debe digitar el correo ")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Debe digitar la cedula ")]

        public int? IdRol { get; set; }
        [Required(ErrorMessage = "Debe digitar el Rol")]

        public string Estado { get; set; }
        [Required(ErrorMessage = "Debe digitar el estado ")]

        public virtual Roles IdRolNavigation { get; set; }
    }
}
