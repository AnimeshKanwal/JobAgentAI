using JobAgent.Core.Entities;

namespace JobAgent.Core.Interfaces;

public interface IJobService
{
    Task<List<Job>> GetAllAsync();

    Task<Job> CreateAsync(Job job);
}