using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class CreaModel : PageModel
    {
        private readonly IContattiService contattiService;

        [BindProperty]
        public Contatto Contatto { get; set; }

        public CreaModel(IContattiService contattiService) 
        {
            this.contattiService = contattiService;
        }

        public void OnPost() 
        {
            contattiService.Add(Contatto);
        }
    }
}
