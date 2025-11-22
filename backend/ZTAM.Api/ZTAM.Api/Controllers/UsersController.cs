using System;
using Microsoft.AspNetCore.Mvc;
using ZTAM.Api.Data;
using ZTAM.Api.Models;

namespace ZTAM.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ZTAMContext _context;

    public UsersController(ZTAMContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_context.Users.ToList());
    }
}
