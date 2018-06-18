using API.Core;
using KeToan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class GiaBanController : ControllerTemplate<eDm_gia>
    {
        public GiaBanController(IRepositoryCollection collection) : base(collection)
        {
        }
    }
}
