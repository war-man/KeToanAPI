using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace API.TokenProvider
{
    public static class TokenHelper
    {
        static readonly string issuerKey = @"H@oe*gJ=A=W9h+*^4q~S*#%yrnqxD#u?SNp/2&^EuFS/4w'SCGrY:U7vjJ3b,'QKf.quPqW:;VA8_374':5GHs$=+N;m8r/v/9ED4;Y+%,2Fr/*5-fE,er=/";
        static readonly string audienceKey = @"KW&M(nvpJ~J;p2&h.6+.W#SduYX&BvFEj~Nb5,`cUK('^C)[zePdnf4A3YJ5Ek'VB{,sp#w=@>RmaMArF$r!wM@X2)t>v/4S$fcEj's/2Xf&>DgN:`>^?D~o";
        static readonly string secretKey = @"h:R:AgogGUP9p#o4!{ndZu`Uz#C}9wh((mpo(JdWV@k]EwQiJK#]SUMB./o%2YD-`MWp~tqRWK$2KDA*%'Su&[qW3XxVmjA%t@mVnv)nsm[42FazAn6aC3!zmmMVAnV[2)WhE$2Zn'T]Ni2}>xM5cC";
        static readonly SymmetricSecurityKey signingKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(secretKey));
        public static IOptions<TokenProviderOptions> JwtOptions()
        {
            var options = new TokenProviderOptions
            {
                Issuer = issuerKey,
                Audience = audienceKey,
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256),
            };
            return Options.Create(options);
        }

        public static Microsoft.AspNetCore.Builder.JwtBearerOptions BearerOption()
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                // The signing key must match!
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                // Validate the JWT Issuer (iss) claim
                ValidateIssuer = true,
                ValidIssuer = issuerKey,

                // Validate the JWT Audience (aud) claim
                ValidateAudience = true,
                ValidAudience = audienceKey,

                // Validate the token expiry
                ValidateLifetime = true,

                // If you want to allow a certain amount of clock drift, set that here:
                ClockSkew = TimeSpan.Zero
            };
            return new Microsoft.AspNetCore.Builder.JwtBearerOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                TokenValidationParameters = tokenValidationParameters
            };
        }

        public static JwtSecurityToken CreateToken(this ClaimsIdentity Identity)
        {
            if (Identity != null && Identity.Claims.Count() > 0)
            {
                var _token = new JwtSecurityToken(
                    issuer: JwtOptions().Value.Issuer,
                    audience: JwtOptions().Value.Audience,
                    claims: Identity.Claims,
                    notBefore: DateTime.UtcNow,
                    expires: DateTime.UtcNow.Add(JwtOptions().Value.Expiration),
                    signingCredentials: JwtOptions().Value.SigningCredentials);
                if (DictionaryToken.Any(n => n.Key.Equals(_token.Subject, StringComparison.OrdinalIgnoreCase)))
                    DictionaryToken[_token.Subject] = new JwtSecurityTokenHandler().WriteToken(_token);
                else
                    DictionaryToken.Add(_token.Subject, new JwtSecurityTokenHandler().WriteToken(_token));
                return _token;
            }
            return null;
        }

        public static string RefeshToken(this JwtSecurityToken jwt)
        {
            if (DictionaryToken.Any(n => n.Key.Equals(jwt.Subject, StringComparison.OrdinalIgnoreCase)) && jwt.ValidTo > DateTime.UtcNow)
            {
                jwt = new JwtSecurityToken(
                    issuer: JwtOptions().Value.Issuer,
                    audience: JwtOptions().Value.Audience,
                    claims: jwt.Claims,
                    notBefore: DateTime.UtcNow,
                    expires: DateTime.UtcNow.Add(JwtOptions().Value.Expiration),
                    signingCredentials: JwtOptions().Value.SigningCredentials);
                return DictionaryToken[jwt.Subject] = new JwtSecurityTokenHandler().WriteToken(jwt);
            }

            //Token Expirated
            if (DictionaryToken.Any(n => n.Key.Equals(jwt.Subject, StringComparison.OrdinalIgnoreCase)))
                DictionaryToken.Remove(DictionaryToken.FirstOrDefault(n => n.Key.Equals(jwt.Subject, StringComparison.OrdinalIgnoreCase)).Key);
            return null;
        }

        public static T GetValue<T>(this IEnumerable<Claim> claims, string Type = "") where T : class, new()
        {
            try
            {
                var get = claims.FirstOrDefault(n => n.Type.Equals(Type));
                if (get != null)
                {
                    return JsonConvert.DeserializeObject<T>(get.Value);
                }
                return null;
            }
            catch { return null; }
        }

        private static Dictionary<string, string> _dicToken = new Dictionary<string, string>();
        public static Dictionary<string, string> DictionaryToken
        {
            get { return _dicToken; }
            set { _dicToken = value; }
        }
    }
}