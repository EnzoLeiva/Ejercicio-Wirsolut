using Ejercicio_Wirsolut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_Wirsolut.Data
{
    public class ClienteContext: DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options): base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
