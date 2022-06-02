using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class EmailAdresaMapiranja : ClassMap<EmailAresa>
    {
        public EmailAdresaMapiranja(){
            //Mapiranje tabele
            Table("EMAIL_ADRESA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDMATBRKOR").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Email, "EMAIL");
        }

    }
}
