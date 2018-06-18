using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class PhongBanController : ControllerTemplate<KeToan.eDm_phongban>
    {
        public PhongBanController(IRepositoryCollection collection) : base(collection)
        {
        }
        [HttpGet]
        [Route("phongbanhien")]   //Get danh sách chức danh không bị ẩn
        public IEnumerable<eDm_phongban> GetAllListHien()
        {
            //Instance.Context = new aModel();
            return Instance.Context.eDm_phongban.Where(c => c.AnHien);
        }
        [HttpGet]
        [Route("phongbanan")]   //Get danh sách chức danh bị ẩn
        public IEnumerable<eDm_phongban> GetAllListAn()
        {
            //Instance.Context = new aModel();
            return Instance.Context.eDm_phongban.Where(c => !c.AnHien);
        }
        public override IActionResult AddEntities([FromBody] eDm_phongban[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_phongban.FirstOrDefault(c => c.MaPB.ToLower().Equals(item.MaPB.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaPB", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_phongban[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_phongban.FirstOrDefault(c => c.MaPB.ToLower().Equals(item.MaPB.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaPB", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
