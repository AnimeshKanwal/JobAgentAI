using JobAgent.Api.DTOs;
using JobAgent.Core.Entities;
using JobAgent.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobAgent.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public JobsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateJobRequest request)
    {
        var job = new Job
        {
            Title = request.Title,
            Company = request.Company,
            Location = request.Location, 
            Url = request.Url
        };

        _context.Jobs.Add(job);

        await _context.SaveChangesAsync();

        return Ok(job);
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var jobs = await _context.Jobs.ToListAsync();

        return Ok(jobs);
    }
}