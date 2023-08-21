using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class IndexModel : PageModel
    {
        public IList<Contatto> Contatti { get; set; }
        public int TotalCount { get; set; }
        public int FilteredCount { get; set; }

        [BindProperty]
        public string SearchText { get; set; }

        public void OnGet()
        {
            Contatti = ContattiProvider.Contatti;

            TotalCount = FilteredCount = Contatti.Count;
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

            TotalCount = ContattiProvider.Contatti.Count;
            FilteredCount = Contatti.Count;
        }
    }
}
