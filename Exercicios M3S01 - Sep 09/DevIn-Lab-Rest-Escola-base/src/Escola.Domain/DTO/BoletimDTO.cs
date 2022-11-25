using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.DTO
{
    public class BoletimDTO
    {
        public BoletimDTO()
        {

        }

        public BoletimDTO(Boletim boletim)
        {
            Id = boletim.Id;
            AlunoId = boletim.AlunoId;
            orderDate = boletim.orderDate;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public int AlunoId { get; set; }
        public DateTime orderDate { get; set; }

    }
}
