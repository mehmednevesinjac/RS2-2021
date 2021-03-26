using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T,TSearch> where T : class where TDb: class where TSearch : class
    {
        public eProdajaContext Context { get; set; }
        public IMapper _mapper;

        public BaseReadService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            return Context.Set<TDb>().ToList().Select(e => _mapper.Map<T>(e));
            //var entity = Context.Set<TDb>();
            //var list = entity.ToList();
            //return _mapper.Map<List<T>>(list);
            
        }

        public virtual T GetById(int id)
        {
            var entity = Context.Set<TDb>().Find(id);
            return _mapper.Map<T>(entity); 
        }
    }
}
