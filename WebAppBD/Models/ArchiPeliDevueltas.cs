using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAppBD.Models
{
    public partial class ArchiPeliDevueltas
    {
        public ArchiPeliDevueltas()
        {
            Ficha = new HashSet<Ficha>();
        }
        [Required(ErrorMessage = "Debe digitar el " +
        "ID de Película Devuelta")]
        public int IdPeliDevuelta { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Fecha de Devolución")]
        public DateTime FechaDevolucion { get; set; }

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
