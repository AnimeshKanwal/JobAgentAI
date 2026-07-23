using JobAgent.Core.Entities;
using JobAgent.Core.Exceptions;
using JobAgent.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAgent.Application.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _repository;

        public JobService(IJobRepository repository)
        {
            _repository = repository;
        }
        public async Task<Job> CreateAsync(Job job)
        {
            var exists = await _repository.ExistsByUrlAsync(job.Url);

            if (exists)
            {
                throw new DuplicateJobException(job.Url);
            }

            return await _repository.CreateAsync(job);
        }

        public async Task<List<Job>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

    }
}
