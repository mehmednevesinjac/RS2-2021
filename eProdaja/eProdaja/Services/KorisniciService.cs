using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;
        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnici> get()
        {
            return Context.Korisnicis.ToList().Select(k => _mapper.Map<Model.Korisnici>(k)).ToList();
        }

        public Model.Korisnici GetById(int Id)
        {
            return null;
         }

        public Model.Korisnici Insert (KorisniciInsertRequest request)
        {
            throw new NotImplementedException();
        }

        //public Korisnici Update(Korisnici korisnik)
        //{
        //    return new NotImplementedException();
        //}

    }
}
