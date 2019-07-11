using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<Deelnemers> Deelnemers { get; set; }
        public DbSet<DeelnemersOpleidingen> DeelnemersOpleidingen { get; set; }
        public DbSet<Docenten> Docenten { get; set; }
        public DbSet<DocentenOpleiding> DocentenOpleiding { get; set; }
        public DbSet<NietOpleidingsDagen> NietOpleidingsDagen { get; set; }
        public DbSet<OpleidingsInformatie> OpleidingsInformatie { get; set; }
        public DbSet<Tijdsregistraties> Tijdsregistraties { get; set; }

        public DataContext() : base("Aanwezigheidslijst")
        {

        }
    }
}
