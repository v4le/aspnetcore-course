using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages.Contatti
{
    public class ModificaModel : PageModel
    {
        private readonly IContattiService contattiService;

        [BindProperty]
        public Contatto Contatto { get; set; }

        public ModificaModel(IContattiService contattiService)
        {
            this.contattiService = contattiService;
        }

        public void OnGet(int id)
        {
            Contatto = contattiService.GetContatto(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var contatto = contattiService.Aggiorna(Contatto);
                //redirect alla pagina di elenco
                //return RedirectToPage("/Contatti/Index");

                //redirect alla pagina di dettaglio
                return RedirectToPage("/Contatti/Dettaglio", new { id = contatto.Id });
            }
            return Page();
        }
    }
}
