using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using KeToan;
using API.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class DonViTinhController : ControllerTemplate<eDm_dvt>
    {
        public DonViTinhController(IRepositoryCollection collection) : base(collection)
        {
        }

        public override IActionResult AddEntities([FromBody] eDm_dvt[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_dvt.FirstOrDefault(c => c.MaDVT.ToLower().Equals(item.MaDVT.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaDVT", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_dvt[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_dvt.FirstOrDefault(c => c.MaDVT.ToLower().Equals(item.MaDVT.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaDVT", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
