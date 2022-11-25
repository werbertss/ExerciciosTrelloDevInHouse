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
    public class MateriaServico : IMateriaServico
    {
        private readonly IMateriaRepositorio _materiaRepositorio;

        public MateriaServico(IMateriaRepositorio materiaRepositorio)
        {
            _materiaRepositorio = materiaRepositorio;
        }
        public void Atualizar(MateriaDTO materia)
        {
            var materiaDb = _materiaRepositorio.ObterPorId(materia.Id);
        }

        public void Excluir(Guid id)
        {
           var materia = _materiaRepositorio.ObterPorId(id);
            _materiaRepositorio.Excluir(materia);
        }

        public void Inserir(MateriaDTO materia)
        {
            _materiaRepositorio.Inserir(new Materia(materia));
        }

        public MateriaDTO ObterPorId(Guid id)
        {
            return new MateriaDTO(_materiaRepositorio.ObterPorId(id));
        }

        public MateriaDTO ObterPorNome(string Nome)
        {
            return new MateriaDTO(_materiaRepositorio.ObterPorNome(Nome));
        }


        public IList<MateriaDTO> ObterTodos(Paginacao paginacao)
        {
            return _materiaRepositorio.ObterTodos(paginacao)
                .Select(x => new MateriaDTO(x)).ToList();
        }

        public int ObterTotal()
        {
            return _materiaRepositorio.ObterTotal();
        }

        
    }
}
