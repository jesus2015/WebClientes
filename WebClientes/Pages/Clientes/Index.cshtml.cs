using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClientes.Data;
using WebClientes.Models;

namespace WebClientes.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly WebClientes.Data.WebClientesContext _context;

        public IndexModel(WebClientes.Data.WebClientesContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cliente != null)
            {
                Cliente = await _context.Cliente.ToListAsync();
            }
        }
    }
}
