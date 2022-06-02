using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class PrivilegijeMapiranja : ClassMap<Privilegije>
    {
        public PrivilegijeMapiranja() {
            Table("PRIVILEGIJE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDIND").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Ime, "IME");
            Map(x => x.Akcija, "AKCIJA");
            Map(x => x.SamoVidiTajEl, "SAMOVIDITAJEL");
            Map(x => x.StavMenj, "STAVMENJ");
            Map(x => x.InfoRodStavMenj, "INFORODSTAVMENJ");
        }
    }
}
