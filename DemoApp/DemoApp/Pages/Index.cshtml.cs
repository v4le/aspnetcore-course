using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment;

        public string Config { get; set; }
        public string Environment { get; set; }

        public IndexModel(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            this.configuration = configuration;
            this.webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            Config = configuration["ConnectionStrings:MyConnectionString"];
            Environment = webHostEnvironment.EnvironmentName;
        }
    }
}