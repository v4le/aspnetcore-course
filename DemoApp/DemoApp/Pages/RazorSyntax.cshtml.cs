using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
    public class RazorSyntaxModel : PageModel
    {
        public void OnGet()
        {
        }
    }

    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Anni { get; set; }
    }
}
