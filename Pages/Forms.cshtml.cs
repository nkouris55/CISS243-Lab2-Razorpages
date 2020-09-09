using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Kouris_CISS243_Lab2_1.Pages
{
    public class FormsModel : PageModel
    {
        private readonly ILogger<FormsModel> _logger;

        public FormsModel(ILogger<FormsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
