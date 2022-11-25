using RH.Enums;

namespace RH.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public decimal Salario { get; set; }
    }
}
