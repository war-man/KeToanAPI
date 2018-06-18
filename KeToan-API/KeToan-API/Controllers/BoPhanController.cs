using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using KeToan;
using API.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class BoPhanController : ControllerTemplate<eDm_bophan>
    {
        public BoPhanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_bophan[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_bophan.FirstOrDefault(c => c.MaBP.ToLower().Equals(item.MaBP.ToLower()) && c.KeyID != item.KeyID);
                var tempName = Instance.Context.eDm_bophan.FirstOrDefault(c => c.TenBP.ToLower().Equals(item.TenBP.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaBP", "Mã đã tồn tại");
                    flagError = true;
                }
                if (tempName != null)
                {
                    ModelState.AddModelError("TenBP", "Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_bophan[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_bophan.FirstOrDefault(c => c.MaBP.ToLower().Equals(item.MaBP.ToLower()) && c.KeyID != item.KeyID);
                var tempName = Instance.Context.eDm_bophan.FirstOrDefault(c => c.TenBP.ToLower().Equals(item.TenBP.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaBP", "Mã đã tồn tại");
                    flagError = true;
                }
                if (tempName != null)
                {
                    ModelState.AddModelError("TenBP", "Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
