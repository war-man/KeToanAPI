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
    public class NguonVonController : ControllerTemplate<KeToan.eDm_nguonvon>
    {
        public NguonVonController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_nguonvon[] entities)
        {
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nguonvon.FirstOrDefault(c => c.MaNguonVon.Equals(item.MaNguonVon) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNguonVon", entities[0].MaNguonVon = $"Mã nguồn vốn {item.MaNguonVon} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_nguonvon[] entities)
        {
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_nguonvon.FirstOrDefault(c => c.MaNguonVon.Equals(item.MaNguonVon) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaNguonVon", entities[0].MaNguonVon = $"Mã nguồn vốn {item.MaNguonVon} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
