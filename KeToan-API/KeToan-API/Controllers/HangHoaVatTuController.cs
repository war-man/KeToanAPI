using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class HangHoaVatTuController : ControllerTemplate<eDm_vthh>
    {
        public HangHoaVatTuController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_vthh[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_vthh.FirstOrDefault(c => c.MaVTHH.ToLower().Equals(item.MaVTHH.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaVTHH", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_vthh[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_vthh.FirstOrDefault(c => c.MaVTHH.ToLower().Equals(item.MaVTHH.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaVTHH", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
