using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorisnikISMapiranja : ClassMap<PrivilegijeKorisnika.Entiteti.KorisnikIS>
    {
        public KorisnikISMapiranja()
        {
            //Mapiranje tabele
            Table("KORISNIK_IS");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDMATBR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.JedKorIme, "JEDKORIME");
            Map(x => x.DatRodj, "DATRODJ");
            Map(x => x.VremePoc, "VREMEPOC");
            Map(x => x.VremeZav, "VREMEZAV");
            Map(x => x.ImeRadnogMesta, "IMERADNOGMESTA");
            Map(x => x.FunKojuObavlja, "FUNKOJUOBAVLJA");
            Map(x => x.BrKancelarije, "BRKANCELARIJE");
            Map(x => x.Ime, "IME");
            Map(x => x.ImeRod, "IMEROD");
            Map(x => x.Prezime, "PREZIME");

            HasManyToMany(x => x.Grupe)
            .Table("KOR_OBUHVATA_GRUPU").ParentKeyColumn("JEDMATBRKOR").ChildKeyColumn("JEDIMEGRUPE").Cascade.All().Inverse();
        }
    }
}
