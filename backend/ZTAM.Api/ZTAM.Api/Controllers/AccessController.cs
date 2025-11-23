using Microsoft.AspNetCore.Mvc;
using ZTAM.Api.Data;
using ZTAM.Api.Models;

namespace ZTAM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccessController : ControllerBase
    {
        private readonly ZTAMContext _context;

        public AccessController(ZTAMContext context)
        {
            _context = context;
        }

        public class AccessCheckRequest
        {
            public int UserId { get; set; }
            public int AppId { get; set; }
        }

        [HttpPost("check")]
        public IActionResult CheckAccess([FromBody] AccessCheckRequest req)
        {
            // 1. Look up the permission
            var permission = _context.Permissions
                .FirstOrDefault(p => p.UserId == req.UserId && p.AppId == req.AppId);

            string result = (permission != null && permission.Action == "allow")
                ? "allowed"
                : "denied";

            // 2. Save an access log
            var log = new AccessLog
            {
                UserId = req.UserId,
                AppId = req.AppId,
                Result = result
            };

            _context.AccessLogs.Add(log);
            _context.SaveChanges();

            // 3. Return result to caller
            return Ok(new
            {
                access = result,
                userId = req.UserId,
                appId = req.AppId
            });
        }
    }
}
