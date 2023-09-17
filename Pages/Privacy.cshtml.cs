using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet() //Get
    {
        ViewData["Name"] = "John Smith";
    }

    public void OnPut() //Update
    {
    }

    public void OnPost() //Insert
    {
    }

    public void OnDelete() //Delete
    {
    }

}

