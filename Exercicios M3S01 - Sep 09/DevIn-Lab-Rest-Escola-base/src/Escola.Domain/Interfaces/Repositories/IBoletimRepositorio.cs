using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IBoletimRepositorio
    {
        Boletim ObterPorId(Guid id);
        Boletim ObterPorAluno(string nome);
        void Inserir(Boletim boletim);
        void Excluir(Boletim boletim);
        void Atualizar(Boletim boletim);
        bool ExisteBoletim(int boletim);
        public int ObterTotal();
    }
}
