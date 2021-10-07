﻿using Ejercicio_Wirsolut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_Wirsolut.Data
{
    public class ClienteDbContext: DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options): base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
    }
}
