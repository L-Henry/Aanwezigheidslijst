using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OpleidingsInformatie
    {
        public int Id { get; set; }
        public string OpleidingsInstelling { get; set; }
        public string  Opleiding { get; set; }
        public string Contactpersoon { get; set; }
        public string Opleidingsplaats { get; set; }
        public string ReferentieOpledingsPlaats { get; set; }
        public int OeNummer { get; set; }
        public int Opleidngscode { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }

    }
}
