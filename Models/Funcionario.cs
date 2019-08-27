using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        public string Name { get; set; }

        public int EspecialidadeId { get; set; }

        public virtual Especialidade especialidade { get; set; }
    }
}