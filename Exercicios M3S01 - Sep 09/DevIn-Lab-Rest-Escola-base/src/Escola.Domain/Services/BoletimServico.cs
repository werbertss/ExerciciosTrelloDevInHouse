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
    public class BoletimServico : IBoletimServico
    {
        private readonly IBoletimRepositorio _boletimRepositorio;

        public void Atualizar(BoletimDTO boletim)
        {
            var boletimDb = _boletimRepositorio.ObterPorId(boletim.Id);
        }

        public void Excluir(Guid id)
        {
            var boletim = _boletimRepositorio.ObterPorId(id);
            _boletimRepositorio.Excluir(boletim);
        }

        public void Inserir(BoletimDTO boletim)
        {
            _boletimRepositorio.Inserir(new Boletim(boletim));
        }

        public BoletimDTO ObterPorId(Guid id)
        {
            return new BoletimDTO(_boletimRepositorio.ObterPorId(id));
        }
        public BoletimDTO ObterPorAluno(string Nome)
        {
            return new BoletimDTO(_boletimRepositorio.ObterPorAluno(Nome));
        }

        public int ObterTotal()
        {
            throw new NotImplementedException();
        }
    }
}
