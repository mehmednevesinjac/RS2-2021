using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseReadController<Model.JediniceMjere,object>
    {
       
        public JediniceMjereController (IJedinicaMjereService korisniciService) : base(korisniciService)
        {            
        }

    }
}
