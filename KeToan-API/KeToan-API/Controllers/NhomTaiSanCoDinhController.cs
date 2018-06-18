using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class NhomTaiSanCoDinhController : ControllerTemplate<eDm_nhomtscd>
    {
        public NhomTaiSanCoDinhController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_nhomtscd[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nhomtscd.FirstOrDefault(c => c.MaNhomTSCD.ToLower().Equals(item.MaNhomTSCD.ToLower()) && c.KeyID != item.KeyID);
                var checkName = Instance.Context.eDm_nhomtscd.FirstOrDefault(c => c.TenNhom.ToLower().Equals(item.TenNhom.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNhomTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (checkName != null)
                {
                    ModelState.AddModelError("TenNhom", $"Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_nhomtscd[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nhomtscd.FirstOrDefault(c => c.MaNhomTSCD.ToLower().Equals(item.MaNhomTSCD.ToLower()) && c.KeyID != item.KeyID);
                var checkName = Instance.Context.eDm_nhomtscd.FirstOrDefault(c => c.TenNhom.ToLower().Equals(item.TenNhom.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNhomTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (checkName != null)
                {
                    ModelState.AddModelError("TenNhom", $"Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
