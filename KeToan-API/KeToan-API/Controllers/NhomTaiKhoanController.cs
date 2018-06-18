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
    public class NhomTaiKhoanController : ControllerTemplate<KeToan.eDm_nhomtk>
    {
        public NhomTaiKhoanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_nhomtk[] entities)
        {
            foreach (var item in entities)
            {
                var maTK = Instance.Context.eDm_nhomtk.FirstOrDefault(c => c.MaNTK.ToLower().Equals(item.MaNTK.ToLower()) && c.KeyID != item.KeyID);
                if (maTK != null)
                {
                    ModelState.AddModelError("MaNTK", $"Nhóm tài khoản {item.MaNTK} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_nhomtk[] entities)
        {
            foreach (var item in entities)
            {
                var maTK = Instance.Context.eDm_nhomtk.FirstOrDefault(c => c.MaNTK.ToLower().Equals(item.MaNTK.ToLower()) && c.KeyID != item.KeyID);
                if (maTK != null)
                {
                    ModelState.AddModelError("MaNTK", $"Nhóm tài khoản {item.MaNTK} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
