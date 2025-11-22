using System;
using Microsoft.AspNetCore.Mvc;
using ZTAM.Api.Data;
using ZTAM.Api.Models;

namespace ZTAM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController : ControllerBase
    {
        private readonly ZTAMContext _context;

        public PermissionController(ZTAMContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreatePermission(Permission permission)
        {
            _context.Permissions.Add(permission);
            _context.SaveChanges();
            return Ok(permission);
        }

        [HttpGet]
        public IActionResult GetPermissions()
        {
            return Ok(_context.Permissions.ToList());
        }
    }
}
