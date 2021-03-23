using eProdaja.Database;
using eProdaja.Filter;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;
        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }
        [HttpGet]
        public IList<Model.Korisnici> Get()
        {
           return _korisniciService.get();
        }
        [HttpPost]
        public Model.Korisnici Insert([FromBody]KorisniciInsertRequest request)
        {
            throw new UserException("Pogresna sifa");
        }

        //[HttpGet(template:"{id}")]
        //public Korisnici GetById(int id)
        //{
        //    return _korisniciService.GetById(id);
        //}

    }
}
