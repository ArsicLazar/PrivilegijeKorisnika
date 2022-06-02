using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    public class SistemProvereMapiranja : ClassMap<SistemProvere>
    {
        public SistemProvereMapiranja() {
            Table("SISTEM_PROVERE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "SIFRAKOR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.SifraZadPutProm, "SIFRAZADPUTPROM");
        }
    }
}
