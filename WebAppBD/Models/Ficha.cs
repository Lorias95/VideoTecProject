using System;
using System.Collections.Generic;

namespace WebAppBD.Models
{
    public partial class Ficha
    {
        public Ficha()
        {
            ListaEspera = new HashSet<ListaEspera>();
        }

        public int IdFicha { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCinta { get; set; }
        public string Pelicula { get; set; }
        public int CodigoSocio { get; set; }
        public int? IdPeliPrestada { get; set; }
        public int? IdPeliDevuelta { get; set; }
        public int? IdPeliPorTitulo { get; set; }
        public int IdFichaSocio { get; set; }

        public virtual Socio CodigoSocioNavigation { get; set; }
        public virtual ArchiFichaSocio IdFichaSocioNavigation { get; set; }
        public virtual ArchiPeliDevueltas IdPeliDevueltaNavigation { get; set; }
        public virtual ArchiPeliPorTitulo IdPeliPorTituloNavigation { get; set; }
        public virtual ArchiPeliPrestadas IdPeliPrestadaNavigation { get; set; }
        public virtual ICollection<ListaEspera> ListaEspera { get; set; }
    }
}
