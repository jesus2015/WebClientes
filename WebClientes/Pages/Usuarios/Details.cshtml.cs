using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebClientes.Data;
using WebClientes.Models;

namespace WebClientes.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly WebClientes.Data.WebClientesContext _context;

        public DetailsModel(WebClientes.Data.WebClientesContext context)
        {
            _context = context;
        }

      public Usuario Usuario { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            else 
            {
                Usuario = usuario;
            }
            return Page();
        }
    }
}
