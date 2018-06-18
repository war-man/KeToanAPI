using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class KheUocController : ControllerTemplate<KeToan.eDm_kheuoc>
    {
        public KheUocController(IRepositoryCollection collection) : base(collection)
        {
        }

        [HttpPost]
        public override IActionResult AddEntities([FromBody] eDm_kheuoc[] entities)
        {
            bool chk = true;
            foreach (var item in entities)
            {
                if (Instance.Context.eDm_kheuoc.Any(c => c.MaKU.Trim().ToLower().Equals(item.MaKU.Trim().ToLower()) && c.KeyID != item.KeyID))
                {
                    ModelState.AddModelError("MaKU", "Mã khế ước đã tồn tại");
                    chk = false;
                }
                if (Instance.Context.eDm_kheuoc.Any(c => c.SoKU.Trim().ToLower().Equals(item.SoKU.Trim().ToLower()) && c.KeyID != item.KeyID))
                {
                    ModelState.AddModelError("SoKU", "Số khế ước đã tồn tại");
                    chk = false;
                }
                if (!chk)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }

        [HttpPut]
        public override IActionResult UpdateEntities([FromBody] eDm_kheuoc[] entities)
        {
            bool chk = true;
            foreach (var item in entities)
            {
                if (Instance.Context.eDm_kheuoc.Any(c => c.MaKU.Trim().ToLower().Equals(item.MaKU.Trim().ToLower()) && c.KeyID != item.KeyID))
                {
                    ModelState.AddModelError("MaKU", "Mã khế ước đã tồn tại");
                    chk = false;
                }
                if (Instance.Context.eDm_kheuoc.Any(c => c.SoKU.Trim().ToLower().Equals(item.SoKU.Trim().ToLower()) && c.KeyID != item.KeyID))
                {
                    ModelState.AddModelError("SoKU", "Số khế ước đã tồn tại");
                    chk = false;
                }
                if (!chk)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
