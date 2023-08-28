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

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                var contatto = contattiService.Add(Contatto);
                //redirect alla pagina di elenco
                //return RedirectToPage("/Contatti/Index");

                //redirect alla pagina di dettaglio
                return RedirectToPage("/Contatti/Dettaglio", new { id = contatto.Id });
            }
            return Page();            
        }
    }
}
