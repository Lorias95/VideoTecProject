using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class ArchiPeliDevueltas
    {
        public ArchiPeliDevueltas()
        {
            Ficha = new HashSet<Ficha>();
        }

        public int IdPeliDevuelta { get; set; }
        [Required(ErrorMessage = "Debe digitar el ID " +
        "de la Pelicula")]
        public DateTime FechaDevolucion { get; set; }
        [Required(ErrorMessage = "Debe digitar la fecha de devolucion" +
        "de la Pelicula")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Debe digitar el titulo " +
        "de la Pelicula")]
        public TimeSpan Duracion { get; set; }
        [Required(ErrorMessage = "Debe digitar el duracion" +
        "de la Pelicula")]
        public int NumCintas { get; set; }
        [Required(ErrorMessage = "Debe digitar el numero de cintas " +
        "de la Pelicula")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Debe digitar el genero " +
        "de la Pelicula")]
        public string Actores { get; set; }
        [Required(ErrorMessage = "Debe digitar el actores " +
        "de la Pelicula")]
        public string Directores { get; set; }
        [Required(ErrorMessage = "Debe digitar el directores" +
        "de la Pelicula")]

        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
