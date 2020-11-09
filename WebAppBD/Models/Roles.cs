using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Descripción")]
        public string Descripcion { get; set; }
        

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
