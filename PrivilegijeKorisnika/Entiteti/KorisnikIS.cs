using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorisnikIS
    {
        public virtual long Id { get; set; }//JedMatBr
        public virtual string JedKorIme { get; set; }
        public virtual string DatRodj { get; set; }
        public virtual string VremePoc { get; set; }
        public virtual string VremeZav { get; set; }
        public virtual string ImeRadnogMesta { get; set; }
        public virtual string FunKojuObavlja { get; set; }
        public virtual int BrKancelarije { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRod { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<GrupaKorisnika> Grupe { get; set; }
        public KorisnikIS()
        {
            Grupe = new List<GrupaKorisnika>();
        }
    }
}
