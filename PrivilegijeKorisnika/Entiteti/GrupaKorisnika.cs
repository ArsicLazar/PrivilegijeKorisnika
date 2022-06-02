using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class GrupaKorisnika
    {
        public virtual string Id { get; set; }//JedIme
        public virtual string SifraGrupe { get; set; }
        public virtual string KratakOpis { get; set; }
        public virtual string DatumKreiranja { get; set; }
        public virtual string VremePocPer { get; set; }
        public virtual string VremeZavPer { get; set; }
        public virtual IList<KorisnikIS> Korisnik { get; set; }
        public virtual IList<Profil> GrupaProfil { get; set; }
        public GrupaKorisnika() {

            Korisnik = new List<KorisnikIS>();
            GrupaProfil = new List<Profil>();
        }

    }
}
