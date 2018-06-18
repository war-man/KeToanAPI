using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class YeuToChiPhiController : ControllerTemplate<eDm_ytcp>
    {
        public YeuToChiPhiController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_ytcp[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_ytcp.FirstOrDefault(c => c.MaYTCP.ToLower().Equals(item.MaYTCP.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaYTCP", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_ytcp[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_ytcp.FirstOrDefault(c => c.MaYTCP.ToLower().Equals(item.MaYTCP.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaYTCP", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
