using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;

namespace Escola.Domain.Models
{
    public class NotasMateria
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int BoletimId { get; set;}
        public int MateriaId { get; set;}
        public int Nota { get; set;}

        public NotasMateria(NotasMateriaDTO notasMateria)
        {
            Id = notasMateria.Id;
            BoletimId = notasMateria.BoletimId;
            MateriaId = notasMateria.MateriaId;
            Nota = notasMateria.Nota;
        }

        public NotasMateria()
        {

        }
    }
}
