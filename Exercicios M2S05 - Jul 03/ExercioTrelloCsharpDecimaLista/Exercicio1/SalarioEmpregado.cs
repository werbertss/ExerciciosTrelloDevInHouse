using System;
namespace DecimoExercicioTrello;
public class SalarioEmpregado: Empregado
{ 
    public int CodigoFuncionario { get; set; }
    public double ValorSalario { get; set; }

    public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario) : base (id, nome)
    {
        CodigoFuncionario = codigoFuncionario;
        ValorSalario = valorSalario;
    }

    public void CalcularFolhaPagamento()
    {
        System.Console.WriteLine("Calculando folha de pagamento!");
    }
}