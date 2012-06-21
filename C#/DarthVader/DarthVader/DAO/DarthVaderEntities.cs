//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Data.Entity;
using DarthVader.Model;

namespace DarthVader.DAO
{
    class DarthVaderEntities : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogo>().ToTable("Jogos");
            modelBuilder.Entity<Emprestimo>().ToTable("Emprestimos");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Jogo> Jogos { set; get; }
        public DbSet<Emprestimo> Emprestimos { set; get; }
    }
}