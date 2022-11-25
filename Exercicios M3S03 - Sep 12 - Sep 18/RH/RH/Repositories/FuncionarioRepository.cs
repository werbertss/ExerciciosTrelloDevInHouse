using RH.Converters;
using RH.DTOs;
using RH.Enums;
using RH.Models;

namespace RH.Repositories
{
    public class FuncionarioRepository 
    {
        private static List<FuncionarioModel> funcionarios = new List<FuncionarioModel>
        {
            new FuncionarioModel
            {
                Id = 1,
                Nome = "João",
                Senha = "123456",
                Salario = 7000,
                Permissao = Permissoes.Administrador
            }
        };

        public static List<FuncionarioModel> Obter()
        {
            return funcionarios;
        }

        public static FuncionarioModel? ObterPorUsuarioESenha(LoginDto dto)
        {
            var funcionario = funcionarios.FirstOrDefault
                (
                    x => x.Nome == dto.Nome && x.Senha == dto.Senha
                );
            return funcionario;
        }
        
        public static void Adicionar(CadastrarFuncionarioDto dto)
        {
            var adicionarFuncionario = FuncionarioConverter.ToModel(dto);
            adicionarFuncionario.Id = GerarID();
            funcionarios.Add(adicionarFuncionario);
        }

        public static void Excluir(int id)
        {
            var Funcionario = funcionarios.FirstOrDefault(x => x.Id == id);

            if(Funcionario != null)
                funcionarios.Remove(Funcionario);
        }

        //public static void Editar(int id)
        //{
          //  var Funcionario = funcionarios.FirstOrDefault(x => x.Id == id);

            //if(Funcionario != null)
              //  funcionarios.
        //}

        private static int GerarID()
        {
            return funcionarios.Last().Id + 1;
        }
    }
}
