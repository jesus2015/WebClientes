using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebClientes.Models;

namespace WebClientes.Data
{
    public class WebClientesContext : DbContext
    {
        public WebClientesContext (DbContextOptions<WebClientesContext> options)
            : base(options)
        {
        }

        public DbSet<WebClientes.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<WebClientes.Models.Usuario>? Usuario { get; set; }
    }
}
