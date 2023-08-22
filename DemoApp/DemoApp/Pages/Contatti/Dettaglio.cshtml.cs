using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class DettaglioModel : PageModel
    {
        private readonly ContattiService contattiService;

        public Contatto Contatto { get; set; }

        public DettaglioModel(ContattiService contattiService) 
        {
            this.contattiService = contattiService;
        }

        public void OnGet(int id)
        {
            Contatto = contattiService.GetContatto(id);
        }
    }
}
