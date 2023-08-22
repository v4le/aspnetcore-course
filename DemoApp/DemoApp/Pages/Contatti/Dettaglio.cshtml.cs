using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class DettaglioModel : PageModel
    {
        public Contatto Contatto { get; set; }

        public void OnGet(int id)
        {
            Contatto = ContattiProvider.Contatti.Single(c => c.Id == id);
        }
    }
}
