using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;

        public IndexModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnGet()
        {
            var config = configuration["ConnectionStrings:MyConnectionString"];
        }
    }
}