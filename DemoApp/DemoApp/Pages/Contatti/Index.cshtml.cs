using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class IndexModel : PageModel
    {
        public IList<Contatto> Contatti { get; set; }

        public void OnGet()
        {
            Contatti = ContattiProvider.Contatti;
        }
    }
}
