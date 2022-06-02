using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class NeuspeliPokusajPrijaveMapiranja : ClassMap<NeuspeliPokusajPrijave>
    {
        public NeuspeliPokusajPrijaveMapiranja(){
            Table("NEUSPELI_POKUSAJ_PRIJAVE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "SIFRA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.KorNalog, "KORNALOG");


        }
    }
}
