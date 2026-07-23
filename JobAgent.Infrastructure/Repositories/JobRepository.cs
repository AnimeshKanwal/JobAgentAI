using JobAgent.Core.Entities;
using JobAgent.Core.Interfaces;
using JobAgent.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAgent.Infrastructure.Repositories
{
   public  class JobRepository : IJobRepository
    {
        private readonly ApplicationDbContext _context;
        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Job> CreateAsync(Job job)
        {
            _context.Jobs.Add(job);

            await _context.SaveChangesAsync();

            return job;
        }

        public async Task<List<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }
        public async Task<bool> ExistsByUrlAsync(string url)
        {
            return await _context.Jobs.AnyAsync(j => j.Url == url);
        }
    }
}
