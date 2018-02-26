using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisadorDeFrase.Modelos
{
    public class Frase
    {
        public int ID { get; set; }
        public string FraseOutraLingua { get; set; }
        public string FraseEmPortugues { get; set; }
        public Idioma Idioma { get; set; }

        public int Compreensao { get; set; }
        public DateTime DataDaUltimaRevisao { get; set; }
    }
}
