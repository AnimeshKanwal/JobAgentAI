namespace JobAgent.Api.DTOs;

public class CreateJobRequest
{
    public string Title { get; set; } = string.Empty;

    public string Company { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;
}