using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using API.Core;
using System.Linq;

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class HinhThucTraLuongController : ControllerTemplate<eDm_httl>
    {
        public HinhThucTraLuongController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_httl[] entities)
        {
            foreach (var item in entities)
            {
                var ten = Instance.Context.eDm_httl.FirstOrDefault(c => c.DienGiai.Trim().ToLower().Equals(item.DienGiai.Trim().ToLower()) && c.KeyID != item.KeyID);
                if (ten != null)
                {
                    ModelState.AddModelError("DienGiai", "Hình thức trả lương đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_httl[] entities)
        {
            foreach (var item in entities)
            {
                var ten = Instance.Context.eDm_httl.FirstOrDefault(c => c.DienGiai.Trim().ToLower().Equals(item.DienGiai.Trim().ToLower()) && c.KeyID != item.KeyID);
                if (ten != null)
                {
                    ModelState.AddModelError("DienGiai", "Hình thức trả lương đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
