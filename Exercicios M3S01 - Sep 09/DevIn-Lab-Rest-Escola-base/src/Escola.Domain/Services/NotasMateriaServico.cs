using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Exceptions;

namespace Escola.Domain.Services
{
    public class NotasMateriaServico : INotasMateriaServico
    {
        private readonly INotasMateriaRepositorio _notasMateriaRepositorio;

        public void Atualizar(NotasMateriaDTO notasMateria)
        {
            var notasmateriaDb = _notasMateriaRepositorio.ObterPorId(notasMateria.Id);
        }

        public void Excluir(Guid id)
        {
            var notasmateri = _notasMateriaRepositorio.ObterPorId(id);
            _notasMateriaRepositorio.Excluir(notasmateri);
        }

        public void Inserir(NotasMateriaDTO notasMateria)
        {
            _notasMateriaRepositorio.Inserir(new NotasMateria(notasMateria));
        }

        public NotasMateriaDTO ObterPorBoletim(string boletim)
        {
            return new NotasMateriaDTO(_notasMateriaRepositorio.ObterPorBoletim(boletim));
        }

        public NotasMateriaDTO ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public int ObterTotal()
        {
            throw new NotImplementedException();
        }
    }
}
