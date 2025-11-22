using Microsoft.AspNetCore.Mvc;
using ZTAM.Api.Data;
using ZTAM.Api.Models;

namespace ZTAM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccessLogsController : ControllerBase
    {
        private readonly ZTAMContext _context;

        public AccessLogsController(ZTAMContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateAccessLog(AccessLog log)
        {
            _context.AccessLogs.Add(log);
            _context.SaveChanges();
            return Ok(log);
        }

        [HttpGet]
        public IActionResult GetAccessLogs()
        {
            return Ok(_context.AccessLogs.ToList());
        }
    }
}