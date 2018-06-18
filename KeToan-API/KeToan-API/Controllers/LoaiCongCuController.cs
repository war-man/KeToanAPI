using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class LoaiCongCuController : ControllerTemplate<KeToan.eDm_pl_cc>
    {
        public LoaiCongCuController(IRepositoryCollection collection) : base(collection)
        {
        }

        public override IActionResult AddEntities([FromBody] eDm_pl_cc[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_pl_cc.FirstOrDefault(c => c.MaLoaiCC.ToLower().Equals(item.MaLoaiCC.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaLoaiCC", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
    }
}
