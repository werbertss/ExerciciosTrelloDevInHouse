using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services
{
    public interface IMateriaServico
    {
        IList<MateriaDTO> ObterTodos(Paginacao paginacao);
        MateriaDTO ObterPorId(Guid id);
        MateriaDTO ObterPorNome(string Nome);
        void Inserir(MateriaDTO materia);
        void Excluir(Guid id);
        void Atualizar(MateriaDTO materia);
        public int ObterTotal();
    }
}
