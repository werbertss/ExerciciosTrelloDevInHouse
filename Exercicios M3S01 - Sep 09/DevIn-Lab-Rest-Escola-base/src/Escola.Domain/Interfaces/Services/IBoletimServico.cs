using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services
{
    public interface IBoletimServico
    {
        BoletimDTO ObterPorId(Guid id);
        BoletimDTO ObterPorAluno(string nome);
        void Inserir(BoletimDTO boletim);
        void Excluir(Guid id);
        void Atualizar(BoletimDTO boletim);
        public int ObterTotal();
    }
}
