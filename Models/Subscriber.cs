namespace Newsletter.Models;

public class Subscriber
{
    public required string Id { get; set; }   // Unique identifier for the subscriber
    public string? Name { get; set; }        // Name of the subscriber
    public required string Email { get; set; } // Email of the subscriber
}
