using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Especialidade> Especialidades { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Funcionario> Funcionarios { get; set; }
    }
}