using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class ArchiPeliPorTitulo
    {
        public ArchiPeliPorTitulo()
        {
            Ficha = new HashSet<Ficha>();
        }

        [Required(ErrorMessage = "Debe digitar el " +
        "ID de Película por Título")]
        public int IdPeliPorTitulo { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Duración")]
        public TimeSpan Duracion { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Número de Cinta")]
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
