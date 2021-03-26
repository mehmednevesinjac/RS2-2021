using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseCrudService<Proizvodi,Database.Proizvodi, ProizvodiSearchObject,Model.Requests.ProizvodiInsertRequest,Model.Requests.ProizvodiUpdateRequest>, IProizvodiService
    {
        public ProizvodiService(Database.eProdajaContext context, IMapper mapper) : base(context,mapper)
        { }

        public override IEnumerable<Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvodi>().AsQueryable();
            if(!string.IsNullOrEmpty(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search?.JedinicaMjereId.HasValue == true)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            if (search?.VrstaId.HasValue == true)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }

            if(search?.IncludeJedinicaMjere == true)
            {
                entity = entity.Include("JedinicaMjere");
            }

            if(search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            return entity.ToList().Select(x => _mapper.Map<Model.Proizvodi>(x));
        }


    }
}
