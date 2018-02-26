using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisadorDeFrase.Modelos
{
    public class Texto
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Tags { get; set; }
        public int Grupo { get; set; }
        public string TextoOutroIdioma { get; set; }
        public string TextoPortugues { get; set; }
        public string Comentarios { get; set; }
        
        public Idioma Idioma { get; set; }
        public DateTime DataDeAdicao { get; set; }

        public DateTime? DataDaPrimeiraRevisao { get; set; }
        public DateTime? DataDaUltimaRevisao { get; set; }
        public DateTime? DataDaProximaRevisao { get; set; }
    }
}
