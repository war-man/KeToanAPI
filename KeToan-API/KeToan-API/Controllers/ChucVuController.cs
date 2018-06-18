using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Core;
using API.Model;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using KeToan;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class ChucVuController : ControllerTemplate<eDm_chucvu>
    {
        public ChucVuController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IEnumerable<eDm_chucvu> GetAll()
        {
            IEnumerable<eDm_chucvu> lstChucVu =  Instance.GetEntity().Result;
            lstChucVu = lstChucVu.Where(c => c.AnHien);
            return lstChucVu;
        }
        [HttpGet]
        [Route("chucvuan")]   //Get danh sách chức vụ bị ẩn
        public IEnumerable<eDm_chucvu> GetAllListAn()
        {
            //Instance.Context = new aModel();
            return Instance.Context.eDm_chucvu.Where(c => !c.AnHien);
        }
        public override IActionResult AddEntities([FromBody] eDm_chucvu[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_chucvu.FirstOrDefault(c => c.MaChucVu.ToLower().Equals(item.MaChucVu.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaChucVu", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_chucvu[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_chucvu.FirstOrDefault(c => c.MaChucVu.ToLower().Equals(item.MaChucVu.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaChucVu", "Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
