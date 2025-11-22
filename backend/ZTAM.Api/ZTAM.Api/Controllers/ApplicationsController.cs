using System;
using Microsoft.AspNetCore.Mvc;
using ZTAM.Api.Data;
using ZTAM.Api.Models;

namespace ZTAM.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicationsController : ControllerBase
{
    private readonly ZTAMContext _context;

    public ApplicationsController(ZTAMContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateApplication(ApplicationEntity app)
    {
        _context.Applications.Add(app);
        _context.SaveChanges();
        return Ok(app);
    }

    [HttpGet]
    public IActionResult GetApplications()
    {
        return Ok(_context.Applications.ToList());
    }
}
