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

        [Required(ErrorMessage = "Debe digitar el ID " +
        "de Ficha Socio")]
        public int IdFichaSocio { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Género Favorito")]
        public string GeneroFavorito { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
         "Actor Favorito")]
        public string ActoresFavorito { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Director Favorito")]
        public string DirectoresFavorito { get; set; }

        [Required(ErrorMessage = "Debe seleccionar " +
        "el Código de Socio")]
        public int CodigoSocio { get; set; }
        

        public virtual Socio CodigoSocioNavigation { get; set; }
        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
