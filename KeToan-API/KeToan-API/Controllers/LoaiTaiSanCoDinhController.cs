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
    public class LoaiTaiSanCoDinhController : ControllerTemplate<KeToan.eDm_loaitscd>
    {
        public LoaiTaiSanCoDinhController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_loaitscd[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_loaitscd.FirstOrDefault(c => c.MaLoaiTSCD.ToLower().Equals(item.MaLoaiTSCD.ToLower()) && c.KeyID != item.KeyID);
                var checkName = Instance.Context.eDm_loaitscd.FirstOrDefault(c => c.TenLoai.ToLower().Equals(item.TenLoai.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaLoaiTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (checkName != null)
                {
                    ModelState.AddModelError("TenLoai", $"Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_loaitscd[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_loaitscd.FirstOrDefault(c => c.MaLoaiTSCD.ToLower().Equals(item.MaLoaiTSCD.ToLower()) && c.KeyID != item.KeyID);
                var checkName = Instance.Context.eDm_loaitscd.FirstOrDefault(c => c.TenLoai.ToLower().Equals(item.TenLoai.ToLower()) && c.KeyID != item.KeyID);
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaLoaiTSCD", $"Mã đã tồn tại");
                    flagError = true;
                }
                if (checkName != null)
                {
                    ModelState.AddModelError("TenLoai", $"Tên đã tồn tại");
                    flagError = true;
                }
                if (flagError)
                    return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
