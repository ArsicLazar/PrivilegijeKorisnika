using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class Profil
    {
        public virtual int Id { get; protected set; }//RedniBrojProfila
        public virtual string BojaPozadine { get; set; }
        public virtual string SpisakElGrafInt { get; set; }

        public virtual IList<GrupaKorisnika> ProfilGrupa { get; set; }
        public Profil() {
            ProfilGrupa = new List<GrupaKorisnika>();
        }
    }
}
