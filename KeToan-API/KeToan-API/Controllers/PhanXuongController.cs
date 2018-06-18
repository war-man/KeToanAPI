using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class PhanXuongController : ControllerTemplate<KeToan.eDm_px>
    {
        public PhanXuongController(IRepositoryCollection collection) : base(collection)
        {
        }
        [HttpPost]
        [Route("GetBPHT")]
        public List<ePXBPHTXREF> GetList([FromBody] string _idpx)
        {

            if (!string.IsNullOrEmpty(_idpx))
            {
                int _idPhanXuong = int.Parse(_idpx);
                var lstResult = Instance.Context.ePXBPHTXREF.Where(n => n.PXID == _idPhanXuong).ToList();
                return lstResult;
            }
            else
                return null;
        }
        
    }
}
