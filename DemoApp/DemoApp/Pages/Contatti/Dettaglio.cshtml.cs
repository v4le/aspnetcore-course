using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class DettaglioModel : PageModel
    {
        private readonly IContattiService contattiService;

        public Contatto Contatto { get; set; }

        public DettaglioModel(IContattiService contattiService) 
        {
            this.contattiService = contattiService;
        }

        public void OnGet(int id)
        {
            Contatto = contattiService.GetContatto(id);
        }
    }
}
