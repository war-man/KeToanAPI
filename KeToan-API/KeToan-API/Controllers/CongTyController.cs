using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using API.Services;
using KeToan;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class CongTyController : ControllerTemplate<eDm_cty>
    {
        public CongTyController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_cty[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_cty.FirstOrDefault(c => c.MaCTy.ToLower().Equals(item.MaCTy.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaCTy", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult DeleteEntities([FromQuery] int[] id)
        {
            var temp = (from c in Instance.Context.eDm_cty
                        join v in Instance.Context.eDm_chinhanh on c.KeyID equals v.CongTyID
                        where c.KeyID == id[0]
                        select c).ToList();
            if (temp.Count != 0)
            {
                ModelState.AddModelError("Exception", "Không thể xóa đối tượng này.");
                return BadRequest(ModelState);
            }
            return base.DeleteEntities(id);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_cty[] entities)
        {
            foreach (var item in entities)
            {
                if (Instance.Context.eDm_cty.Any(c => c.MaCTy.ToLower().Equals(item.MaCTy.ToLower()) && c.KeyID != item.KeyID))
                {
                    ModelState.AddModelError("MaCTy", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}