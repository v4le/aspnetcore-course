using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;

namespace DemoApp.Pages.Contatti
{
    public class DettaglioModel : PageModel
    {
        private readonly IContattiService contattiService;
        private readonly IMemoryCache memoryCache;

        public Contatto Contatto { get; set; }

        public DettaglioModel(IContattiService contattiService, IMemoryCache memoryCache) 
        {
            this.contattiService = contattiService;
            this.memoryCache = memoryCache;
        }

        public void OnGet(int id)
        {
            if (!memoryCache.TryGetValue($"Contatto_{id}", out Contatto contatto))
            {
                // Se i dettagli del contatto non sono nella cache, li carico tramite il servizio
                contatto = contattiService.GetContatto(id);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromSeconds(20),
                    //AbsoluteExpiration = new DateTime(2023, 09, 14, 15, 0, 0)
                };

                memoryCache.Set($"Contatto_{id}", contatto, cacheEntryOptions);
            }

            Contatto = contatto;
        }
    }
}
