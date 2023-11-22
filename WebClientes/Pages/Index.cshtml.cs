using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebClientes.Models;

namespace WebClientes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebClientes.Data.WebClientesContext _context;
        [BindProperty]
        public Usuario usuario{ get; set; } = default!;
        public IndexModel(WebClientes.Data.WebClientesContext context)
        {
            _context = context;
        }

        
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            
        }
    }
}