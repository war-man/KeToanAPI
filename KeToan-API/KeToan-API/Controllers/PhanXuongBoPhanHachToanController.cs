using API.Core;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeToan;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class PhanXuongBoPhanHachToanController : ControllerTemplate<KeToan.ePXBPHTXREF>
    {
        public PhanXuongBoPhanHachToanController(IRepositoryCollection collection) : base(collection)
        {
        }
        public override IActionResult UpdateEntities([FromBody] ePXBPHTXREF[] entities)
        {
            try
            {
                var lstPXBPHT = Instance.Context.ePXBPHTXREF.Where(n => n.PXID == entities[0].PXID).ToArray();
                base.DeleteEntities(lstPXBPHT);

                return base.AddEntities(entities);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
