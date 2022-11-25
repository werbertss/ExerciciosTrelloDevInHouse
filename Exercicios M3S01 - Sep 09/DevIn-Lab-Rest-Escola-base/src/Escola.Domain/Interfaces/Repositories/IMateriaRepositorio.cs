using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IMateriaRepositorio
    {
        IList<Materia> ObterTodos(Paginacao paginacao);
        Materia ObterPorId(Guid id);
        Materia ObterPorNome(string Nome);
        void Inserir(Materia materia);
        void Excluir(Materia materia);
        void Atualizar(Materia materia);
        public int ObterTotal();
    }
}
