using GenerarPares.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GenerarPares.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Objeto Objeto { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            for (int i = 0; i <= Objeto.Numero; i++)
            {
                if (i % 2 == 0)
                    Objeto.Resultado += i.ToString() + " ";
            }

            return Page();
        }
    }
}