/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Bancos
 * https://www.youtube.com/watch?v=nvPOUdz5PL4
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
    public class BancosDbContext : DbContext
    {
        public BancosDbContext() : base(nameOrConnectionString: "ConnecBancos")
        { 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<EmpClass> Empobj { get; set; }

        public virtual DbSet<Bancaria> Bancarias { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }
    }
}
