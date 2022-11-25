using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services
{
    public interface INotasMateriaServico
    {
        NotasMateriaDTO ObterPorId(Guid id);
        NotasMateriaDTO ObterPorBoletim(string boletim);
        void Inserir(NotasMateriaDTO notasMateria);
        void Excluir(Guid id);
        void Atualizar(NotasMateriaDTO notasMateria);
        public int ObterTotal();
    }
}
