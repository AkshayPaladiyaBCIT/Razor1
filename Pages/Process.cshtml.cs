using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor1.Pages
{
    public class ProcessModel : PageModel
    {
       
        private readonly ILogger<ProcessModel> _logger;
         [BindProperty]
        public Process[]? Processes { get; set; }


        public ProcessModel(ILogger<ProcessModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Processes = Process.GetProcesses();
            
        }
    }
}