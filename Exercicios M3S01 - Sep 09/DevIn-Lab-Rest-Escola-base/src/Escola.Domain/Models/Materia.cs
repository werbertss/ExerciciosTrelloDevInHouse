using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;

namespace Escola.Domain.Models
{
    public class Materia
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

        public Materia(MateriaDTO materia)
        {
            Id = materia.Id;
            Nome = materia.Nome;
        }

        public Materia()
        {

        }

    }
}
