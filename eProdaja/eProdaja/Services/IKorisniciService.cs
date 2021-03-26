using eProdaja.Model.Requests;
using System.Collections.Generic;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        public List<Model.Korisnici> get();
        public Model.Korisnici Insert(KorisniciInsertRequest korisnik);
        public Model.Korisnici GetById(int id);
    }
}
