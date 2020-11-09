using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class ArchiPeliPrestadas
    {
        public ArchiPeliPrestadas()
        {
            Ficha = new HashSet<Ficha>();
        }
        [Required(ErrorMessage = "Debe digitar el " +
        "ID de Película Prestada")]
        public int IdPeliPrestada { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Fecha de Préstamo")]
        public DateTime FechaPrestamo { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Duración")]
        public TimeSpan Duracion { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Número de Cintas")]
        public int NumCintas { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Género")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Actor")]
        public string Actores { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Director")]
        public string Directores { get; set; }

        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
