using RH.DTOs;
using RH.Models;

namespace RH.Converters
{
    public static class FuncionarioConverter
    {
        public static CadastrarFuncionarioDto ToDto(FuncionarioModel model)
        {
            return new CadastrarFuncionarioDto
            {
                Nome = model.Nome,
                Senha = model.Senha,
                Permissao = model.Permissao,
                Salario = model.Salario
            };
        }

        public static FuncionarioModel ToModel(CadastrarFuncionarioDto dto)
        {
            return new FuncionarioModel
            {
                Nome = dto.Nome,
                Senha = dto.Senha,
                Permissao = dto.Permissao,
                Salario = dto.Salario
            };
        }
    }
}
