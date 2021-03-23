using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaMapping : Profile
    {
        public eProdajaMapping()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
        }
    }
}
