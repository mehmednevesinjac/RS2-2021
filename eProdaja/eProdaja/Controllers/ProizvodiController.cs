using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseCrudController<Proizvodi,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService service) : base(service)
        {

        }
    }
}
