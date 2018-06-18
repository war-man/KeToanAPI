using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class ChungTuController : ControllerTemplate<KeToan.eDm_ct>
    {
        public ChungTuController(IRepositoryCollection collection) : base(collection)
        {
        }
    }
}
