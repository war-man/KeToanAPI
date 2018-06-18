using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class CongCuDungCuController : ControllerTemplate<KeToan.eDm_cc>
    {
        public CongCuDungCuController(IRepositoryCollection collection) : base(collection)
        {
        }

        [HttpPost]
        public override IActionResult AddEntities([FromBody] eDm_cc[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_cc.FirstOrDefault(c => c.MaCC.ToLower().Equals(item.MaCC.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaCC", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }

        [HttpPut]
        public override IActionResult UpdateEntities([FromBody] eDm_cc[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_cc.FirstOrDefault(c => c.MaCC.ToLower().Equals(item.MaCC.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaCC", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
