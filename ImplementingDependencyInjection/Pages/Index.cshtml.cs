using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImplementingDependencyInjection.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string Date { get; set; }
    private readonly IDate _date;

    public IndexModel(ILogger<IndexModel> logger, IDate date)
    {
        _logger = logger;
        _date = date;
    }

    public void OnGet()
    {
        // We don't need to create an instance of ShortDate inside the method
        // To implement dependency injection in our application we need:
        // 1- Implement constructor injection
        // 2- Create an abstraction of the service
        // 3- Register the service in the Dependency Injection container
        
        // var _shortDate = new ShortDate();
        var date = _date.GetDate();
        Date = date;
    }
}