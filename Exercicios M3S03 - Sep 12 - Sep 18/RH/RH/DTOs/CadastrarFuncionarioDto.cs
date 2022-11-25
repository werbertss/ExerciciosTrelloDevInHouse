using RH.Enums;

namespace RH.DTOs
{
    public class CadastrarFuncionarioDto
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public decimal Salario { get; set; }
    }
}
