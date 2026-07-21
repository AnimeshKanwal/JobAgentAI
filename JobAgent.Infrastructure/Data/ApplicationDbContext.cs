using JobAgent.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JobAgent.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Job> Jobs => Set<Job>();
}