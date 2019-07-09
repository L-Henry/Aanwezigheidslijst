using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DeelnemersOpleidingen
    {
        public int Id { get; set; }
        public Deelnemers Deelnemer { get; set; }
        public OpleidingsInformatie OpleidingsInformatie { get; set; }

    }
}
