using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Models;

namespace Razor1.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    [BindProperty]
    public int Year { get; set; }
    public string ZodiacSign { get; set; }

       

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet() //Get
    {
        
    }

    public void OnPut() //Update
    {
    }

      public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ZodiacSign = Utils.GetZodiac(Year);
                return Page();
            }
            else
            {
                return Page();
            }
        }

    public void OnDelete() //Delete
    {
    }
     

}

