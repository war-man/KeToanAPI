using API.Core;
using KeToan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace API.Controllers
{

    [Authorize]
    [Route("KeToan/[controller]")]
    public class ChucDanhController : ControllerTemplate<eDm_chucdanh>
    {
        public ChucDanhController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_chucdanh[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_chucdanh.FirstOrDefault(c => c.MaChucDanh.ToLower().Equals(item.MaChucDanh.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaChucDanh", $"Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }

        public override IEnumerable<eDm_chucdanh> GetAll()
        {
            IEnumerable<eDm_chucdanh> lstChucdanh = Instance.GetEntity().Result;
            lstChucdanh = lstChucdanh.Where(c => c.AnHien);
            return lstChucdanh;
        }
        [HttpGet]
        [Route("chucdanhan")] //Get danh sách chức danh bị ẩn
        public IEnumerable<eDm_chucdanh> GetAllListAn()
        {
            //Instance.Context = new aModel();
            return Instance.Context.eDm_chucdanh.Where(c => !c.AnHien);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_chucdanh[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_chucdanh.FirstOrDefault(c => c.MaChucDanh.ToLower().Equals(item.MaChucDanh.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("MaChucDanh", $"Mã đã tồn tại");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
