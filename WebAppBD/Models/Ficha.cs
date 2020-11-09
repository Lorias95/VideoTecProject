using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class Ficha
    {
        public Ficha()
        {
            ListaEspera = new HashSet<ListaEspera>();
        }

        [Required(ErrorMessage = "Debe digitar el " +
      "ID de Ficha")]
        public int IdFicha { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
      "Fecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "Número de Cinta")]
        public int NumCinta { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
      "Película")]
        public string Pelicula { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "Código de Socio")]
        public int CodigoSocio { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "ID de Película Prestada")]
        public int? IdPeliPrestada { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "ID de Película Devuelta")]
        public int? IdPeliDevuelta { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "ID de Película Por Título")]
        public int? IdPeliPorTitulo { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
      "ID de Ficha Socio")]
        public int IdFichaSocio { get; set; }

        public virtual Socio CodigoSocioNavigation { get; set; }
        public virtual ArchiFichaSocio IdFichaSocioNavigation { get; set; }
        public virtual ArchiPeliDevueltas IdPeliDevueltaNavigation { get; set; }
        public virtual ArchiPeliPorTitulo IdPeliPorTituloNavigation { get; set; }
        public virtual ArchiPeliPrestadas IdPeliPrestadaNavigation { get; set; }
        public virtual ICollection<ListaEspera> ListaEspera { get; set; }
    }
}
