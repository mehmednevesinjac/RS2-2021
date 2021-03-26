using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService : BaseReadService<Model.VrsteProizvodum, Database.VrsteProizvodum,object>, IVrsteProizvodumServices
    {


        public VrsteProizvodumService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
