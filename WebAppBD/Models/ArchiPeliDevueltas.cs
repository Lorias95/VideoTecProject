using System;
using System.Collections.Generic;

namespace WebAppBD.Models
{
    public partial class ArchiPeliDevueltas
    {
        public ArchiPeliDevueltas()
        {
            Ficha = new HashSet<Ficha>();
        }

        public int IdPeliDevuelta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Titulo { get; set; }
        public TimeSpan Duracion { get; set; }
        public int NumCintas { get; set; }
        public string Genero { get; set; }
        public string Actores { get; set; }
        public string Directores { get; set; }

        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
