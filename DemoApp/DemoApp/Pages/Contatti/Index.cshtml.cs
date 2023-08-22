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
            Contatti = new ContattiService().GetContatti();

            TotalCount = FilteredCount = Contatti.Count;
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                Contatti = new ContattiService().Search(SearchText);
            }
            else
            {
                Contatti = new ContattiService().GetContatti();
            }

            TotalCount = new ContattiService().GetContattiCount();
            FilteredCount = Contatti.Count;
        }
    }
}
