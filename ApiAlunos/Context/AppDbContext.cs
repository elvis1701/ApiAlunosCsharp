using ApiAlunos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlunos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                   new Aluno
                   {
                       Id = 1,
                       Nome = "Elvis Alves da Silva",
                       Email = "elvis.alves2017@gmail.com",
                       Idade = 24
                   },
                   new Aluno
                   {
                       Id = 2,
                       Nome = "Mislene Ramalho de Paula",
                       Email = "mislene@gmail.com",
                       Idade = 27
                   }

                );
        }
    }
}
