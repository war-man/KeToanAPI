using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class DieuKhoanThanhToanController : ControllerTemplate<eDm_thck>
    {
        public DieuKhoanThanhToanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_thck[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_thck.FirstOrDefault(c => c.MaTHCK.ToLower().Equals(item.MaTHCK.ToLower()) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaTHCK", entities[0].MaTHCK = $"Mã điều khoản thanh toán {item.MaTHCK} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_thck[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_thck.FirstOrDefault(c => c.MaTHCK.ToLower().Equals(item.MaTHCK.ToLower()) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaTHCK", $"Mã điều khoản thanh toán {item.MaTHCK} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
