using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class ArchiFichaSocio
    {
        public ArchiFichaSocio()
        {
            Ficha = new HashSet<Ficha>();
        }

        public int IdFichaSocio { get; set; }
        [Required(ErrorMessage = "Debe digitar el ID " +
            "de la Ficha")]
        public string GeneroFavorito { get; set; }
        [Required(ErrorMessage = "Debe digitar el Genero " +
            "Favorito")]
        public string ActoresFavorito { get; set; }
        [Required(ErrorMessage = "Debe digitar el Actor " +
            "Favorito")]
        public string DirectoresFavorito { get; set; }
        [Required(ErrorMessage = "Debe digitar el Director " +
            "Favorito")]
        public int CodigoSocio { get; set; }
        [Required(ErrorMessage = "Debe digitar el Codigo " +
            "del Socio")]

        public virtual Socio CodigoSocioNavigation { get; set; }
        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
