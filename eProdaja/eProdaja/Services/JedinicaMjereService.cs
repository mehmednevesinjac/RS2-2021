using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JedinicaMjereService : BaseReadService<Model.JediniceMjere,Database.JediniceMjere,object>, IJedinicaMjereService
    {
        public JedinicaMjereService(eProdajaContext context, IMapper mapper) : base(context,mapper)
        {  
        }
    }
}
