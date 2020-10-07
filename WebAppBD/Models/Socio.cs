using System;
using System.Collections.Generic;

namespace WebAppBD.Models
{
    public partial class Socio
    {
        public Socio()
        {
            ArchiFichaSocio = new HashSet<ArchiFichaSocio>();
            Ficha = new HashSet<Ficha>();
        }

        public int CodigoSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public virtual ICollection<ArchiFichaSocio> ArchiFichaSocio { get; set; }
        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
