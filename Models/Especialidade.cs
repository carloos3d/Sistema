using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Especialidade
    {
        [Key]
        public int EspecialidadeId { get; set; }

        public string name { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

    }
}