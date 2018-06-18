using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using KeToan;
using API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class SoDuDauKyTaiKhoanController : ControllerTemplate<eCdtk>
    {
        public SoDuDauKyTaiKhoanController(IRepositoryCollection collection) : base(collection)
        {
        }
    }
}
