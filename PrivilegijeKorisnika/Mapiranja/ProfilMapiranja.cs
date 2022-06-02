using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class ProfilMapiranja : ClassMap<Profil>
    {
        public ProfilMapiranja() {
            //Mapiranje tabele
            Table("PROFIL");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "REDNIBR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.BojaPozadine, "BOJAPOZADINE");
            Map(x => x.SpisakElGrafInt, "SPISAKELGAFINT");

            HasManyToMany(x => x.ProfilGrupa)
           .Table("GRUPA_POSEDUJE_PROFIL").ParentKeyColumn("REDNIBRPROF").ChildKeyColumn("JEDIMEGRUPE").Cascade.All();
        }
    }
}
