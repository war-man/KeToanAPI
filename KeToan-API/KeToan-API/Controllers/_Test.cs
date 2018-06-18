using API.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [AllowAnonymous]
    public class Test : Controller
    {
        private readonly Services.IRepositoryCollection Collection;
        public Test(Services.IRepositoryCollection collection)
        {
            Collection = collection;
        }
        //[Route("Client")]
        //public IEnumerable<KeToan.eBangCap> GetList()
        //{
        //    List<eBangCap> lst = new List<eBangCap>();
        //    for(int ix = 1; ix < 10; ix ++)
        //    {
        //        lst.Add(new eBangCap()
        //        {
        //            KeyID = ix,
        //            MaBangCap = new System.Guid().ToString()
        //        });
        //    }
        //    return lst;
        //}

        [Route("test")]
        public IActionResult Get()
        {
            return Ok();
        }

        [Route("testcall")]
        public IActionResult GetTest()
        {
            string ad = " New name";
            return Ok(new { Name = "Test Call" + ad, Message = "Access AllowAnonymous Method" });
        }

        [Route("encryptstring")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult GetConnectString([FromBody] string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var oRe = new { Input = input, Encrypt = input.Encrypt() };
                return Ok(oRe);
            }
            return BadRequest();
        }
    }
}
