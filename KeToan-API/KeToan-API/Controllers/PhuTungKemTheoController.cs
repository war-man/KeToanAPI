using API.Core;
using API.Services;
using KeToan;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("KeToan/[controller]")]
    public class PhuTungKemTheoController : ControllerTemplate<eCt_ctts>
    {
        public PhuTungKemTheoController(IRepositoryCollection collection) : base(collection)
        {
        }
    }
}
