using KeToan;
    using Microsoft.AspNetCore.Mvc;
    using API.Services;
using API.Core;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class TinhThanhController : ControllerTemplate<KeToan.eDm_tt>
    {
        public TinhThanhController(IRepositoryCollection collection) : base(collection)
        {
        }

        [HttpPost]
        public override IActionResult AddEntities([FromBody] eDm_tt[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_tt.FirstOrDefault(c => c.MaTinhThanh.ToLower().Equals(item.MaTinhThanh.ToLower()) && c.KeyID != item.KeyID && c.MaCha == item.MaCha);
                if (temp != null)
                {
                    ModelState.AddModelError("MaTinhThanh", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }

        [HttpPut]
        public override IActionResult UpdateEntities([FromBody] eDm_tt[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_tt.FirstOrDefault(c => c.MaTinhThanh.ToLower().Equals(item.MaTinhThanh.ToLower()) && c.KeyID != item.KeyID && c.MaCha == item.MaCha);
                if (temp != null)
                {
                    ModelState.AddModelError("MaTinhThanh", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
