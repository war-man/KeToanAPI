using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class KhoController : ControllerTemplate<KeToan.eDm_kho>
    {
        public KhoController(IRepositoryCollection collection) : base(collection)
        {
        }

        [HttpGet]
        [Route("khohien")]   //Get danh sách kích hoạt
        public IEnumerable<eDm_kho> GetAllListHien()
        {
            return new zModel().eDm_kho.Where(c => c.AnHien);
        }

        [HttpGet]
        [Route("khoan")]   //Get danh sách bị ẩn
        public IEnumerable<eDm_kho> GetAllListAn()
        {
            return new zModel().eDm_kho.Where(c => !c.AnHien);
        }

        [HttpPost]
        public override IActionResult AddEntities([FromBody] eDm_kho[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_kho.FirstOrDefault(c => c.MaKho.ToLower().Equals(item.MaKho.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaKho", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }

        [HttpPut]
        public override IActionResult UpdateEntities([FromBody] eDm_kho[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_kho.FirstOrDefault(c => c.MaKho.ToLower().Equals(item.MaKho.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaKho", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
