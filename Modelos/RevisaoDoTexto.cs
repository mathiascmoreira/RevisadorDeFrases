using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisadorDeFrase.Modelos
{
    public class RevisaoDoTexto
    {
        public int IdDoTexto { get; set; }
        public DateTime? DataDaRevisao { get; set; }
        public DateTime? DataDaProximaRevisao { get; set; }
        public ResultadoDaRevisao ResultadoDaRevisao { get; set; }
    }
}
