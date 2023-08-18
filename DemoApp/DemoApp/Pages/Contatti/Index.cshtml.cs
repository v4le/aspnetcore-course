using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class IndexModel : PageModel
    {
        public IList<Contatto> Contatti { get; set; }

        [BindProperty]
        public string SearchText { get; set; }

        public void OnGet()
        {
            Contatti = ContattiProvider.Contatti;
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                Contatti = ContattiProvider.Contatti.Where(c =>
                    c.Nome.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    c.Cognome.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                Contatti = ContattiProvider.Contatti;
            }
        }
    }
}
