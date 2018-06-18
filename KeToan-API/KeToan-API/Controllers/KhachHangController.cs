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
    public class KhachHangController : ControllerTemplate<KeToan.eKhachhang>
    {
        public KhachHangController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eKhachhang[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eKhachhang.FirstOrDefault(c => c.MaKH.ToLower().Equals(item.MaKH.ToLower()) && !c.KeyID.Equals(item.KeyID));
                var checkSDT = Instance.Context.eKhachhang.FirstOrDefault(c => c.DienThoai.Equals(item.DienThoai) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaKH", entities[0].MaKH = $"Mã khách hàng {item.MaKH} đã tồn tại");
                }
                if (checkSDT != null)
                {
                    flagError = true;
                    ModelState.AddModelError("DienThoai", $"Số điện thoại {item.DienThoai} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eKhachhang[] entities)
        {
            bool flagError = false;
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eKhachhang.FirstOrDefault(c => c.MaKH.ToLower().Equals(item.MaKH.ToLower()) && !c.KeyID.Equals(item.KeyID));
                var checkSDT = Instance.Context.eKhachhang.FirstOrDefault(c => c.DienThoai != null && c.DienThoai.Equals(item.DienThoai) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    flagError = true;
                    ModelState.AddModelError("MaKH", $"Mã khách hàng {item.MaKH} đã tồn tại");
                }
                if (checkSDT != null)
                {
                    flagError = true;
                    ModelState.AddModelError("DienThoai", $"Số điện thoại {item.DienThoai} đã tồn tại");
                }
                if (flagError) return BadRequest(ModelState);
            }
            return base.UpdateEntities(entities);
        }
    }
}
