using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        public string Config { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnGet()
        {
            Config = configuration["ConnectionStrings:MyConnectionString"];
        }
    }
}