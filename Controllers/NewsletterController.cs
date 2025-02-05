using Microsoft.AspNetCore.Mvc;
using Newsletter.Models;

namespace Newsletter.Controllers;

public class NewsletterController : Controller
{
    public IActionResult Index()
    {
        // Generate a mock subscriber for demonstration
        var subscriber = new Subscriber
        {
            Id = Guid.NewGuid().ToString(), // Generate unique GUID
            Name = "John Doe",
            Email = "john.doe@email.com"
        };
        
        // Log the creation of the subscriber (for debugging)
        Console.WriteLine($"Subscriber {subscriber.Name}, {subscriber.Email} with ID: {subscriber.Id} created");

        // Pass the subscriber to the view
        return View(subscriber);
    }
}
