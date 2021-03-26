using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{

    public class VrsteProizvodumController : BaseReadController<Model.VrsteProizvodum,object>
    {
       
        public VrsteProizvodumController (IVrsteProizvodumServices vrsteService) : base(vrsteService)
        {       
        }
    }
}
