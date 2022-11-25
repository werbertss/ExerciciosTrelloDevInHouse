using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface INotasMateriaRepositorio
    {
        NotasMateria ObterPorId(Guid id);
        NotasMateria ObterPorBoletim(string boletim);
        void Inserir(NotasMateria notasMateria);
        void Excluir(NotasMateria notasMateria);
        void Atualizar(NotasMateria notasMateria);
        bool ExisteNotasMateria(int notasMateria);
        public int ObterTotal();
    }
}
