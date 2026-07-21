namespace JobAgent.Core.Entities;

public class Job
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Company { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public bool IsApplied { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}