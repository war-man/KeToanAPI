using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class NhomKhachHangController : ControllerTemplate<eDm_NhomKH>
    {
        public NhomKhachHangController(IRepositoryCollection collection) : base(collection)
        {
        }      
        public override IActionResult AddEntities([FromBody] eDm_NhomKH[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_NhomKH.FirstOrDefault(c => c.MaNhomKH.ToLower().Equals(item.MaNhomKH.ToLower()) && c.LoaiNhKH == item.LoaiNhKH);
                if (temp != null)
                {
                    ModelState.AddModelError("MaNhomKH", $"Mã {item.MaNhomKH} loại {item.LoaiNhKH} đã tồn tại");
                    flagError = true;
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
    }
}
