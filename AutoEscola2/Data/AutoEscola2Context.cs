using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscola2.Models;

namespace AutoEscola2.Data
{
    public class AutoEscola2Context : DbContext
    {
        public AutoEscola2Context (DbContextOptions<AutoEscola2Context> options)
            : base(options)
        {
        }

        public DbSet<AutoEscola2.Models.Carro> Carro { get; set; } = default!;
        public DbSet<AutoEscola2.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<AutoEscola2.Models.Reserva> Reserva { get; set; } = default!;
    }
}
