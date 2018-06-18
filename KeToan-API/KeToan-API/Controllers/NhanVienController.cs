using KeToan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;
using API.Core;

namespace API.Controllers
{


    namespace API.Controllers
    {
        [Authorize]
        [Route("KeToan/[controller]")]
        public class NhanvienController : ControllerTemplate<eDm_nv>
        {
            public NhanvienController(IRepositoryCollection collection) : base(collection)
            {
            }
            [HttpGet]
            [Route("danhsachnhanvien")]
            public IActionResult GetDanhSachNhanVien()
            {
                var t = (from c in Instance.Context.eTaiKhoan
                         join x in Instance.Context.eDm_nv on c.NVID equals x.KeyID
                         select new { c.KeyID, x.HoTen }).ToList();
                return Ok(t);
            }
            public override IActionResult AddEntities([FromBody] eDm_nv[] entities)
            {
                bool flagError = false;
                foreach (var item in entities)
                {
                    var checkMa = Instance.Context.eDm_nv.FirstOrDefault(c => c.MaNV.ToLower().Equals(item.MaNV.ToLower()) && !c.KeyID.Equals(item.KeyID));
                    var checkCMND = Instance.Context.eDm_nv.FirstOrDefault(c => c.SoCMND.Equals(item.SoCMND) && !c.KeyID.Equals(item.KeyID));
                    var checkSDT = Instance.Context.eDm_nv.FirstOrDefault(c => c.DTDD != null && c.DTDD.Equals(item.DTDD) && !c.KeyID.Equals(item.KeyID));
                    if (checkMa != null)
                    {
                        flagError = true;
                        ModelState.AddModelError("MaNV", entities[0].MaNV = $"Mã nhân viên {item.MaNV} đã tồn tại");
                    }
                    if (checkCMND != null)
                    {
                        flagError = true;
                        ModelState.AddModelError("SoCMND", $"Số chứng minh nhân dân {item.SoCMND} đã tồn tại");
                    }
                    if (checkSDT != null)
                    {
                        flagError = true;
                        ModelState.AddModelError("DTDD", $"Số điện thoại {item.DTDD} đã tồn tại");
                    }
                    if (flagError) return BadRequest(ModelState);
                }
                return base.AddEntities(entities);
            }

            public override IActionResult UpdateEntities([FromBody] eDm_nv[] entities)
            {
                foreach (var item in entities)
                {
                    var checkMa = Instance.Context.eDm_nv.FirstOrDefault(c => c.MaNV.ToLower().Equals(item.MaNV.ToLower()) && !c.KeyID.Equals(item.KeyID));
                    var checkCMND = Instance.Context.eDm_nv.FirstOrDefault(c => c.SoCMND.Equals(item.SoCMND) && !c.KeyID.Equals(item.KeyID));
                    var checkSDT = Instance.Context.eDm_nv.FirstOrDefault(c => c.DTDD != null && c.DTDD.Equals(item.DTDD) && !c.KeyID.Equals(item.KeyID));
                    if (checkMa != null)
                    {
                        ModelState.AddModelError("MaNV", $"Mã nhân viên {item.MaNV} đã tồn tại");
                        return BadRequest(ModelState);
                    }
                    if (checkCMND != null)
                    {
                        ModelState.AddModelError("SoCMND", $"Số chứng minh nhân dân {item.SoCMND} đã tồn tại");
                        return BadRequest(ModelState);
                    }
                    if (checkSDT != null)
                    {
                        ModelState.AddModelError("DTDD", $"Số điện thoại {item.DTDD} đã tồn tại");
                        return BadRequest(ModelState);
                    }
                }
                return base.UpdateEntities(entities);
            }
            [HttpDelete("id")]
            public IActionResult DeleteEntities([FromQuery] string id)
            {
                try
                {
                    Instance.BeginTransaction();
                    if (id != null)
                    {
                        eDm_nv temp = Instance.Context.eDm_nv.SingleOrDefault(c => c.KeyID.ToString().Equals(id));
                        Instance.Context.eDm_nv.Remove(temp);
                    }
                    else
                        return BadRequest();
                    Instance.SaveAll();
                    Instance.CommitTransaction();
                    return StatusCode(204, id);
                }
                catch (Exception ex)
                {
                    Instance.RollbackTransaction();
                    Instance.Logger.LogError(new EventId(), ex, $"Delete {typeof(eDm_nv).Name} Error");
                    ModelState.AddModelError("Exception", ex.Message);
                    return BadRequest(ModelState);
                }
            }
        }
    }
}
