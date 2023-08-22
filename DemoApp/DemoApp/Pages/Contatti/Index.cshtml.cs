using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class IndexModel : PageModel
    {
        private readonly IContattiService contattiService;

        public IList<Contatto> Contatti { get; set; }
        public int TotalCount { get; set; }
        public int FilteredCount { get; set; }

        [BindProperty]
        public string SearchText { get; set; }

        public IndexModel(IContattiService contattiService)
        {
            this.contattiService = contattiService;
        }

        public void OnGet()
        {
            Contatti = contattiService.GetContatti();

            TotalCount = FilteredCount = Contatti.Count;
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                Contatti = contattiService.Search(SearchText);
            }
            else
            {
                Contatti = contattiService.GetContatti();
            }

            TotalCount = contattiService.GetContattiCount();
            FilteredCount = Contatti.Count;
        }
    }
}
