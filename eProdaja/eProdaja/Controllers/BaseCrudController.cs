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
    public class BaseCrudController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;

        public BaseCrudController(ICRUDService<T, TSearch,TInsert,TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut(template:"{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _crudService.Update(id, request);
        }
    }
}
