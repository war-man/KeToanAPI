using API.Utils;
using KeToan;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.TokenProvider
{
    public class TokenProviderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly TokenProviderOptions _options;
        private readonly ILogger _logger;
        private readonly zModel _db;

        public TokenProviderMiddleware(RequestDelegate next, IOptions<TokenProviderOptions> options, ILoggerFactory logger, zModel db)
        {
            _next = next;
            _options = options.Value;
            _logger = logger.CreateLogger("TokenProviderMiddleware");
            _db = db;
        }

        public Task Invoke(HttpContext context)
        {
            if (!context.Request.Path.Equals(_options.Path, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    if (context.Request.Headers.ContainsKey("Authorization"))
                    {
                        string token = context.Request.Headers["Authorization"];
                        if (token.StartsWith("Bearer "))
                            token = token.Split(' ')[1];

                        if (TokenHelper.DictionaryToken.Any(n => n.Value.Equals(token)))
                        {
                            var jwt = new JwtSecurityToken(token);
                            var _tk = jwt.Claims.GetValue<eTaiKhoan>(JwtRegisteredClaimNames.Aud);
                            if (_tk != null)
                            {
                                var role = new zModel().eQuyen.Where(n => n.PhanQuyenID == _tk.PhanQuyenID).Select(n => n.xChucNang);

                                string path = context.Request.Path.Value.Trim().ToLower();
                                if (path.Contains("?"))
                                    path = path.Split('?')[0].Trim();

                                if (role.Any(n =>
                                    n.Route.Equals(path) &&
                                    n.Methods.Equals(context.Request.Method.Trim(), StringComparison.OrdinalIgnoreCase)))
                                {
                                    context.Response.Headers.Remove("Authorization");
                                    var encodedJwt = jwt.RefeshToken();
                                    context.Response.Headers.Add("Authorization", "Bearer " + encodedJwt);
                                    return _next(context);
                                }
                            }
                        }
                        context.Response.StatusCode = 401;
                        return context.Response.WriteAsync("Unauthorized");
                    }
                }
                catch
                {
                    context.Response.StatusCode = 401;
                    return context.Response.WriteAsync("Unauthorized");
                }
            }

            // Request must be POST with Content-Type: application/x-www-form-urlencoded
            if (!context.Request.Method.Equals("POST") || !context.Request.HasFormContentType)
            {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Bad request.");
            }

            return GenerateToken(context);
        }

        private async Task GenerateToken(HttpContext context)
        {
            ClaimsIdentity identity = null;

            try
            {
                var username = context.Request.Form["username"].ToString();
                var password = context.Request.Form["password"].ToString();
                var _tk = _db.eTaiKhoan.FirstOrDefault(n => n.AccCode.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) && n.Password.Equals(password.Encrypt()));
                
                identity = await GetIdentity(_tk);
            }
            catch { }

            if (identity == null)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid username or password.");
                return;
            }

            var jwt = identity.CreateToken();
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                expires_in = (int)_options.Expiration.TotalSeconds
            };

            // Serialize and return the response
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            }));
        }

        private Task<ClaimsIdentity> GetIdentity(eTaiKhoan _taikhoan)
        {
            List<Claim> _claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Aud, JsonConvert.SerializeObject(_taikhoan)),
                new Claim(JwtRegisteredClaimNames.Sid, _taikhoan.KeyID.ToString(), ClaimValueTypes.Integer64),
                new Claim(JwtRegisteredClaimNames.Sub, _taikhoan.AccCode.ToLower()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.TimeOfDay.ToString(), ClaimValueTypes.Integer64)
            };
            var _generic = new System.Security.Principal.GenericIdentity(_taikhoan.AccCode.ToLower(), "Token");
            var _identity = new ClaimsIdentity(_generic, _claims);
            return Task.FromResult(_identity);
        }
    }
}