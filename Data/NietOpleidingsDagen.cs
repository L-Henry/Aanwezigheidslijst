using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class NietOpleidingsDagen
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public bool Voormiddag { get; set; }
        public bool Namiddag { get; set; }
        public OpleidingsInformatie OpleidingsInformatie { get; set; }

        public override string ToString()
        {
            if (Voormiddag && !Namiddag)
            {
                return Datum.ToShortDateString() + " (voormiddag)";
            }
            else if (Namiddag && !Voormiddag)
            {
                return Datum.ToShortDateString() + " (namiddag)";
            }
            else
            {
                return Datum.ToShortDateString();
            }
        }



    }
}
