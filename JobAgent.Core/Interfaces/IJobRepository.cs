using JobAgent.Core.Entities;
namespace JobAgent.Core.Interfaces
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllAsync();
        Task<Job> CreateAsync(Job job);
        Task<bool> ExistsByUrlAsync(string url);
    }
}
