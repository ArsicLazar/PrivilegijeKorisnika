using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class EmailAresa
    {
        public virtual long Id { get; set; }//JedMatBrKor
        public virtual string Email { get; set; }

        public EmailAresa(){
        
        }
    }
}
