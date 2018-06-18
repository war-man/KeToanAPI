using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class NhomCongCuController : ControllerTemplate<KeToan.eDm_nhom_cc>
    {
        public NhomCongCuController(IRepositoryCollection collection) : base(collection)
        {
        }

        [HttpPost]
        public override IActionResult AddEntities([FromBody] eDm_nhom_cc[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_nhom_cc.FirstOrDefault(c => c.MaNhomCC.ToLower().Equals(item.MaNhomCC.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaNhomCC", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }

        [HttpPut]
        public override IActionResult UpdateEntities([FromBody] eDm_nhom_cc[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_nhom_cc.FirstOrDefault(c => c.MaNhomCC.ToLower().Equals(item.MaNhomCC.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaNhomCC", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
