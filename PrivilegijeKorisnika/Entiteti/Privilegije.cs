using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class Privilegije
    {
        public virtual int Id { get; set; }//JEDIND
        public virtual string Ime { get; set; }
        public virtual string SamoVidiTajEl { get; set; }
        public virtual string Akcija { get; set; }
        public virtual string StavMenj { get; set; }
        public virtual string InfoRodStavMenj { get; set; }
    }
}
