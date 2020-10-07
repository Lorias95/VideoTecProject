using System;
using System.Collections.Generic;

namespace WebAppBD.Models
{
    public partial class ListaEspera
    {
        public int IdListaEspera { get; set; }
        public int CantidadSocios { get; set; }
        public TimeSpan TiempoEspera { get; set; }
        public int IdFicha { get; set; }

        public virtual Ficha IdFichaNavigation { get; set; }
    }
}
