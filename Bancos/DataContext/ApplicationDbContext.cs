/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Bancos
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Bancos.Models;

namespace Bancos.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "ConnecBancos")
        { }

        public virtual DbSet<EmpClass> Empobj { get; set; }

        public virtual DbSet<Bancaria> BancariaObj { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }
    }
}
