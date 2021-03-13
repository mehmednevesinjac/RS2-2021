using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : IProizvodService
    {
        private static List<Proizvod> _proizvodi;

        static ProizvodService()
        {
            _proizvodi = new List<Proizvod>() { 
                new Proizvod {Id = 1, Name = "Proizvod1"},
                new Proizvod {Id = 2, Name = "Proizvod2"},
                new Proizvod {Id = 3, Name = "Proizvod3"}
        };
        }


        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }

        public Proizvod GetById(int id)
        {
            return _proizvodi.FirstOrDefault(p => p.Id == id);
        }

        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod); 
            return proizvod;
        }

        public Proizvod Update(int id, Proizvod proizvod)
        {
            var current = _proizvodi.FirstOrDefault(p => p.Id == id);
            current.Name = proizvod.Name;
            return current;
        }
    }
}
