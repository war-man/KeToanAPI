using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using Microsoft.AspNetCore.Authorization;
using API.Services;
using KeToan;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class ChiNhanhController : ControllerTemplate<eDm_chinhanh>
    {
        public ChiNhanhController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_chinhanh[] entities)
        {
            foreach (var item in entities)
            {
                var temp = Instance.Context.eDm_chinhanh.FirstOrDefault(c => c.MaCN.ToLower().Equals(item.MaCN.ToLower()) && c.KeyID != item.KeyID);
                if (temp != null)
                {
                    ModelState.AddModelError("", $"Mã chi nhánh {item.MaCN} đã tồn tại\n");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
    }
}
