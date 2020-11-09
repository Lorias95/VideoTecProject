using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppBD.Models
{
    //[Table("Usuario", Schema = "bdo")]
    public partial class Usuario
    {
        [Required(ErrorMessage = "Debe digitar el ID " +
        "de Usuario")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Apellido")]
        public string Apellido1 { get; set; }
       
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Debe digitar la " +
        "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Debe digitar el " + "E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no válido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Cédula")]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "Debe digitar el ID " +
        "de Ficha Socio")]
        public int? IdRol { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Estado")]
        public string Estado { get; set; }
        

        public virtual Roles IdRolNavigation { get; set; }
    }
}
