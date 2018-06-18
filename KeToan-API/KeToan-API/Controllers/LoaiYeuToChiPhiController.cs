using API.Core;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class LoaiYeuToChiPhiController : ControllerTemplate<eDm_lytcp>
    {
        public LoaiYeuToChiPhiController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_lytcp[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_lytcp.FirstOrDefault(c => c.MaLoaiYTCP.ToLower().Equals(item.MaLoaiYTCP.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaLoaiYTCP", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_lytcp[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_lytcp.FirstOrDefault(c => c.MaLoaiYTCP.ToLower().Equals(item.MaLoaiYTCP.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaLoaiYTCP", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
