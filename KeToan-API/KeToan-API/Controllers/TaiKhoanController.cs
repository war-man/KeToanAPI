using KeToan;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Core;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class TaiKhoanController : ControllerTemplate<KeToan.eDm_tk>
    {
        public TaiKhoanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_tk[] entities)
        {
            foreach (var item in entities)
            {
                var TK = Instance.Context.eDm_tk.FirstOrDefault(c => c.TK.ToLower().Equals(item.TK.ToLower()) && c.KeyID != item.KeyID);
                if (TK != null)
                {
                    ModelState.AddModelError("TK", "Số tài khoản đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_tk[] entities)
        {
            foreach (var item in entities)
            {
                var TK = Instance.Context.eDm_tk.FirstOrDefault(c => c.TK.ToLower().Equals(item.TK.ToLower()) && c.KeyID != item.KeyID);
                if (TK != null)
                {
                    ModelState.AddModelError("TK", "Số tài khoản đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
