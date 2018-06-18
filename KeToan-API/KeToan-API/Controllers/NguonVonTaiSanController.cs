using API.Core;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class NguonVonTaiSanController : ControllerTemplate<eCt_ts>
    {
        public NguonVonTaiSanController(IRepositoryCollection collection) : base(collection)
        {
        }
    }
}
