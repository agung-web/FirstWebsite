using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FirstWebsite.Pages
{
    public class RekapModel : PageModel
    {
        private readonly ILogger<RekapModel> _logger;

        public RekapModel(ILogger<RekapModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
} 