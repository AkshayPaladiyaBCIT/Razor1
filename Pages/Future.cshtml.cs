using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor1.Pages
{
    public class FutureModel : PageModel
    {
        private readonly ILogger<FutureModel> _logger;

        public FutureModel(ILogger<FutureModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}