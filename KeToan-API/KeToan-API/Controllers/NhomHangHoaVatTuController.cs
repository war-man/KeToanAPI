using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Core;
using KeToan;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using API.TokenProvider;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace API.Controllers
{
    [Authorize]
    [Route("KeToan/[controller]")]
    public class NhomHangHoaVatTuController : Core.ControllerTemplate<eDm_nhomhhvt>
    {
        private readonly TokenProviderOptions _options;
        public NhomHangHoaVatTuController(IRepositoryCollection collection, IOptions<TokenProviderOptions> option) : base(collection)
        {
            _options = option.Value;
        }
        public override IEnumerable<eDm_nhomhhvt> GetAll()
        {
            return base.GetAll();
        }
        public override List<eDm_nhomhhvt> GetList([FromQuery] int[] id)
        {
            return base.GetList(id);
        }
        public override IActionResult AddEntities([FromBody] eDm_nhomhhvt[] entities)
        {
            try
            {
                if (entities == null || entities.Length == 0)
                {
                    return BadRequest();
                }
                string _error = string.Empty;
                foreach (var item in entities)
                {
                    _error = ValidateAddOrUpdate(item, false);
                    if (!string.IsNullOrEmpty(_error))
                        return BadRequest(_error);
                    item.NguoiTao = GetIdUser();
                    item.NgayTao = DateTime.Now.Date;

                }
                return base.AddEntities(entities);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public override IActionResult UpdateEntities([FromBody] eDm_nhomhhvt[] entities)
        {
            try
            {
                if (entities == null || entities.Length == 0)
                {
                    return BadRequest();
                }
                string _error = string.Empty;
                foreach (var item in entities)
                {
                    _error = ValidateAddOrUpdate(item, true);
                    if (!string.IsNullOrEmpty(_error))
                        return BadRequest(_error);
                    item.NguoiCapNhat = GetIdUser();
                    item.NgayCapNhat = DateTime.Now.Date;
                }
                return base.UpdateEntities(entities);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public override IActionResult DeleteEntities([FromBody] eDm_nhomhhvt[] entities)
        {
            try
            {
                if(entities == null || entities.Length == 0)
                {
                    return BadRequest();
                }
                string _error = string.Empty;
                foreach (var item in entities)
                {
                    _error = ValidateDelete(item.KeyID);
                    if (!string.IsNullOrEmpty(_error))
                        return BadRequest(_error);
                }
                return base.DeleteEntities(entities);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public override IActionResult DeleteEntities([FromQuery] int[] id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            string _error = string.Empty;
            foreach (var item in id)
            {
                _error = ValidateDelete(item);
                if (!string.IsNullOrEmpty(_error))
                    return BadRequest(_error);
            }
            return base.DeleteEntities(id);
        }


        public int GetIdUser()
        {
            try
            {
                int _id = 0;
                if (HttpContext.Request.Headers.ContainsKey("Authorization"))
                {
                    string token = HttpContext.Request.Headers["Authorization"];
                    if (token.StartsWith("Bearer "))
                        token = token.Split(' ')[1];

                    Debug.WriteLine(HttpContext.Request.Headers["Authorization"]);
                    var jwt = new JwtSecurityToken(token);
                    Debug.WriteLine(jwt.Payload.Exp);
                    jwt = new JwtSecurityToken
                            (
                                issuer: _options.Issuer,
                                audience: _options.Audience,
                                claims: jwt.Claims,
                                notBefore: DateTime.UtcNow,
                                expires: DateTime.UtcNow.Add(_options.Expiration),
                                signingCredentials: _options.SigningCredentials
                            );
                    var _user = jwt.Claims.FirstOrDefault<Claim>().Value;
                    var _acc = Instance.Context.eTaiKhoan.Where(n => n.AccCode.ToLower() == _user.ToLower());
                    if (_acc.Count() > 0)
                    {
                        _id = _acc.FirstOrDefault<eTaiKhoan>().KeyID;
                    }
                    return _id;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;

            }
        }

        #region validate    
        public string ValidateAddOrUpdate(eDm_nhomhhvt _nhomhhvt, bool isUpdate)
        {
            string _error = string.Empty;
            if (_nhomhhvt == null)
            {
                return _error = "Nhóm hàng hóa vật tư không hợp lệ!";
            }
            if (string.IsNullOrEmpty(_nhomhhvt.MaNhomHHVT))
            {
                return _error = "Mã nhóm hàng hóa vật tư không hợp lệ!";
            }
            else
            {
                if (isUpdate == false)
                {
                    if (Instance.Context.eDm_nhomhhvt.Any(n => n.MaNhomHHVT.ToLower() == _nhomhhvt.MaNhomHHVT.ToLower()))
                    {
                        return _error = "Mã nhóm hàng hóa vật tư đã tồn tại!";
                    }
                }
                else
                {
                    var _temp = Instance.Context.eDm_nhomhhvt.Where(n => n.MaNhomHHVT.ToLower() == _nhomhhvt.MaNhomHHVT.ToLower() && n.KeyID != _nhomhhvt.KeyID);
                    if (_temp.Count() > 0)
                    {
                        return _error = "Mã nhóm hàng hóa vật tư đã tồn tại!";
                    }
                }
            }
            if (string.IsNullOrEmpty(_nhomhhvt.TenNhom))
            {
                return _error = "Tên nhóm hàng hóa vật tư không hợp lệ!";
            }
            return _error;
        }

        public string ValidateDelete(int _keyId)
        {
            string _error = string.Empty;
            if(_keyId <= 0)
            {
                return _error = "KeyId không hợp lệ!";
            }
            if(Instance.Context.eDm_nhomhhvt.Where(n=>n.KeyID == _keyId).Count() == 0)
            {
                return _error = "Nhóm hàng hóa vật tư không tồn tại!";
            }
            //if(Instance.Context.eDm_vthh.Any(n=>n.KeyID
            return _error;
        }
        #endregion
    }
}
