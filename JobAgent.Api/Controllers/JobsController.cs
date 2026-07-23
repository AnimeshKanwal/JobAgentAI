using JobAgent.Api.DTOs;
using JobAgent.Core.Entities;
using JobAgent.Core.Interfaces;
using JobAgent.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobAgent.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobsController(IJobService jobService)
    {
        _jobService = jobService;
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

        var createdJob = await _jobService.CreateAsync(job);

        return Ok(createdJob);
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var jobs = await _jobService.GetAllAsync();

        return Ok(jobs);
    }
}