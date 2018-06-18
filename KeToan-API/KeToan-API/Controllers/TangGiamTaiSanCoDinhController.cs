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
    public class TangGiamTaiSanCoDinhController : ControllerTemplate<KeToan.eDm_tgtscd>
    {
        public TangGiamTaiSanCoDinhController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult AddEntities([FromBody] eDm_tgtscd[] entities)
        {
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_tgtscd.FirstOrDefault(c => c.MaTGTSCD.Equals(item.MaTGTSCD) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaTGTSCD", $"Mã {item.MaTGTSCD} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.AddEntities(entities);
        }
        public override IActionResult UpdateEntities([FromBody] eDm_tgtscd[] entities)
        {
            foreach (var item in entities)
            {
                var checkMa = Instance.Context.eDm_tgtscd.FirstOrDefault(c => c.MaTGTSCD.Equals(item.MaTGTSCD) && !c.KeyID.Equals(item.KeyID));
                if (checkMa != null)
                {
                    ModelState.AddModelError("MaTGTSCD", $"Mã {item.MaTGTSCD} đã tồn tại!");
                    return BadRequest(ModelState);
                }
            }
            return base.UpdateEntities(entities);
        }
    }
}
