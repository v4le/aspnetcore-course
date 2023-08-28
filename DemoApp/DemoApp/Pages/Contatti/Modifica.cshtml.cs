using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;

namespace DemoApp.Pages.Contatti
{
    public class ModificaModel : PageModel
    {
        private readonly IContattiService contattiService;
        private readonly IMemoryCache memoryCache;

        [BindProperty]
        public Contatto Contatto { get; set; }

        public ModificaModel(IContattiService contattiService, IMemoryCache memoryCache)
        {
            this.contattiService = contattiService;
            this.memoryCache = memoryCache;
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
                memoryCache.Remove($"Contatto_{contatto.Id}");

                //redirect alla pagina di elenco
                //return RedirectToPage("/Contatti/Index");

                //redirect alla pagina di dettaglio
                return RedirectToPage("/Contatti/Dettaglio", new { id = contatto.Id });
            }
            return Page();
        }
    }
}
