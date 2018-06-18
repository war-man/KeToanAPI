using Microsoft.AspNetCore.Mvc;
using API.Core;
using KeToan;
using API.Services;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class TaiKhoanNgamDinhController : ControllerTemplate<eTknd>
    {
        public TaiKhoanNgamDinhController(IRepositoryCollection collection) : base(collection)
        {
        }
        [HttpGet]
        [Route("dstaikhoanngamdinh")]
        public IActionResult GetTaiKhoanNgamDinh()
        {
            Instance.Context = new zModel();
            var temp = (from v in Instance.Context.eTknd select new { v.MaCT, v.TenCT }).Distinct();
            return Ok(temp.ToList());
        }
        [HttpGet]
        [Route("chitiettaikhoanngamdinh/ids")]
        public List<eTknd> ChiTietTaiKhoanNgamDinh([FromQuery] string id)
        {
            if (id.Length > 0)
            {
                List<eTknd> lstResult = new List<eTknd>();
                Instance.Context = new zModel();
                var lst = Instance.Context.eTknd.Where(c => c.MaCT.ToLower().Equals(id.ToLower()));
                foreach (var item in lst)
                {
                    var entry = Instance.Context.eTknd.Find(item.KeyID);
                    if (entry != null)
                        lstResult.Add(entry);
                }
                return lstResult;
            }
            else
                return null;
        }
    }
}
