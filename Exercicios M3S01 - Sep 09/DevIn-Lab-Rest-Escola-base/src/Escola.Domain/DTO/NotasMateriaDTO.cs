using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.DTO
{
    public class NotasMateriaDTO
    {

        public NotasMateriaDTO()
        {

        }

        public NotasMateriaDTO(NotasMateria notasMateria)
        {
            Id = notasMateria.Id;
            BoletimId = notasMateria.BoletimId;
            MateriaId = notasMateria.MateriaId;
            Nota = notasMateria.Nota;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public int BoletimId { get; set; }
        public int MateriaId { get; set; }
        public int Nota { get; set; }
    }
}
