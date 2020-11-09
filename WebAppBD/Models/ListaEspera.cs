using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBD.Models
{
    public partial class ListaEspera
    {
        [Required(ErrorMessage = "Debe digitar el " +
        "ID de Lista de Espera")]
        public int IdListaEspera { get; set; }

        [Required(ErrorMessage = "Debe digitar la " +
        "Cantidad de Socios")]
        public int CantidadSocios { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "Tiempo de Espera")]
        public TimeSpan TiempoEspera { get; set; }

        [Required(ErrorMessage = "Debe digitar el " +
        "ID de Ficha")]
        public int IdFicha { get; set; }

        public virtual Ficha IdFichaNavigation { get; set; }
    }
}
