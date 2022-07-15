using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Creche.Models
{
    public class CrecheContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Creche;Uid=root;Pwd=;");
        }

        public DbSet<Informacao> Informacaos {get;set;}
    }
}