using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class NguyenTeController : ControllerTemplate<KeToan.eDm_nt>
    {
        public NguyenTeController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_nt[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nt.FirstOrDefault(c => c.MaNT.ToLower().Equals(item.MaNT.ToLower()) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaNT", entities[0].MaNT = $"Mã nguyên tệ {item.MaNT} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_nt[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nt.FirstOrDefault(c => c.MaNT.ToLower().Equals(item.MaNT.ToLower()) && !c.KeyID.Equals(item.KeyID));               
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaNT", $"Mã nguyên tệ {item.MaNT} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
