using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class GrupaKorisnikaMapiranja : ClassMap<GrupaKorisnika>
    {
        public GrupaKorisnikaMapiranja() {
            //Mapiranje tabele
            Table("GRUPA_KORISNIKA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDIME").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.SifraGrupe, "SIFRAGRUPE");
            Map(x => x.KratakOpis, "KRATAKOPIS");
            Map(x => x.DatumKreiranja, "DATUMKREIRANJA");
            Map(x => x.VremePocPer, "VREMEPOCPER");
            Map(x => x.VremeZavPer, "VREMEZAVPER");

            HasManyToMany(x => x.Korisnik)
            .Table("KOR_OBUHVATA_GRUPU").ParentKeyColumn("JEDIMEGRUPE").ChildKeyColumn("JEDMATBRKOR").Cascade.All();

            HasManyToMany(x => x.GrupaProfil)
            .Table("GRUPA_POSEDUJE_PROFIL").ParentKeyColumn("JEDIMEGRUPE").ChildKeyColumn("REDNIBRPROF").Cascade.All();
        }

    }
}
