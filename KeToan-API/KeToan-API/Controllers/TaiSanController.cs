using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class TaiSanController : ControllerTemplate<eDm_ts>
    {
        public TaiSanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_ts[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_ts.FirstOrDefault(c => c.MaTSCD.ToLower().Equals(item.MaTSCD.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNhomTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_ts[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_ts.FirstOrDefault(c => c.MaTSCD.ToLower().Equals(item.MaTSCD.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNhomTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
