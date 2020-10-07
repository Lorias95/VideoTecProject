using System;
using System.Collections.Generic;

namespace WebAppBD.Models
{
    public partial class ArchiPeliPorTitulo
    {
        public ArchiPeliPorTitulo()
        {
            Ficha = new HashSet<Ficha>();
        }

        public int IdPeliPorTitulo { get; set; }
        public string Titulo { get; set; }
        public TimeSpan Duracion { get; set; }
        public int NumCintas { get; set; }
        public string Genero { get; set; }
        public string Actores { get; set; }
        public string Directores { get; set; }

        public virtual ICollection<Ficha> Ficha { get; set; }
    }
}
