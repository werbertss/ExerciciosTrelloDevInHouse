using System.ComponentModel.DataAnnotations;

namespace RH.Enums
{
    public enum Permissoes
    {
        [Display(Name = "Funcionario")]
        Funcionario,

        [Display(Name = "Gerente")]
        Gerente,

        [Display(Name = "Administrador")]
        Administrador,
    }
}
