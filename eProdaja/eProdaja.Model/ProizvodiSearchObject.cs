using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Model
{
    public class ProizvodiSearchObject
    {
        public string Naziv { get; set; }
        public int? VrstaId { get; set; }
        public int? JedinicaMjereId { get; set; }
        public bool? IncludeJedinicaMjere { get; set; }
        public string[] IncludeList { get; set; }
    }
}
