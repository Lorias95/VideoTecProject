using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class Socio
    {
        public  Socio()
        {
            ArchiFichaSocio = new HashSet<ArchiFichaSocio>();
            Ficha = new HashSet<Ficha>();
        }

        [Required(ErrorMessage = "Debe digitar el " +
        "Código de Socio")]
        public int Codigo_Socio { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Apellido 1")]
        public string Apellido_1 { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Apellido 2")]
        public string Apellido_2 { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Teléfono")]
        public int Telefono { get; set; }

        public virtual ICollection<ArchiFichaSocio> ArchiFichaSocio { get; set; }
        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
