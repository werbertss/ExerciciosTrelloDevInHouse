using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;

namespace Escola.Domain.Models
{
    public class Boletim
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int AlunoId { get; set; }
        public DateTime orderDate { get; set; }

        public Boletim(BoletimDTO boletim)
        {
            Id = boletim.Id;
            AlunoId = boletim.AlunoId;
            orderDate = boletim.orderDate;
        }
        
        public Boletim()
        {

        }
    }
}
